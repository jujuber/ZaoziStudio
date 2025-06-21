using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace Zaozi.Code.TestUI.XmlToObj.ViewModels
{
    public static class XmlHelper
    {

        public static string XmlToJson(string xml)
        {
           // XDocument xdoc = XDocument.Parse(xml);
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xml);
            return Newtonsoft.Json.JsonConvert.SerializeXmlNode(xdoc,Newtonsoft.Json.Formatting.Indented);
          //  return XElementToJson(xdoc.Root);
        }
        public static T XmlDeserialize<T>(string xml) where T : new()
        {
            try
            {
                XDocument xdoc = XDocument.Parse(xml);
                T obj = new T();
                PopulateObject(obj, xdoc.Root);
                return obj;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return default(T);
            }
        }

        private static void PopulateObject(object obj, XElement element)
        {
            Type objType = obj.GetType();
            foreach (var prop in objType.GetProperties())
            {
                var xmlElement = element.Element(prop.Name);
                if (xmlElement != null)
                {
                    if (prop.PropertyType == typeof(string))
                    {
                        prop.SetValue(obj, xmlElement.Value);
                    }
                    else if (prop.PropertyType == typeof(decimal?))
                    {
                        prop.SetValue(obj, string.IsNullOrEmpty(xmlElement.Value) ? (decimal?)null : decimal.Parse(xmlElement.Value));
                    }
                    //else if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
                    //{
                    //    var nestedObj = Activator.CreateInstance(prop.PropertyType);
                    //    PopulateObject(nestedObj, xmlElement);
                    //    prop.SetValue(obj, nestedObj);
                    //}
                    else if (prop.PropertyType.IsClass && typeof(IEnumerable).IsAssignableFrom(prop.PropertyType))
                    {
                        var listType = prop.PropertyType.GetGenericArguments()[0];
                        var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(listType));
                        foreach (var childElement in xmlElement.Elements())
                        {
                            var listItem = Activator.CreateInstance(listType);
                            PopulateObject(listItem, childElement);
                            list.Add(listItem);
                        }
                        prop.SetValue(obj, list);
                    }
                }
            }
        }
    }
}
