using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Xml;
using System.IO;

public class xmltesting : MonoBehaviour
{
    public TextAsset xmlRawFile;
    
    //first popup text - story
    public TextMeshProUGUI uiText;

    //second popup text - controls
    public TextMeshProUGUI uiText2;

    //notif text - notification
    public TextMeshProUGUI uiText3;

    void Start()
    {
        string data = xmlRawFile.text;
        parseXmlFile (data);
    }

    void parseXmlFile(string xmlData)
    {
        string totVal = "";
        string totVal2 = "";
        string totVal3 = "";
        // add more string totalval and rename accordingly if you want more

        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load ( new StringReader(xmlData));

        string xmlPathPattern = "//aarlangdi/aarstaff";
        XmlNodeList myNodeList = xmlDoc.SelectNodes (xmlPathPattern);
        foreach(XmlNode node in myNodeList)
        {
            XmlNode tutorial1 = node.FirstChild;
            XmlNode tutorial2 = tutorial1.NextSibling;
            XmlNode tutorial3 = tutorial2.NextSibling;

            totVal = tutorial1.InnerXml;
            totVal2 = tutorial2.InnerXml;
            totVal3 = tutorial3.InnerXml;
            // add more string totalval and rename accordingly if you want more

            uiText.text = totVal;
            uiText2.text = totVal2;
            uiText3.text = totVal3;
            // set uitext to totalvalue and rename accordingly if you want more
        }
    }
}
