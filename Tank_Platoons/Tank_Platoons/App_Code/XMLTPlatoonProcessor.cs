using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Schema;
using Tank_Platoons.App_Code;

namespace Tank_Platoons.App_Code
{
    public class XMLTPlatoonProcessor
    {
        private Tank_Platoons tank_platoon;
        private XmlDocument xml = new XmlDocument();
        private XmlNode node;
        private string path;

        private string _GetNodeValue(XmlNode fromNode, string xPath)
        {
            return fromNode.SelectSingleNode(xPath).InnerText;
        }

        private string _GetAttributeValue(XmlNode fromNode, string xPath, string attribute)
        {
            return fromNode.SelectSingleNode(xPath).Attributes[attribute].Value;
        }

        private void _LoadXML(string path)
        {
            this.xml.Load(path);
        }

        private void _InitTankPlatoon()
        {
            node = xml.SelectSingleNode(TankPlatoonElements.ROOT_ELEMENT_XPATH);
            string id = node.Attributes[TankPlatoonElements.TPLATOON_ID].Value;
            this.tank_platoon = new Tank_Platoons();
            tank_platoon.id = id;
        }

    }
}