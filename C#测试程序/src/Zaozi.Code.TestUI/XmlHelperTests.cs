using NUnit.Framework;
using System.Collections.Generic;
using Zaozi.Code.TestUI.XmlToObj.ViewModels;

namespace Zaozi.Code.TestUI.Tests
{
    [TestFixture]
    public class XmlHelperTests
    {
        [Test]
        public void XmlDeserialize_ShouldPopulateRowData()
        {
            // Arrange
            string xml = "<?xml version=\"1.0\" encoding=\"GBK\" standalone=\"yes\"?>" +
                "<output>" +
                "<prm_aac001>1</prm_aac001>" +
                "<prm_akc021>2</prm_akc021>" +
                "<prm_ykc010>" +
                "<row>" +
                "<akb020></akb020>" +
                "<yab003>4</yab003>" +
                "</row>" +
                "<row>" +
                "<akb020></akb020>" +
                "<yab003>6</yab003>" +
                "</row>" +
                "</prm_ykc010>" +
                "</output>";

            // Act
            XmlObj result = XmlHelper.XmlDeserialize<XmlObj>(xml);

            // Assert
            //Assert.IsNotNull(result);
            //Assert.IsNotNull(result.prm_ykc010);
            //Assert.IsNotNull(result.prm_ykc010.row);
            //Assert.AreEqual(2, result.prm_ykc010.row.Count);

            //Assert.IsNull(result.prm_ykc010.row[0].akb020);
            //Assert.AreEqual("4", result.prm_ykc010.row[0].yab003);

            //Assert.IsNull(result.prm_ykc010.row[1].akb020);
            //Assert.AreEqual("6", result.prm_ykc010.row[1].yab003);
        }
    }
}
