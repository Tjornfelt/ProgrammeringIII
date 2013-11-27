using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Programmering_III.Models;

namespace Programmering_III.Helpers
{
    public static class XMLHelpers
    {
        public static void SaveCredentialsAsXml(Credentials c)
        {
            var serializer = new XmlSerializer(typeof(Credentials));
            using (var writer = XmlWriter.Create("credentials.xml"))
            {
                serializer.Serialize(writer, c);
            }
        }

        public static Credentials ReadCredentialsFromXml()
        {
            var serializer = new XmlSerializer(typeof(Credentials));
            Credentials c;
            using (var reader = XmlReader.Create("credentials.xml"))
            {
                c = (Credentials)serializer.Deserialize(reader);
            }
            return c;
        }
    }
}
