using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class TorgiGovAPI_WebForm : System.Web.UI.Page
{
    /*protected void Page_Load(object sender, EventArgs e)
    {

    }*/

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(bidKind.Value) != 0)
        {
            //String URLString = "http://localhost:50689/books.xml";
        
            //String URLString = "http://localhost:50689/data-" + bidKind.Value + "-" + publishDateFrom.SelectedDate.ToString("yyyyMMddTHHmm") + "-" + publishDateTo.SelectedDate.ToString("yyyyMMddTHHmm") + "-structure-20130401T0000.xml";

            String URLString = "http://torgi.gov.ru/opendata/7710349494-torgi/data-" + bidKind.Value + "-" + publishDateFrom.SelectedDate.ToString("yyyyMMddTHHmm") + "-" + publishDateTo.SelectedDate.ToString("yyyyMMddTHHmm") + "-structure-20130401T0000.xml";
            
            //Response.Write(URLString);
            
            XmlTextReader reader = new XmlTextReader(URLString);

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(URLString);

            XmlElement xRoot = xDoc.DocumentElement;

            Response.Write("<table border='1' width='1250'>");
            Response.Write("<tr><td>Наименование типа выгрузки</td><td>Номер</td><td>Наименовение организации</td><td>Публикация</td><td>Изменен</td><tr>");
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }
                // обходим все дочерние узлы элемента user
                Response.Write("<tr>");
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "bidKindName")
                    {
                        Response.Write("<td>" + childnode.InnerText+"</td>");
                    }
                    if (childnode.Name == "bidNumber")
                    {
                        Response.Write("<td>" + childnode.InnerText + "</td>");
                    }
                    if (childnode.Name == "organizationName")
                    {
                        Response.Write("<td>" + childnode.InnerText + "</td>");
                    }
                    if (childnode.Name == "publishDate")
                    {
                        Response.Write("<td>" + childnode.InnerText + "</td>");
                    }
                    if (childnode.Name == "lastChanged")
                    {
                        Response.Write("<td>" + childnode.InnerText + "</td>");
                    }
                }
                Response.Write("</tr>");
            }
            Response.Write("</table>");

        }
    }
 }