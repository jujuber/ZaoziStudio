using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zaozi.Code.TestUI.Crypto.ViewModels;
public class MD5Helper
{
    /// <summary>
    /// 计算签名信息
    /// </summary>
    /// <param name="parameters">代价密的键值对</param>
    /// <param name="publickey">签名密钥</param>
    /// <returns>计算后的签名</returns>
    public static string MakeSign(IDictionary<string, string> parameters, string publickey)
    {
        string signContent = GetSignContent(parameters);
        string sBlock = signContent + "&key=" + publickey;
        return MakeSigns(sBlock, true);
    }

    /// <summary>
    /// 计算签名
    /// </summary>
    /// <param name="sBlock">待签名的字符串</param>
    /// <param name="publickey">密钥</param>
    /// <returns></returns>
    public static string MakeSign(string sBlock, string publickey)
    {
        sBlock = sBlock + "&key=" + publickey;
        return MakeSigns(sBlock, true);
    }

    /// <summary>
    /// 计算签名
    /// </summary>
    /// <param name="block">待签名的字符串</param>
    /// <param name="isToUpper">是否转大写</param>
    /// <returns></returns>
    public static string MakeSigns(string block, bool isToUpper)
    {
        //转url格式
        string str = block; 
        var md5 = MD5.Create();
        var bs = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
        var sb = new StringBuilder();
        foreach (byte b in bs)
        {
            sb.Append(b.ToString("x2"));
        }
        md5.Dispose();

        string sResult = sb.ToString();

        if (isToUpper) return sb.ToString().ToUpper();
        else return sb.ToString();
    }

    /// <summary>
    /// 计算待加密的字符串
    /// </summary>
    /// <param name="parameters">参数键值对</param>
    /// <returns>待加密的字符串</returns>
    public static string GetSignContent(IDictionary<string, string> parameters)
    {
        return GetSignContent(parameters, true);
    }

    /// <summary>
    /// 计算待加密的字符串
    /// </summary>
    /// <param name="parameters">待加密的key-value值</param>
    /// <param name="isCheckValue">空值是否过滤 true：过滤 false：不过滤</param>
    /// <returns>待加密的字符串</returns>
    public static string GetSignContent(IDictionary<string, string> parameters, bool isCheckValue)
    {
        // 第一步：把字典按Key的字母顺序排序
        IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters);
        IEnumerator<KeyValuePair<string, string>> dem = sortedParams.GetEnumerator();

        // 第二步：把所有参数名和参数值串在一起
        StringBuilder query = new StringBuilder("");
        while (dem.MoveNext())
        {
            string key = dem.Current.Key;
            string value = dem.Current.Value;
            if (key.ToUpper() == "SIGN") continue;
            if (!string.IsNullOrEmpty(key))
            {
                if (isCheckValue)
                {
                    if (!string.IsNullOrEmpty(value))
                        query.Append(key).Append("=").Append(value).Append("&");
                }
                else
                    query.Append(key).Append("=").Append(value).Append("&");
            }
        }
        string content = query.ToString().Substring(0, query.Length - 1);

        return content;
    }
}
