using BE_Propiedades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BLL_Negocio
{
    public class XML
    {
        public string documents = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public List<Clase> Read()
        {
            string path = documents + @"\UAI\LUG-P2\Documents\file.xml";

            var query = from Clase in XElement.Load(path).Elements("Clases")
                        select new Clase
                        {
                            Descripcion = Convert.ToString(Clase.Attribute("Actividad").Value).Trim(),

                            profe = Int32.Parse((Clase.Attribute("Calidad").Value).Trim()),

                            Dia = Convert.ToString(Clase.Attribute("Nombre").Value).Trim(),

                            Turno = Convert.ToString(Clase.Attribute("Minutos").Value).Trim()
                        };

            List<Clase> Lista = query.ToList<Clase>();
            return Lista;

        }

        public void Write(string Clase, string Profesor, string Dia, string Turno)
        {
            string path = documents + @"\UAI\LUG-P2\Documents\file.xml";
            XDocument doc = XDocument.Load(path);

            doc.Element("Clases").Add(new XElement("Clase",
                new XAttribute("Actividad", Clase),
                new XElement("Profesor", Profesor),
                new XElement("Dia", Dia),
                new XElement("Turno", Turno)
                ));

            doc.Save(path);
        }

        public void Create(string Clase, string Profesor, string Dia, string Turno)
        {
            string path = documents + @"\UAI\LUG-P2\Documents\file.xml";

            var file = new XmlTextWriter(path, System.Text.Encoding.UTF8);
            file.Formatting = Formatting.Indented;

            file.Indentation = 2;
            file.WriteStartDocument();

            file.WriteStartElement("Clases");

            file.WriteElementString("Clase", "Clase");
            file.WriteAttributeString("Actividad", Clase);
            //El token StartAttribute en el estado Content daría lugar a un documento XML no válido.

            file.WriteElementString("Profesor", Profesor);
            file.WriteElementString("Dia", Dia);
            file.WriteElementString("Turno", Turno);
            
            file.WriteEndElement();
            file.WriteEndDocument();

            file.Close();
        }
    }
}

