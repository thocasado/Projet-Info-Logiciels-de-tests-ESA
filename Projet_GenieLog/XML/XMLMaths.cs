using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Projet_GenieLog.XML
{
    public class XMLMaths
    {
        private List<Maths> mathsList;
        private string filepath;

        public XMLMaths()
        {
            filepath = @"maths.xml";

                StreamReader sr = new StreamReader(filepath);
                mathsList = (List<Maths>)new XmlSerializer(typeof(List<Maths>)).Deserialize(sr);
                sr.Close();
          
        }


    }
}
