using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Data;
using System.IO;
using log4net;
using System.Windows.Forms;
using Fx678Member.Framework.Log;
namespace Nui.MallInfo.Utility
{
    public class AutoMainXml
    {

        /// <summary>
        /// 默认主题
        /// </summary>
        [XmlElement]
        public string NSkinForm { get; set; }

        /// <summary>
        /// 默认Form主题
        /// </summary>
        [XmlElement]
        public string NSkinResource { get; set; }

        /// <summary>
        /// 默认主题名称
        /// </summary>
        [XmlElement]
        public string NSkinName { get; set; }

        /// <summary>
        /// 默认Form主题名称
        /// </summary>
        [XmlElement]
        public string NSkinFormName { get; set; }

        [XmlIgnore]
        public static AutoMainXml StaticAutoXml { get; private set; }

        /// <summary>
        /// 生成XML并保存
        /// </summary>
        /// <param name="node"></param>
        /// <param name="path"></param>
        public static void SaveXml(AutoMainXml node, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AutoMainXml));
            //serializer.Serialize(new System.IO.StreamWriter(Application.StartupPath.Replace("\\bin\\Debug", "") + "\\config\\" + path), node);
            serializer.Serialize(new System.IO.StreamWriter("Config\\" + path), node);
        }

        /// <summary>
        /// 反序列化读取
        /// </summary>
        /// <param name="path"></param>
        public static void DeserializeXml(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AutoMainXml));
            //System.IO.StreamReader strread = new System.IO.StreamReader(Application.StartupPath.Replace("\\bin\\Debug", "") + "\\config\\" + path);
            System.IO.StreamReader strread = new System.IO.StreamReader("Config\\" + path);
            StaticAutoXml = serializer.Deserialize(strread) as AutoMainXml;
            strread.Close();
        }


        /// <summary>
        /// 修改指定节点XML值
        /// </summary>
        /// <param name="xElement">xml元素节点</param>
        /// <param name="AppValue1">指定节点的内容值</param>
        public static void SetValue(string xElement, string AppValue1)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                //获取可执行文件的路径和名称 
                xDoc.Load("Config\\AutoMainXml.xml");

                XmlElement element = (XmlElement)xDoc.SelectSingleNode("AutoMainXml/" + xElement + "");
                element.InnerText = AppValue1;
                xDoc.Save("Config\\AutoMainXml.xml");
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }

        }


        /// <summary>
        /// 新增指定节点下子节点
        /// </summary>
        /// <param name="xmlPath">xml指定路径</param>
        /// <param name="ElementName">节点</param>
        public static bool AddCreate(string xElement, string server, string InnerText, string providerName)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Config\\AutoMainXml.xml");

                //var root = xmlDoc.DocumentElement;//取到根结点
                var root = xmlDoc.SelectSingleNode("//" + xElement + "");//取得指定节点
                XmlElement newNode = (XmlElement)xmlDoc.CreateNode("element", "ConTion", "");
                newNode.InnerText = InnerText;
                newNode.SetAttribute("Name", server);
                newNode.SetAttribute("Start", "True");
                newNode.SetAttribute("providerName", providerName);
                //添加为指定元素的第一层子结点
                root.AppendChild(newNode);

                XmlNode element2 = xmlDoc.SelectSingleNode("//" + xElement + "");
                element2.Attributes["default"].Value = server;

                xmlDoc.Save("Config\\AutoMainXml.xml");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }

        }

        /// <summary>
        /// 修改xml属性
        /// </summary>
        /// <param name="xElement"></param>
        /// <returns></returns>
        public static bool UpdateAtrribute(string xElement)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Config\\AutoMainXml.xml");

                XmlNodeList nodes = xmlDoc.SelectNodes("//" + xElement + "//ConTion");
                foreach (XmlNode node in nodes)
                {
                    node.Attributes["Start"].Value = "False";
                }

                xmlDoc.Save("Config\\AutoMainXml.xml");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
        }


        /// <summary>
        /// 修改指定节点XML值
        /// </summary>
        /// <param name="xElement">xml元素节点</param>
        /// <param name="AppValue1">指定节点的内容值</param>
        public static bool UpdateSetValue(string proName, string Name, string AppValue1, string str_default)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                //获取可执行文件的路径和名称 
                xDoc.Load("Config\\AutoMainXml.xml");
                //根据指定AppID属性获取该应用的LoadUrl，请留意这种筛选写法  
                XmlNode element = xDoc.SelectSingleNode("//SqlMap//ConTion[@Name='" + Name + "'][@providerName='" + proName + "']");

                string providerName = element.Attributes["providerName"].Value;
                if (providerName.Equals(proName))
                {
                    element.Attributes["Start"].Value = "True";
                    element.InnerText = AppValue1;

                    XmlNode element2 = xDoc.SelectSingleNode("//SqlMap");
                    element2.Attributes["default"].Value = str_default;
                }

                xDoc.Save("Config\\AutoMainXml.xml");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }

        }

        /// <summary>
        /// 修改指定节点指定属性的属性
        /// </summary>
        /// <param name="xElement"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static bool UpdateSetAttr(string proName, string Name)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                //获取可执行文件的路径和名称 
                xDoc.Load("Config\\AutoMainXml.xml");

                //根据指定AppID属性获取该应用的LoadUrl，请留意这种筛选写法  
                XmlNode element = xDoc.SelectSingleNode("//ConTion[@Name='" + Name + "'][@providerName='" + proName + "']");
                string providerName = element.Attributes["providerName"].Value;
                if (proName.Equals(providerName))
                {
                    element.Attributes["Start"].Value = "True";

                    XmlNode element2 = xDoc.SelectSingleNode("//SqlMap");
                    element2.Attributes["default"].Value = Name;
                }

                xDoc.Save("Config\\AutoMainXml.xml");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }

        }

        /// <summary>
        /// 删除指定节点XML值
        /// </summary>
        /// <param name="xElement">xml元素节点</param>
        /// <param name="AppValue1">指定节点的内容值</param>
        public static bool DelSetValue(string proName, string Name, string AppValue1)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                //获取可执行文件的路径和名称 
                xDoc.Load("Config\\AutoMainXml.xml");
                //根据指定AppID属性获取该应用的LoadUrl，请留意这种筛选写法  
                XmlNode element = xDoc.SelectSingleNode("//ConTion[@Name='" + Name + "'][@providerName='" + proName + "']");

                string providerName = element.Attributes["providerName"].Value;
                if (proName.Equals(providerName))
                {
                    element.ParentNode.RemoveChild(element);
                }

                xDoc.Save("Config\\AutoMainXml.xml");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);

                return false;
            }

        }

        /// <summary>
        /// 获取所有的属性
        /// </summary>
        /// <param name="xmlPath"></param>
        public static DataTable SelectAttribute(string xElement)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();

                xmlDoc.Load("Config\\AutoMainXml.xml");
                DataTable dt = new DataTable();
                dt.Columns.Add("ServerName", typeof(string));
                dt.Columns.Add("providerName", typeof(string));
                dt.Columns.Add("Start", typeof(string));

                //XmlNodeList NodeList = xmlDoc.SelectNodes("//ConTion[@providerName='" + xElement + "']");
                XmlNodeList NodeList = xmlDoc.SelectNodes("//SqlMap//ConTion");
                if (NodeList != null)
                {
                    foreach (XmlNode NodeAttr in NodeList)
                    {
                        //通过Attributes获得属性名为name的属性
                        string Name = NodeAttr.Attributes["Name"].Value;
                        string proName = NodeAttr.Attributes["providerName"].Value == "System.Data.SqlClient" ? "SQLServer" : "Oracle";
                        string Starts = NodeAttr.Attributes["Start"].Value;
                        DataRow dr = dt.NewRow();
                        dr["ServerName"] = Name;
                        dr["providerName"] = proName;
                        dr["Start"] = Starts;
                        dt.Rows.Add(dr);

                    }
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return null;
            }


        }




        /// <summary>
        /// 判断该数据源是否已存在
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <param name="Attr"></param>
        /// <returns></returns>
        public static bool SelectAttribute(string proName, string Attr)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                xmlDoc.Load("Config\\AutoMainXml.xml");
                XmlNodeList NodeList = xmlDoc.SelectNodes("//SqlMap//ConTion");
                if (NodeList != null)
                {
                    foreach (XmlNode NodeAttr in NodeList)
                    {
                        //通过Attributes获得属性名为name的属性
                        string Name = NodeAttr.Attributes["Name"].Value;
                        string providerName = NodeAttr.Attributes["providerName"].Value;
                        if (Name.Equals(Attr) && providerName.Equals(proName))
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }


            return false;
        }



        /// <summary>
        /// 获取所有的数据源
        /// </summary>
        /// <param name="xmlPath"></param>
        public static DataTable GetAll(string xElement, string ServerName)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                xmlDoc.Load("Config\\AutoMainXml.xml");
                DataTable dt = new DataTable();
                dt.Columns.Add("ServerName", typeof(string));
                dt.Columns.Add("DBTYPE", typeof(string));
                dt.Columns.Add("DBCONNECTIONSTRING", typeof(string));
                dt.Columns.Add("START", typeof(string));

                string strXml = string.Empty;
                string strServer = string.Empty;
                if (xElement == "")
                {
                    strXml = "ConTion";
                }
                else
                {
                    strXml = "ConTion[@providerName='" + xElement + "']";
                }

                //if (Server!="")
                //{
                //    strServer = "//SqlMap//ConTion[@Name='" + Server + "']";
                //}

                XmlNodeList NodeList = null;

                if (ServerName != "")
                {
                    //根据指定AppID属性获取该应用的LoadUrl，请留意这种筛选写法  
                    XmlNode element = xmlDoc.SelectSingleNode("//" + strXml + "[@Name='" + ServerName + "']");

                    //通过Attributes获得属性名为name的属性
                    string providerName = element.Attributes["providerName"].Value;
                    string Start = element.Attributes["Start"].Value;
                    string Value = element.InnerText;
                    string Name = element.Attributes["Name"].Value;
                    DataRow dr = dt.NewRow();
                    dr["DBTYPE"] = providerName;
                    dr["DBCONNECTIONSTRING"] = Value;
                    dr["START"] = Start;
                    dr["ServerName"] = Name;
                    dt.Rows.Add(dr);
                    return dt;
                }
                else
                {
                    NodeList = xmlDoc.SelectNodes("//" + strXml + "");
                    if (NodeList != null)
                    {
                        foreach (XmlNode NodeAttr in NodeList)
                        {
                            //通过Attributes获得属性名为name的属性
                            string providerName = NodeAttr.Attributes["providerName"].Value;
                            string Start = NodeAttr.Attributes["Start"].Value;
                            string Value = NodeAttr.InnerText;
                            string Name = NodeAttr.Attributes["Name"].Value;
                            DataRow dr = dt.NewRow();
                            dr["DBTYPE"] = providerName;
                            dr["DBCONNECTIONSTRING"] = Value;
                            dr["START"] = Start;
                            dr["ServerName"] = Name;
                            dt.Rows.Add(dr);
                        }
                        return dt;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return null;
            }


        }


        /// <summary>
        /// 加载value
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static string SelectEleValue(string Name, string proName)
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load("Config\\AutoMainXml.xml");
            //根据指定AppID属性获取该应用的LoadUrl，请留意这种筛选写法  
            XmlNode xnP = xmlDoc.SelectSingleNode("//SqlMap//ConTion[@Name='" + Name + "'][@providerName='" + proName + "']");
            if (xnP == null)
                return "";
            else
                return xnP.InnerText;
        }

        /// <summary>
        /// 加载value
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static string SelectEleValue(string Name)
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load("Config\\AutoMainXml.xml");
            //根据指定AppID属性获取该应用的LoadUrl，请留意这种筛选写法  
            XmlNode xnP = xmlDoc.SelectSingleNode("//SqlMap//ConTion[@Name='" + Name + "']");

            return xnP.InnerText;
        }


        /// <summary>
        /// 获取指定属性的值
        /// </summary>
        /// <param name="xElement">元素节点</param>
        /// <param name="eleName">属性名称</param>
        /// <returns></returns>
        public static string SelectAttributeValue(string xElement, string eleName)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();

                xmlDoc.Load("Config\\AutoMainXml.xml");
                XmlNodeList NodeList = xmlDoc.SelectNodes("//" + xElement + "");
                if (NodeList != null)
                {
                    string Name = string.Empty;
                    foreach (XmlNode NodeAttr in NodeList)
                    {
                        //通过Attributes获得属性名为name的属性
                        Name = NodeAttr.Attributes[eleName].Value;
                    }
                    return Name;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return string.Empty;
            }
        }

        /// <summary>
        /// 加载指定节点属性的属性value
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static string SelectEleAttrValue(string Name)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Config\\AutoMainXml.xml");
                //根据指定AppID属性获取该应用的LoadUrl，请留意这种筛选写法  
                XmlNode xnP = xmlDoc.SelectSingleNode("//SqlMap//ConTion[@Name='" + Name + "'][@Start='True']");

                Name = xnP.Attributes["providerName"].Value;
                return Name;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return "";
            }

        }

    }
}
