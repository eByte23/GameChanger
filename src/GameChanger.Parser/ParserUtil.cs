using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace GameChanger.Parser
{
    public static class ParserUtil
    {

        public static GameChangerXmlFile.Game Deserialize(string xmlString)
            => Deserialize<GameChangerXmlFile.Game>(xmlString);




        public static string SerializeToString<T>(T value)
        {
            var emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(value.GetType());
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, value, emptyNamespaces);
                return stream.ToString();
            }
        }

        public static T Deserialize<T>(string objectXml)
        {
            var emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty, new XmlQualifiedName("xs", "http://www.w3.org/2001/XMLSchema") });

            object retVal = null;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            var settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.ConformanceLevel = ConformanceLevel.Document;
            settings.DtdProcessing = DtdProcessing.Parse;

            using (StringReader stringReader = new StringReader(objectXml))
            using (var xmlReader = XmlReader.Create(stringReader, settings))
            {

                retVal = serializer.Deserialize(xmlReader);
                return (T)retVal;
            }
        }

        public static T DeserializeFromXmlString<T>(string objectXml, Type targetType)
        {

            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "propertyList";
            // xRoot.Namespace = "http://www.cpandl.com";
            xRoot.IsNullable = true;
            object retVal = null;
            XmlSerializer serializer = new XmlSerializer(targetType, xRoot);

            using (StringReader stringReader = new StringReader(objectXml))
            using (XmlTextReader xmlReader = new XmlTextReader(stringReader))
            {

                retVal = serializer.Deserialize(xmlReader);
                // return (Oryx.Api.Tests.propertyList)retVal;
                return (T)retVal;
            }
        }
    }
}