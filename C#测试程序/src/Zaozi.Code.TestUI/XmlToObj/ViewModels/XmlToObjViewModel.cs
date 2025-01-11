using Synyi.Framework.Wpf.Mvvm;
using Synyi.Framework.Wpf.Plugins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml;
using System.Xml.Serialization;

namespace Zaozi.Code.TestUI.XmlToObj.ViewModels
{
    [Plugin(ZaoziConst.Plugins.XmlToObjView, "Xml转换为对象", "Xml转换为对象")]
    public class XmlToObjViewModel : PluginViewModelBase
    {
        protected override Task DoOnNavigatedTo(NavigationContext context)
        {
            return Task.CompletedTask;
        }
        public XmlToObjViewModel()
        {
            XmlCommand = new ActionCommand(ExecuteXmlCommand);
        }
        public ActionCommand XmlCommand { get; set; }
        private void ExecuteXmlCommand()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"GBK\" standalone=\"yes\"?>"+
                "<output>"+
                "<prm_aac001>1</prm_aac001>" +
                "<prm_akc021>2</prm_akc021>" +
                "<prm_ykc010>" +
                "<row>" +
                "<akb020>3</akb020>" +
                "<yab003>4</yab003>" +
                "</row>" +
                "<row>" +
                "<akb020>5</akb020>" +
                "<yab003>6</yab003>" +
                "</row>" + 
                "</prm_ykc010>" +
                "</output>";
            XmlObj obj = XmlDeserialize<XmlObj>(xml);
        }

        public static T XmlDeserialize<T>(string sMsg)
        {
            try
            {
                XmlSerializer serial = new XmlSerializer(typeof(T));
                using (StringReader sreader = new StringReader(sMsg))
                {
                    T result = (T)serial.Deserialize(sreader);
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return default(T);
            }
        }
    }
    [XmlRoot("output")]
    public class XmlObj
    {
        public string prm_aac001 { get; set; }
        public string prm_akc021 { get; set; }
        public prm_ykc010 prm_ykc010 { get; set; }
    }

    public class prm_ykc010
    {
        [XmlElement("row")]
        public List<XmlObj2> row { get; set; }
    }
    public class XmlObj2
    {
        public string akb020 { get; set; }
        public string yab003 { get; set; }
    }
}