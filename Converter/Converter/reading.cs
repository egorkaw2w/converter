using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Converter
{
    internal class reading
    {
        List<figure> figures = new List<figure>();

        public reading(string path)
        {
            if (path.EndsWith(".txt"))
            {
                string[] lines = File.ReadAllLines(path);
                int i = 0;
                while (lines.Length != i)
                {
                    figures.Add(new figure(lines[i], int.Parse(lines[i + 1]), int.Parse(lines[i + 2])));
                    i += 3;
                }
                foreach (var item in figures)
                {
                    item.wrinfo();
                }
            }
            else if (path.EndsWith(".json"))
            {

                string text = File.ReadAllText(path);
                figures  = JsonConvert.DeserializeObject<List<figure>>(text);
                foreach (var item in figures)
                {
                    item.wrinfo();
                }
            }

            else if (path.EndsWith(".xml"))
            {
                
                XmlSerializer xml = new XmlSerializer(typeof(List<figure>));
                using (FileStream fs = new FileStream(path,FileMode.Open))
                {
                    figures = (List<figure>)xml.Deserialize(fs);
                }
                foreach (var item in figures)
                {
                    item.wrinfo();
                }
            }

        }
        public void wrtiting(string path)
        {
            if (path.EndsWith(".txt"))
            {
                Program.boba();
                StringBuilder sb = new StringBuilder();
                foreach (var item in figures)
                {
                    
                    sb.AppendLine(item.Name);
                    sb.AppendLine(item.Width.ToString());
                    sb.AppendLine(item.Height.ToString());
                }
                File.WriteAllText(path, sb.ToString());
            }
            else if (path.EndsWith(".json"))
            {
                Program.boba();
                string text = JsonConvert.SerializeObject(figures);
                File.WriteAllText(path, text);
            }
            else if (path.EndsWith(".xml"))
            {
                Program.boba();
                XmlSerializer xml = new XmlSerializer(typeof(List<figure>));
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    xml.Serialize(fs, figures);
                }
            }
        }

    }
}
