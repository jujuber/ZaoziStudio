using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaozi.Code.TestUI.Crypto.Utils;
public static class SM2Util
{
    private const int MAX_ENCRYPT_BLOCK = 117; // SM2 加密的最大块大小
    private const int MAX_DECRYPT_BLOCK = 128; // SM2 解密的最大块大小

    static SM2Util()
    {
        // BouncyCastle 的静态初始化
    }

    // 使用公钥进行分段加密
    public static string Encrypt(string publicKeyBase64, string data)
    {
        X9ECParameters sm2ECParameters = ECNamedCurveTable.GetByName("sm2p256v1");
        ECDomainParameters sm2DomainParameters = new ECDomainParameters(sm2ECParameters.Curve, sm2ECParameters.G, sm2ECParameters.N, sm2ECParameters.H);

        // 将 Base64 编码的公钥解析为 ECPublicKeyParameters
        byte[] publicKeyBytes = Convert.FromBase64String(publicKeyBase64);
        ECPublicKeyParameters publicKey = (ECPublicKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);

        SM2Engine sm2Engine = new SM2Engine();
        sm2Engine.Init(true, new ParametersWithRandom(publicKey, new SecureRandom()));

        byte[] plainBytes = System.Text.Encoding.UTF8.GetBytes(data);
        byte[] encryptedData = DoFinal(sm2Engine, plainBytes, true);

        return Convert.ToBase64String(encryptedData);
    }

    // 使用私钥进行分段解密
    public static string Decrypt(string privateKeyBase64, string encryptedDataBase64)
    {
        X9ECParameters sm2ECParameters = ECNamedCurveTable.GetByName("sm2p256v1");
        ECDomainParameters sm2DomainParameters = new ECDomainParameters(sm2ECParameters.Curve, sm2ECParameters.G, sm2ECParameters.N, sm2ECParameters.H);

        ECPrivateKeyParameters privateKey = (ECPrivateKeyParameters)PrivateKeyFactory.CreateKey(Convert.FromBase64String(privateKeyBase64));

        SM2Engine sm2Engine = new SM2Engine();
        sm2Engine.Init(false, privateKey);

        byte[] encryptedBytes = Convert.FromBase64String(encryptedDataBase64);
        byte[] decryptedData = DoFinal(sm2Engine, encryptedBytes, false);

        return System.Text.Encoding.UTF8.GetString(decryptedData);
    }

    private static byte[] DoFinal(SM2Engine engine, byte[] input, bool forEncryption)
    {
        int blockSize = forEncryption ? MAX_ENCRYPT_BLOCK : MAX_DECRYPT_BLOCK;
        using (MemoryStream ms = new MemoryStream())
        {
            int offset = 0;
            while (input.Length - offset > 0)
            {
                int length = Math.Min(input.Length - offset, blockSize);
                byte[] block = engine.ProcessBlock(input, offset, length);
                ms.Write(block, 0, block.Length);
                offset += length;
            }
            return ms.ToArray();
        }
    }
}
