using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Math;
using Newtonsoft.Json;
using CommonUtils;

namespace Synyi.ThirdHis.HisV1.Application.WebHospital.YBMobilePayment.Utils;
internal class SignUtil
{
    public static string signSm3WithSm2(string chnlId, string sm4key, string prvkey, string data)
    {
        byte[] bytes = Convert.FromBase64String(prvkey);
        BigInteger d = new BigInteger(bytes);
        ECPrivateKeyParameters privatekeyFromD = GmUtil.GetPrivatekeyFromD(d);
        byte[] bytes2 = Encoding.UTF8.GetBytes(data);
        byte[] inArray = GmUtil.SignSm3WithSm2(bytes2, Encoding.UTF8.GetBytes(sm4key), privatekeyFromD);
        return Convert.ToBase64String(inArray);
    }

    public static bool verifySm3WithSm2(string msg, string sm4key, string signData, string pubKey)
    {
        byte[] array = Convert.FromBase64String(pubKey);
        string text = BitConverter.ToString(array);
        AsymmetricKeyParameter publickeyFromXY = GmUtil.GetPublickeyFromXY(array);
        byte[] rs = Convert.FromBase64String(signData);
        byte[] bytes = Encoding.UTF8.GetBytes(msg);
        return GmUtil.VerifySm3WithSm2(bytes, Encoding.UTF8.GetBytes(sm4key), rs, publickeyFromXY);
    }

    public static string getSignText(string chnlId, string sm4key, string data, long ts)
    {
        string text = StringUtils.SortJson(data);
        JObject jObject = new JObject();
        jObject.Add("appId", chnlId);
        jObject.Add("data", text);
        jObject.Add("encType", "SM4");
        jObject.Add("signType", "SM2");
        if (ts == 0)
        {
            jObject.Add("timestamp", Convert.ToString(StringUtils.CurrentTimeStamp(isMinseconds: true)));
        }
        else
        {
            jObject.Add("timestamp", Convert.ToString(ts));
        }
        jObject.Add("version", "2.0.1");
        string json = jObject.ToString(Formatting.None, (JsonConverter[])null);
        string text2 = StringUtils.Json2sign(json);
        return text2 + "&key=" + sm4key;
    }

    public static string encryptMsg(string chnlId, string sm4key, string prvkey, string data, ref string rtSignPlain)
    {
        long num = StringUtils.CurrentTimeStamp(isMinseconds: true);
        string signText = getSignText(chnlId, sm4key, data, num);
        string text = signSm3WithSm2(chnlId, sm4key, prvkey, signText);
        string text2 = sm4Encrypt(chnlId, sm4key, data);
        JObject jObject = new JObject();
        jObject.Add("appId", chnlId);
        jObject.Add("encData", text2);
        jObject.Add("encType", "SM4");
        jObject.Add("signData", text);
        jObject.Add("signType", "SM2");
        jObject.Add("timestamp", Convert.ToString(num));
        jObject.Add("version", "2.0.1");
        rtSignPlain = signText;
        return jObject.ToString(Formatting.None, (JsonConverter[])null);
    }

    public static string encryptMsg(string chnlId, string sm4key, string prvkey, string data)
    {
        long num = StringUtils.CurrentTimeStamp(isMinseconds: true);
        string signText = getSignText(chnlId, sm4key, data, num);
        string text = signSm3WithSm2(chnlId, sm4key, prvkey, signText);
        string text2 = sm4Encrypt(chnlId, sm4key, data);
        JObject jObject = new JObject();
        jObject.Add("appId", chnlId);
        jObject.Add("encData", text2);
        jObject.Add("encType", "SM4");
        jObject.Add("signData", text);
        jObject.Add("signType", "SM2");
        jObject.Add("timestamp", Convert.ToString(num));
        jObject.Add("version", "2.0.1");
        return jObject.ToString(Formatting.None, (JsonConverter[])null);
    }

    public static string sm4Encrypt(string chnlId, string sm4key, string message)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(chnlId.Substring(0, 16));
        byte[] bytes2 = Encoding.UTF8.GetBytes(sm4key);
        byte[] bytes3 = Encoding.UTF8.GetBytes(message);
        byte[] data = GmUtil.Sm4EncryptECB(bytes, bytes2, "SM4/ECB/PKCS7Padding");
        string text = Hex.ToHexString(data).ToUpper();
        byte[] bytes4 = Encoding.UTF8.GetBytes(text.Substring(0, 16));
        byte[] data2 = GmUtil.Sm4EncryptECB(bytes4, bytes3, "SM4/ECB/PKCS7Padding");
        return Hex.ToHexString(data2);
    }

    public static string sm4Decrypt(string chnlId, string sm4key, string message)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(chnlId.Substring(0, 16));
        byte[] bytes2 = Encoding.UTF8.GetBytes(sm4key);
        byte[] cipher = Hex.Decode(message);
        byte[] array = GmUtil.Sm4EncryptECB(bytes, bytes2, "SM4/ECB/PKCS7Padding");
        string text = BitConverter.ToString(array, 0).Replace("-", string.Empty).ToUpper();
        byte[] bytes3 = Encoding.UTF8.GetBytes(text.Substring(0, 16));
        byte[] bytes4 = GmUtil.Sm4DecryptECB(bytes3, cipher, "SM4/ECB/PKCS7Padding");
        return Encoding.UTF8.GetString(bytes4);
    }
}