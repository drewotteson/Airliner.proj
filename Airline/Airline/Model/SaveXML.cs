using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Airline
{
    public class SaveXML
    {
        public static void SaveData (object obj, object obj2, string filename)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            XmlSerializer sr2 = new XmlSerializer(obj2.GetType());
            TextWriter writer = new StreamWriter(filename);
            sr.Serialize(writer, obj);
            sr2.Serialize(writer, obj2);
            writer.Close();
        }
    }
}
