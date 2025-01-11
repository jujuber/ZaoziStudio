using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.ThirdHis.HisV1.Application.WebHospital.YBMobilePayment.Utils;
internal class StringUtils
{
    public static long CurrentTimeStamp(bool isMinseconds = false)
    {
        TimeSpan timeSpan = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
        return Convert.ToInt64(isMinseconds ? timeSpan.TotalMilliseconds : timeSpan.TotalSeconds);
    }

    public static string SortJson(string json)
    {
        SortedDictionary<string, object> dictionary = JsonConvert.DeserializeObject<SortedDictionary<string, object>>(json);
        SortedDictionary<string, object> sortedDictionary = new SortedDictionary<string, object>(dictionary, StringComparer.Ordinal);
        sortedDictionary.OrderBy((KeyValuePair<string, object> m) => m.Key);
        SortedDictionary<string, object> sortedDictionary2;
        while (true)
        {
        IL_003a:
            sortedDictionary2 = new SortedDictionary<string, object>(sortedDictionary);
            foreach (KeyValuePair<string, object> item in sortedDictionary2)
            {
                Type typeFromHandle = typeof(JObject);
                Type type = typeof(object);
                if (item.Value == "" || item.Value == null)
                {
                    Console.WriteLine(item.Key);
                }
                if (item.Value != null)
                {
                    type = item.Value.GetType();
                }
                if (typeFromHandle == type)
                {
                    continue;
                }
                if (item.Value == null)
                {
                    sortedDictionary.Remove(item.Key);
                    goto IL_003a;
                }
                if (item.Value.GetType() == typeof(string))
                {
                    if (string.IsNullOrEmpty((string)item.Value))
                    {
                        sortedDictionary.Remove(item.Key);
                        goto IL_003a;
                    }
                }
                else if (item.Value.GetType() == typeof(decimal) || item.Value.GetType() == typeof(double) || item.Value.GetType() == typeof(float) || item.Value.GetType() == typeof(int) || item.Value.GetType() == typeof(long))
                {
                    sortedDictionary[item.Key] = item.Value.ToString();
                }
            }
            break;
        }
        foreach (KeyValuePair<string, object> item2 in sortedDictionary2)
        {
            if ("feedetailList".Equals(item2.Key))
            {
                Console.WriteLine(item2.Key);
            }
            Type typeFromHandle2 = typeof(JObject);
            Type type2 = typeof(object);
            if (item2.Value != null)
            {
                type2 = item2.Value.GetType();
            }
            if (typeFromHandle2 == type2)
            {
                string json2 = JsonConvert.SerializeObject(item2.Value);
                json2 = SortJson(json2);
                sortedDictionary[item2.Key] = JsonConvert.DeserializeObject<JObject>(json2);
            }
            if (type2 == typeof(JArray))
            {
                JArray jArray = (JArray)JsonConvert.DeserializeObject(item2.Value.ToString());
                List<JObject> list = new List<JObject>();
                for (int i = 0; i < jArray.Count; i++)
                {
                    string json3 = SortJson(jArray[i].ToString());
                    string value = SortJson(json3);
                    list.Add(JsonConvert.DeserializeObject<JObject>(value));
                }
                sortedDictionary[item2.Key] = list;
            }
        }
        return JsonConvert.SerializeObject(sortedDictionary);
    }

    public static string StortJson(string json)
    {
        return "";
    }

    public static string Json2sign(string json)
    {
        Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
        string text = "";
        foreach (KeyValuePair<string, object> item in dictionary)
        {
            text = string.Concat(text, item.Key, "=", item.Value, "&");
        }
        return text.Substring(0, text.Length - 1);
    }
}
