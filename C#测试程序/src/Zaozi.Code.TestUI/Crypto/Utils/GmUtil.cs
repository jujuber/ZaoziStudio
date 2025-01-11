using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.GM;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.X509;
using System.IO;
using System.Text;

namespace CommonUtils
{
    public class GmUtil
    {
        public class Sm2Cert
        {
            public AsymmetricKeyParameter privateKey;

            public AsymmetricKeyParameter publicKey;

            public string certId;
        }

        private static X9ECParameters x9ECParameters = GMNamedCurves.GetByName("sm2p256v1");

        private static ECDomainParameters ecDomainParameters = new ECDomainParameters(x9ECParameters.Curve, x9ECParameters.G, x9ECParameters.N);

        private const int RS_LEN = 32;

        public const string SM4_ECB_NOPADDING = "SM4/ECB/NoPadding";

        public const string SM4_ECB_PKCS7PADDING = "SM4/ECB/PKCS7Padding";

        public const string SM4_CBC_NOPADDING = "SM4/CBC/NoPadding";

        public const string SM4_CBC_PKCS7PADDING = "SM4/CBC/PKCS7Padding";

        public static byte[] SignSm3WithSm2(byte[] msg, byte[] userId, AsymmetricKeyParameter privateKey)
        {
            return RsAsn1ToPlainByteArray(SignSm3WithSm2Asn1Rs(msg, userId, privateKey));
        }

        public static byte[] SignSm3WithSm2Asn1Rs(byte[] msg, byte[] userId, AsymmetricKeyParameter privateKey)
        {
            try
            {
                ISigner signer = SignerUtilities.GetSigner("SM3withSM2");
                signer.Init(forSigning: true, new ParametersWithRandom(privateKey));
                signer.BlockUpdate(msg, 0, msg.Length);
                return signer.GenerateSignature();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool VerifySm3WithSm2(byte[] msg, byte[] userId, byte[] rs, AsymmetricKeyParameter publicKey)
        {
            if (rs == null || msg == null || userId == null)
            {
                return false;
            }
            if (rs.Length != 64)
            {
                return false;
            }
            return VerifySm3WithSm2Asn1Rs(msg, userId, RsPlainByteArrayToAsn1(rs), publicKey);
        }

        public static bool VerifySm3WithSm2Asn1Rs(byte[] msg, byte[] userId, byte[] sign, AsymmetricKeyParameter publicKey)
        {
            try
            {
                ISigner signer = SignerUtilities.GetSigner("SM3withSM2");
                signer.Init(forSigning: false, publicKey);
                signer.BlockUpdate(msg, 0, msg.Length);
                return signer.VerifySignature(sign);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static byte[] ChangeC1C2C3ToC1C3C2(byte[] c1c2c3)
        {
            int num = (x9ECParameters.Curve.FieldSize + 7) / 8 * 2 + 1;
            byte[] array = new byte[c1c2c3.Length];
            Buffer.BlockCopy(c1c2c3, 0, array, 0, num);
            Buffer.BlockCopy(c1c2c3, c1c2c3.Length - 32, array, num, 32);
            Buffer.BlockCopy(c1c2c3, num, array, num + 32, c1c2c3.Length - num - 32);
            return array;
        }

        private static byte[] ChangeC1C3C2ToC1C2C3(byte[] c1c3c2)
        {
            int num = (x9ECParameters.Curve.FieldSize + 7) / 8 * 2 + 1;
            byte[] array = new byte[c1c3c2.Length];
            Buffer.BlockCopy(c1c3c2, 0, array, 0, num);
            Buffer.BlockCopy(c1c3c2, num + 32, array, num, c1c3c2.Length - num - 32);
            Buffer.BlockCopy(c1c3c2, num, array, c1c3c2.Length - 32, 32);
            return array;
        }

        public static byte[] Sm2Decrypt(byte[] data, AsymmetricKeyParameter key)
        {
            return Sm2DecryptOld(ChangeC1C3C2ToC1C2C3(data), key);
        }

        public static byte[] Sm2Encrypt(byte[] data, AsymmetricKeyParameter key)
        {
            return ChangeC1C2C3ToC1C3C2(Sm2EncryptOld(data, key));
        }

        public static byte[] Sm2EncryptOld(byte[] data, AsymmetricKeyParameter pubkey)
        {
            try
            {
                SM2Engine sM2Engine = new SM2Engine();
                sM2Engine.Init(forEncryption: true, new ParametersWithRandom(pubkey, new SecureRandom()));
                return sM2Engine.ProcessBlock(data, 0, data.Length);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static byte[] Sm2DecryptOld(byte[] data, AsymmetricKeyParameter key)
        {
            try
            {
                SM2Engine sM2Engine = new SM2Engine();
                sM2Engine.Init(forEncryption: false, key);
                return sM2Engine.ProcessBlock(data, 0, data.Length);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static byte[] Sm3(byte[] bytes)
        {
            try
            {
                SM3Digest sM3Digest = new SM3Digest();
                sM3Digest.BlockUpdate(bytes, 0, bytes.Length);
                return DigestUtilities.DoFinal(sM3Digest);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static byte[] BigIntToFixexLengthBytes(BigInteger rOrS)
        {
            byte[] array = rOrS.ToByteArray();
            if (array.Length == 32)
            {
                return array;
            }
            if (array.Length == 33 && array[0] == 0)
            {
                return Arrays.CopyOfRange(array, 1, 33);
            }
            if (array.Length < 32)
            {
                byte[] array2 = new byte[32];
                Arrays.Fill(array2, 0);
                Buffer.BlockCopy(array, 0, array2, 32 - array.Length, array.Length);
                return array2;
            }
            throw new ArgumentException("err rs: " + Hex.ToHexString(array));
        }

        private static byte[] RsAsn1ToPlainByteArray(byte[] rsDer)
        {
            Asn1Sequence instance = Asn1Sequence.GetInstance(rsDer);
            byte[] array = BigIntToFixexLengthBytes(DerInteger.GetInstance(instance[0]).Value);
            byte[] array2 = BigIntToFixexLengthBytes(DerInteger.GetInstance(instance[1]).Value);
            byte[] array3 = new byte[64];
            Buffer.BlockCopy(array, 0, array3, 0, array.Length);
            Buffer.BlockCopy(array2, 0, array3, 32, array2.Length);
            return array3;
        }

        private static byte[] RsPlainByteArrayToAsn1(byte[] sign)
        {
            if (sign.Length != 64)
            {
                throw new ArgumentException("err rs. ");
            }
            BigInteger value = new BigInteger(1, Arrays.CopyOfRange(sign, 0, 32));
            BigInteger value2 = new BigInteger(1, Arrays.CopyOfRange(sign, 32, 64));
            Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector();
            asn1EncodableVector.Add(new DerInteger(value));
            asn1EncodableVector.Add(new DerInteger(value2));
            try
            {
                return new DerSequence(asn1EncodableVector).GetEncoded("DER");
            }
            catch (IOException)
            {
                return null;
            }
        }

        public static AsymmetricCipherKeyPair GenerateKeyPair()
        {
            try
            {
                ECKeyPairGenerator eCKeyPairGenerator = new ECKeyPairGenerator();
                eCKeyPairGenerator.Init(new ECKeyGenerationParameters(ecDomainParameters, new SecureRandom()));
                return eCKeyPairGenerator.GenerateKeyPair();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static ECPrivateKeyParameters GetPrivatekeyFromD(BigInteger d)
        {
            return new ECPrivateKeyParameters(d, ecDomainParameters);
        }

        public static ECPublicKeyParameters GetPublickeyFromXY(byte[] pubkey)
        {
            X9ECParameters byName = GMNamedCurves.GetByName("SM2P256V1");
            ECPoint q = byName.Curve.DecodePoint(pubkey);
            ECDomainParameters parameters = new ECDomainParameters(x9ECParameters.Curve, x9ECParameters.G, x9ECParameters.N);
            return new ECPublicKeyParameters(q, parameters);
        }

        public static ECPublicKeyParameters GetPublickeyFromXY(BigInteger x, BigInteger y)
        {
            return new ECPublicKeyParameters(x9ECParameters.Curve.CreatePoint(x, y), ecDomainParameters);
        }

        public static AsymmetricKeyParameter GetPublickeyFromX509File(FileInfo file)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
                X509Certificate x509Certificate = new X509CertificateParser().ReadCertificate(fileStream);
                return x509Certificate.GetPublicKey();
            }
            catch (Exception)
            {
            }
            finally
            {
                fileStream?.Close();
            }
            return null;
        }

        private static byte[] ToByteArray(int i)
        {
            return new byte[4]
            {
            (byte)(i >> 24),
            (byte)((i & 0xFFFFFF) >> 16),
            (byte)((i & 0xFFFF) >> 8),
            (byte)((uint)i & 0xFFu)
            };
        }

        private static byte[] Join(params byte[][] byteArrays)
        {
            List<byte> list = new List<byte>();
            for (int i = 0; i < byteArrays.Length; i++)
            {
                list.AddRange(byteArrays[i]);
            }
            return list.ToArray();
        }

        private static byte[] KDF(byte[] Z, int klen)
        {
            int num = 1;
            int num2 = (int)Math.Ceiling((double)klen * 1.0 / 32.0);
            List<byte> list = new List<byte>();
            try
            {
                for (int i = 1; i < num2; i++)
                {
                    list.AddRange(Sm3(Join(Z, ToByteArray(num))));
                    num++;
                }
                byte[] array = Sm3(Join(Z, ToByteArray(num)));
                if (klen % 32 == 0)
                {
                    list.AddRange(array);
                }
                else
                {
                    list.AddRange(Arrays.CopyOfRange(array, 0, klen % 32));
                }
                return list.ToArray();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public static byte[] Sm4DecryptCBC(byte[] keyBytes, byte[] cipher, byte[] iv, string algo)
        {
            if (keyBytes.Length != 16)
            {
                throw new ArgumentException("err key length");
            }
            if (cipher.Length % 16 != 0)
            {
                throw new ArgumentException("err data length");
            }
            try
            {
                KeyParameter parameters = ParameterUtilities.CreateKeyParameter("SM4", keyBytes);
                IBufferedCipher cipher2 = CipherUtilities.GetCipher(algo);
                if (iv == null)
                {
                    iv = ZeroIv(algo);
                }
                cipher2.Init(forEncryption: false, new ParametersWithIV(parameters, iv));
                return cipher2.DoFinal(cipher);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static byte[] Sm4EncryptCBC(byte[] keyBytes, byte[] plain, byte[] iv, string algo)
        {
            if (keyBytes.Length != 16)
            {
                throw new ArgumentException("err key length");
            }
            if (plain.Length % 16 != 0)
            {
                throw new ArgumentException("err data length");
            }
            try
            {
                KeyParameter parameters = ParameterUtilities.CreateKeyParameter("SM4", keyBytes);
                IBufferedCipher cipher = CipherUtilities.GetCipher(algo);
                if (iv == null)
                {
                    iv = ZeroIv(algo);
                }
                cipher.Init(forEncryption: true, new ParametersWithIV(parameters, iv));
                return cipher.DoFinal(plain);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static byte[] Sm4EncryptECB(byte[] keyBytes, byte[] plain, string algo)
        {
            if (keyBytes.Length != 16)
            {
                throw new ArgumentException("err key length");
            }
            try
            {
                KeyParameter parameters = ParameterUtilities.CreateKeyParameter("SM4", keyBytes);
                IBufferedCipher cipher = CipherUtilities.GetCipher(algo);
                cipher.Init(forEncryption: true, parameters);
                return cipher.DoFinal(plain);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static byte[] Sm4DecryptECB(byte[] keyBytes, byte[] cipher, string algo)
        {
            if (cipher.Length % 16 != 0)
            {
                throw new ArgumentException("err data length");
            }
            try
            {
                KeyParameter parameters = ParameterUtilities.CreateKeyParameter("SM4", keyBytes);
                IBufferedCipher cipher2 = CipherUtilities.GetCipher(algo);
                cipher2.Init(forEncryption: false, parameters);
                return cipher2.DoFinal(cipher);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Sm2Cert readSm2File(byte[] pem, string pwd)
        {
            Sm2Cert sm2Cert = new Sm2Cert();
            try
            {
                Asn1Sequence asn1Sequence = (Asn1Sequence)Asn1Object.FromByteArray(pem);
                Asn1Sequence asn1Sequence2 = (Asn1Sequence)asn1Sequence[1];
                Asn1Sequence asn1Sequence3 = (Asn1Sequence)asn1Sequence[2];
                Asn1OctetString asn1OctetString = (Asn1OctetString)asn1Sequence2[2];
                byte[] data = KDF(Encoding.UTF8.GetBytes(pwd), 32);
                byte[] bytes = Sm4DecryptCBC(Arrays.CopyOfRange(data, 16, 32), asn1OctetString.GetOctets(), Arrays.CopyOfRange(data, 0, 16), "SM4/CBC/PKCS7Padding");
                sm2Cert.privateKey = GetPrivatekeyFromD(new BigInteger(1, bytes));
                Asn1OctetString asn1OctetString2 = (Asn1OctetString)asn1Sequence3[1];
                X509Certificate x509Certificate = new X509CertificateParser().ReadCertificate(asn1OctetString2.GetOctets());
                sm2Cert.publicKey = x509Certificate.GetPublicKey();
                sm2Cert.certId = x509Certificate.SerialNumber.ToString(10);
                return sm2Cert;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Sm2Cert ReadSm2X509Cert(byte[] cert)
        {
            Sm2Cert sm2Cert = new Sm2Cert();
            try
            {
                X509Certificate x509Certificate = new X509CertificateParser().ReadCertificate(cert);
                sm2Cert.publicKey = x509Certificate.GetPublicKey();
                sm2Cert.certId = x509Certificate.SerialNumber.ToString(10);
                return sm2Cert;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static byte[] ZeroIv(string algo)
        {
            try
            {
                IBufferedCipher cipher = CipherUtilities.GetCipher(algo);
                int blockSize = cipher.GetBlockSize();
                byte[] array = new byte[blockSize];
                Arrays.Fill(array, 0);
                return array;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void Main2(string[] s)
        {
            foreach (string name in GMNamedCurves.Names)
            {
            }
            AsymmetricCipherKeyPair asymmetricCipherKeyPair = GenerateKeyPair();
            byte[] bytes = Encoding.UTF8.GetBytes("message digest");
            byte[] bytes2 = Encoding.UTF8.GetBytes("userId");
            byte[] array = SignSm3WithSm2(bytes, bytes2, asymmetricCipherKeyPair.Private);
            BigInteger d = new BigInteger("097b5230ef27c7df0fa768289d13ad4e8a96266f0fcb8de40d5942af4293a54a", 16);
            ECPrivateKeyParameters privatekeyFromD = GetPrivatekeyFromD(d);
            AsymmetricKeyParameter publickeyFromX509File = GetPublickeyFromX509File(new FileInfo("d:/certs/69629141652.cer"));
            AsymmetricKeyParameter publickeyFromXY = GetPublickeyFromXY(new BigInteger("59cf9940ea0809a97b1cbffbb3e9d96d0fe842c1335418280bfc51dd4e08a5d4", 16), new BigInteger("9a7f77c578644050e09a9adc4245d1e6eba97554bc8ffd4fe15a78f37f891ff8", 16));
            AsymmetricCipherKeyPair asymmetricCipherKeyPair2 = GenerateKeyPair();
            AsymmetricKeyParameter @public = asymmetricCipherKeyPair2.Public;
            AsymmetricKeyParameter @private = asymmetricCipherKeyPair2.Private;
            byte[] data = Sm2Encrypt(Encoding.UTF8.GetBytes("s"), @public);
            data = Sm2Decrypt(data, @private);
            byte[] plain = Hex.Decode("0123456789abcdeffedcba98765432100123456789abcdeffedcba98765432100123456789abcdeffedcba9876543210");
            byte[] keyBytes = Hex.Decode("0123456789abcdeffedcba9876543210");
            byte[] array2 = Hex.Decode("595298c7c6fd271f0402f804c33d3f66");
            data = Sm4EncryptECB(keyBytes, plain, "SM4/ECB/NoPadding");
            data = Sm4DecryptECB(keyBytes, data, "SM4/ECB/NoPadding");
            string s2 = "MIIDHQIBATBHBgoqgRzPVQYBBAIBBgcqgRzPVQFoBDDW5/I9kZhObxXE9Vh1CzHdZhIhxn+3byBU\nUrzmGRKbDRMgI3hJKdvpqWkM5G4LNcIwggLNBgoqgRzPVQYBBAIBBIICvTCCArkwggJdoAMCAQIC\nBRA2QSlgMAwGCCqBHM9VAYN1BQAwXDELMAkGA1UEBhMCQ04xMDAuBgNVBAoMJ0NoaW5hIEZpbmFu\nY2lhbCBDZXJ0aWZpY2F0aW9uIEF1dGhvcml0eTEbMBkGA1UEAwwSQ0ZDQSBURVNUIFNNMiBPQ0Ex\nMB4XDTE4MTEyNjEwMTQxNVoXDTIwMTEyNjEwMTQxNVowcjELMAkGA1UEBhMCY24xEjAQBgNVBAoM\nCUNGQ0EgT0NBMTEOMAwGA1UECwwFQ1VQUkExFDASBgNVBAsMC0VudGVycHJpc2VzMSkwJwYDVQQD\nDCAwNDFAWnRlc3RAMDAwMTAwMDA6U0lHTkAwMDAwMDAwMTBZMBMGByqGSM49AgEGCCqBHM9VAYIt\nA0IABDRNKhvnjaMUShsM4MJ330WhyOwpZEHoAGfqxFGX+rcL9x069dyrmiF3+2ezwSNh1/6YqfFZ\nX9koM9zE5RG4USmjgfMwgfAwHwYDVR0jBBgwFoAUa/4Y2o9COqa4bbMuiIM6NKLBMOEwSAYDVR0g\nBEEwPzA9BghggRyG7yoBATAxMC8GCCsGAQUFBwIBFiNodHRwOi8vd3d3LmNmY2EuY29tLmNuL3Vz\nL3VzLTE0Lmh0bTA4BgNVHR8EMTAvMC2gK6AphidodHRwOi8vdWNybC5jZmNhLmNvbS5jbi9TTTIv\nY3JsNDI4NS5jcmwwCwYDVR0PBAQDAgPoMB0GA1UdDgQWBBREhx9VlDdMIdIbhAxKnGhPx8FcHDAd\nBgNVHSUEFjAUBggrBgEFBQcDAgYIKwYBBQUHAwQwDAYIKoEcz1UBg3UFAANIADBFAiEAgWvQi3h6\niW4jgF4huuXfhWInJmTTYr2EIAdG8V4M8fYCIBixygdmfPL9szcK2pzCYmIb6CBzo5SMv50Odycc\nVfY6";
            data = Convert.FromBase64String(s2);
            string pwd = "cfca1234";
            Sm2Cert sm2Cert = readSm2File(data, pwd);
            data = Sm2Encrypt(Encoding.UTF8.GetBytes("s"), (ECPublicKeyParameters)sm2Cert.publicKey);
            data = Sm2Decrypt(data, (ECPrivateKeyParameters)sm2Cert.privateKey);
            bytes = Encoding.UTF8.GetBytes("message digest");
            bytes2 = Encoding.UTF8.GetBytes("userId");
            array = SignSm3WithSm2(bytes, bytes2, (ECPrivateKeyParameters)sm2Cert.privateKey);
        }
    }
}

