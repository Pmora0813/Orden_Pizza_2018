using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace Orden_Pizza
{
    class Orden_Compra
    {
        public int Cantidad { get; set; }
        public Pizza Pizza { get; set; }
        public Pasta Pasta { get; set; }
        public ITamano Tamano { get; set; }
        List<Extra> ListaExtras { get; set; }


        public Orden_Compra(int cantidad, Pizza pizza, Pasta pasta, ITamano tamano)
        {
            this.Cantidad = cantidad;
            this.Pizza = pizza;
            this.Pasta = pasta;
            this.Tamano = tamano;
            this.ListaExtras = new List<Extra>();
        }

        public int costoExtras()
        {
            int total = 0;
            foreach (Extra ext in ListaExtras)
            {
                total += Convert.ToInt32(ext);
            }

            return total;
        }

        public double CalcularTotal()
        {
            double total = 0;
            total = ((Pizza.costo() + Convert.ToDouble(Pasta)) * Tamano.Costo) + costoExtras();

            return total;
        }

        public void AddExtras(Extra ext)
        {
            this.ListaExtras.Add(ext);
        }

        public void guardar(String ruta)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml("<ORDEN></ORDEN>");

            XmlElement nPIZZA = xmlDoc.CreateElement("PIZZA");


            XmlElement nCANTIDAD = xmlDoc.CreateElement("CANTIDAD");
            nCANTIDAD.InnerText = this.Cantidad.ToString();

            XmlElement nTIPO = xmlDoc.CreateElement("TIPO");
            nTIPO.InnerText = this.Pizza.nombre.ToString();

            XmlElement nPASTA = xmlDoc.CreateElement("PASTA");
            nPASTA.InnerText = this.Pasta.ToString();

            XmlElement nTAMANNO = xmlDoc.CreateElement("TAMANO");
            nTAMANNO.InnerText = this.Tamano.Nombre.ToString();

            XmlElement nADICIONALES = xmlDoc.CreateElement("ADICIONALES");

            foreach (Extra ad in this.ListaExtras)
            {
                int costo = (int) ad;
                XmlElement nNombre = xmlDoc.CreateElement("EXTRA");
                nNombre.SetAttribute("NOMBRE",ad.ToString());
                nNombre.SetAttribute("COSTO", costo.ToString());           
                     
                nADICIONALES.AppendChild(nNombre);
               
            }
            

            XmlElement nTOTAL = xmlDoc.CreateElement("TOTAL");
            nTOTAL.InnerText = CalcularTotal().ToString("#,##0.00");
            nPIZZA.AppendChild(nTOTAL);

            nPIZZA.AppendChild(nCANTIDAD);
            nPIZZA.AppendChild(nTIPO);
            nPIZZA.AppendChild(nPASTA);
            nPIZZA.AppendChild(nTAMANNO);
            nPIZZA.AppendChild(nADICIONALES);

            xmlDoc.DocumentElement.AppendChild(nPIZZA);
            xmlDoc.Save(ruta);
        }


        public void trasformarXMLaHTMl()
        {
            // Transformación del XMl utilizando XSLT
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            // Carga en memoria la lectura xslt
            myXslTrans.Load("D:\\Llave _16_GB\\I Cuatrimestre\\Progra III\\Semana 4\\Viernes\\OrdenPizza.xslt");
            // Transforma el archivo xml aun archivo HTML
            string rutaXML = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Orden_Pizza.xml";

            string rutaHTML = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Orden_Pizza.html";

            myXslTrans.Transform(rutaXML, rutaHTML);

            System.Diagnostics.Process proceso = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.Arguments = rutaHTML;
            info.FileName = "chrome.exe";
            proceso.StartInfo = info;
            proceso.Start();




        }
    }


}
