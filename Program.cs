using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace xmlDemo
{
    class Program
    {
        static void Main()
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf=8", "yes"),
                new XComment("Creating an XML Tree using LINQ to XML"),
                new XElement("SteelMembers",

                from steelmembers in SteelMember.GetSteelMembers()
                select new XElement("SteelMember", new XAttribute("Id", steelmembers.Id),
                new XElement("Profile", steelmembers.Profile),
                new XElement("Primer", steelmembers.Primer),
                new XElement("Length", steelmembers.Length))));
                

            xmlDocument.Save(@"C:\Users\brung\Desktop\Programming\Software Development\C#\C#\Linq XML\linqBeam\linqBeam\Steel.xml");
        }
    }
}
