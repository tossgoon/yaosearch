using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
namespace YaoSearch
{
    public partial class FormGenerateXml : Form
    {
        SqlConnection thisConn;
        public FormGenerateXml()
        {
            InitializeComponent();
        }
        public FormGenerateXml(SqlConnection thisConn)
        {
            InitializeComponent();
            this.thisConn = thisConn;
            txtXmlPath.Text= CDBOperate.GetZxXmlPathFromTxt();
            txtComCode.Text = CDBOperate.GetZxXmlComcodeFromTxt();
            txtComName.Text = CDBOperate.GetZxXmlComnameFromTxt();
        }

        private void FormGenerateXml_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ExportXmlIn(txtXmlPath.Text,txtComCode.Text,txtComName.Text,date_k_in.Value);
            ExportXmlOut(txtXmlPath.Text, txtComCode.Text, txtComName.Text, date_k_in.Value);
            ExportXmlInit(txtXmlPath.Text, txtComCode.Text, txtComName.Text, date_k_in.Value);
            MessageBox.Show("ok");
        }

        private void ExportXmlIn(string filePath,string senderId,string senderName,DateTime generateDate)
        {
            CXmlEnv xmlEnv = new CXmlEnv();
            xmlEnv.MESSAGE_TYPE = "in";
            xmlEnv.SENDER_ID = senderId;
            xmlEnv.SENDERNAME = senderName;
            xmlEnv.GENERATE_DATE = generateDate;
            xmlEnv.SOFTTYPE = "1";
            CDBOperate db = new CDBOperate();
            List<CXmlIn> xmlinList = db.GetXmlInsList(thisConn, Convert.ToDateTime(xmlEnv.GENERATE_DATE.ToShortDateString()));
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", "");//xml文档声明部分
            doc.AppendChild(declaration);
            XmlElement root = doc.CreateElement("SIGNATURE", "www.hebfdea.com");
            doc.AppendChild(root);
            XmlElement obj = doc.CreateElement("OBJECT", doc.DocumentElement.NamespaceURI);
            root.AppendChild(obj);
            XmlElement package = doc.CreateElement("PACKAGE", doc.DocumentElement.NamespaceURI);
            obj.AppendChild(package);
            XmlElement env = doc.CreateElement("ENVELOPINFO", doc.DocumentElement.NamespaceURI);
            package.AppendChild(env);

            XmlElement version = doc.CreateElement("VERSION", doc.DocumentElement.NamespaceURI);
            version.InnerText = xmlEnv.VERSION;
            env.AppendChild(version);

            XmlElement messgageid = doc.CreateElement("MESSAGE_ID", doc.DocumentElement.NamespaceURI);
            messgageid.InnerText = xmlEnv.MESSAGE_ID;
            env.AppendChild(messgageid);

            XmlElement filename = doc.CreateElement("FILE_NAME", doc.DocumentElement.NamespaceURI);
            filename.InnerText = xmlEnv.FILE_NAME;
            env.AppendChild(filename);

            XmlElement msgtype = doc.CreateElement("MESSAGE_TYPE", doc.DocumentElement.NamespaceURI);
            msgtype.InnerText = xmlEnv.MESSAGE_TYPE;
            env.AppendChild(msgtype);

            XmlElement SENDER_ID = doc.CreateElement("SENDER_ID", doc.DocumentElement.NamespaceURI);
            SENDER_ID.InnerText = xmlEnv.SENDER_ID;
            env.AppendChild(SENDER_ID);

            XmlElement SEND_TIME = doc.CreateElement("SEND_TIME", doc.DocumentElement.NamespaceURI);
            SEND_TIME.InnerText = xmlEnv.SEND_TIME.ToString("yyyy-MM-dd HH:mm:ss");
            env.AppendChild(SEND_TIME);
            XmlElement RECEIVER_ID = doc.CreateElement("RECEIVER_ID", doc.DocumentElement.NamespaceURI);
            RECEIVER_ID.InnerText = xmlEnv.RECEIVER_ID;
            env.AppendChild(RECEIVER_ID);

            XmlElement SOFTTYPE = doc.CreateElement("SOFTTYPE", doc.DocumentElement.NamespaceURI);
            SOFTTYPE.InnerText = xmlEnv.SOFTTYPE;
            env.AppendChild(SOFTTYPE);

            XmlElement SENDERNAME = doc.CreateElement("SENDERNAME", doc.DocumentElement.NamespaceURI);
            SENDERNAME.InnerText = xmlEnv.SENDERNAME;
            env.AppendChild(SENDERNAME);

            //添加数据
            XmlElement datainfo = doc.CreateElement("DATAINFO", doc.DocumentElement.NamespaceURI);
            package.AppendChild(datainfo);
            foreach (CXmlIn xin in xmlinList)
            {
                XmlElement rowinfo = doc.CreateElement("ROWINFO", doc.DocumentElement.NamespaceURI);
                datainfo.AppendChild(rowinfo);
                XmlElement i_item_code = doc.CreateElement("I_ITEM_CODE", doc.DocumentElement.NamespaceURI);
                i_item_code.InnerText = xin.I_ITEM_CODE;
                rowinfo.AppendChild(i_item_code);

                XmlElement YPPH = doc.CreateElement("YPPH", doc.DocumentElement.NamespaceURI);
                YPPH.InnerText = xin.YPPH;
                rowinfo.AppendChild(YPPH);

                XmlElement VDATE = doc.CreateElement("VDATE", doc.DocumentElement.NamespaceURI);
                VDATE.InnerText = xin.VDATE;
                rowinfo.AppendChild(VDATE);

                XmlElement PACKAGE = doc.CreateElement("PACKAGE", doc.DocumentElement.NamespaceURI);
                PACKAGE.InnerText = xin.PACKAGE;
                rowinfo.AppendChild(PACKAGE);

                XmlElement UNIT = doc.CreateElement("UNIT", doc.DocumentElement.NamespaceURI);
                UNIT.InnerText = xin.UNIT;
                rowinfo.AppendChild(UNIT);

                XmlElement NUM = doc.CreateElement("NUM", doc.DocumentElement.NamespaceURI);
                NUM.InnerText = xin.NUM.ToString();
                rowinfo.AppendChild(NUM);

                XmlElement JZ_DATE = doc.CreateElement("JZ_DATE", doc.DocumentElement.NamespaceURI);
                JZ_DATE.InnerText = xin.JZ_DATE.ToString("yyyy-MM-dd HH:mm:ss");
                rowinfo.AppendChild(JZ_DATE);

                XmlElement FPH = doc.CreateElement("FPH", doc.DocumentElement.NamespaceURI);
                FPH.InnerText = xin.FPH;
                rowinfo.AppendChild(FPH);

                XmlElement I_MER_CODE = doc.CreateElement("I_MER_CODE", doc.DocumentElement.NamespaceURI);
                I_MER_CODE.InnerText = xin.I_MER_CODE;
                rowinfo.AppendChild(I_MER_CODE);

                XmlElement MER_NAME = doc.CreateElement("MER_NAME", doc.DocumentElement.NamespaceURI);
                MER_NAME.InnerText = xin.MER_NAME;
                rowinfo.AppendChild(MER_NAME);

                XmlElement MERA_CODE = doc.CreateElement("MERA_CODE", doc.DocumentElement.NamespaceURI);
                MERA_CODE.InnerText = xin.MERA_CODE;
                rowinfo.AppendChild(MERA_CODE);

                XmlElement BILL_TYPE = doc.CreateElement("BILL_TYPE", doc.DocumentElement.NamespaceURI);
                BILL_TYPE.InnerText = xin.BILL_TYPE;
                rowinfo.AppendChild(BILL_TYPE);
            }
            doc.Save(filePath + "\\" + xmlEnv.FILE_NAME);
        }
        private void ExportXmlOut(string filePath, string senderId, string senderName, DateTime generateDate)
        {
            CXmlEnv xmlEnv = new CXmlEnv();
            xmlEnv.MESSAGE_TYPE = "out";
            xmlEnv.SENDER_ID = senderId;
            xmlEnv.SENDERNAME = senderName;
            xmlEnv.GENERATE_DATE = generateDate;
            xmlEnv.SOFTTYPE = "1";
            
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", "");//xml文档声明部分
            doc.AppendChild(declaration);
            XmlElement root = doc.CreateElement("SIGNATURE", "www.hebfdea.com");
            doc.AppendChild(root);
            XmlElement obj = doc.CreateElement("OBJECT", doc.DocumentElement.NamespaceURI);
            root.AppendChild(obj);
            XmlElement package = doc.CreateElement("PACKAGE", doc.DocumentElement.NamespaceURI);
            obj.AppendChild(package);
            XmlElement env = doc.CreateElement("ENVELOPINFO", doc.DocumentElement.NamespaceURI);
            package.AppendChild(env);

            XmlElement version = doc.CreateElement("VERSION", doc.DocumentElement.NamespaceURI);
            version.InnerText = xmlEnv.VERSION;
            env.AppendChild(version);

            XmlElement messgageid = doc.CreateElement("MESSAGE_ID", doc.DocumentElement.NamespaceURI);
            messgageid.InnerText = xmlEnv.MESSAGE_ID;
            env.AppendChild(messgageid);

            XmlElement filename = doc.CreateElement("FILE_NAME", doc.DocumentElement.NamespaceURI);
            filename.InnerText = xmlEnv.FILE_NAME;
            env.AppendChild(filename);

            XmlElement msgtype = doc.CreateElement("MESSAGE_TYPE", doc.DocumentElement.NamespaceURI);
            msgtype.InnerText = xmlEnv.MESSAGE_TYPE;
            env.AppendChild(msgtype);

            XmlElement SENDER_ID = doc.CreateElement("SENDER_ID", doc.DocumentElement.NamespaceURI);
            SENDER_ID.InnerText = xmlEnv.SENDER_ID;
            env.AppendChild(SENDER_ID);

            XmlElement SEND_TIME = doc.CreateElement("SEND_TIME", doc.DocumentElement.NamespaceURI);
            SEND_TIME.InnerText = xmlEnv.SEND_TIME.ToString("yyyy-MM-dd HH:mm:ss");
            env.AppendChild(SEND_TIME);
            XmlElement RECEIVER_ID = doc.CreateElement("RECEIVER_ID", doc.DocumentElement.NamespaceURI);
            RECEIVER_ID.InnerText = xmlEnv.RECEIVER_ID;
            env.AppendChild(RECEIVER_ID);

            XmlElement SOFTTYPE = doc.CreateElement("SOFTTYPE", doc.DocumentElement.NamespaceURI);
            SOFTTYPE.InnerText = xmlEnv.SOFTTYPE;
            env.AppendChild(SOFTTYPE);

            XmlElement SENDERNAME = doc.CreateElement("SENDERNAME", doc.DocumentElement.NamespaceURI);
            SENDERNAME.InnerText = xmlEnv.SENDERNAME;
            env.AppendChild(SENDERNAME);

            //添加数据
            XmlElement datainfo = doc.CreateElement("DATAINFO", doc.DocumentElement.NamespaceURI);
            package.AppendChild(datainfo);
            CDBOperate db = new CDBOperate();
            List<CXmlOut> xmlOutList = db.GetXmlOutsList(thisConn, Convert.ToDateTime(xmlEnv.GENERATE_DATE.ToShortDateString()));
            foreach (CXmlOut xout in xmlOutList)
            {
                XmlElement rowinfo = doc.CreateElement("ROWINFO", doc.DocumentElement.NamespaceURI);
                datainfo.AppendChild(rowinfo);
                XmlElement i_item_code = doc.CreateElement("I_ITEM_CODE", doc.DocumentElement.NamespaceURI);
                i_item_code.InnerText = xout.I_ITEM_CODE;
                rowinfo.AppendChild(i_item_code);

                XmlElement YPPH = doc.CreateElement("YPPH", doc.DocumentElement.NamespaceURI);
                YPPH.InnerText = xout.YPPH;
                rowinfo.AppendChild(YPPH);

                XmlElement VDATE = doc.CreateElement("VDATE", doc.DocumentElement.NamespaceURI);
                VDATE.InnerText = xout.VDATE;
                rowinfo.AppendChild(VDATE);

                XmlElement PACKAGE = doc.CreateElement("PACKAGE", doc.DocumentElement.NamespaceURI);
                PACKAGE.InnerText = xout.PACKAGE;
                rowinfo.AppendChild(PACKAGE);

                XmlElement UNIT = doc.CreateElement("UNIT", doc.DocumentElement.NamespaceURI);
                UNIT.InnerText = xout.UNIT;
                rowinfo.AppendChild(UNIT);

                XmlElement NUM = doc.CreateElement("NUM", doc.DocumentElement.NamespaceURI);
                NUM.InnerText = xout.NUM.ToString();
                rowinfo.AppendChild(NUM);

                XmlElement JZ_DATE = doc.CreateElement("JZ_DATE", doc.DocumentElement.NamespaceURI);
                JZ_DATE.InnerText = xout.JZ_DATE.ToString("yyyy-MM-dd HH:mm:ss");
                rowinfo.AppendChild(JZ_DATE);

                XmlElement FPH = doc.CreateElement("FPH", doc.DocumentElement.NamespaceURI);
                FPH.InnerText = xout.FPH;
                rowinfo.AppendChild(FPH);

                XmlElement I_MER_CODE = doc.CreateElement("I_MER_CODE", doc.DocumentElement.NamespaceURI);
                I_MER_CODE.InnerText = xout.I_MER_CODE;
                rowinfo.AppendChild(I_MER_CODE);

                XmlElement MER_NAME = doc.CreateElement("MER_NAME", doc.DocumentElement.NamespaceURI);
                MER_NAME.InnerText = xout.MER_NAME;
                rowinfo.AppendChild(MER_NAME);

                XmlElement MERA_CODE = doc.CreateElement("MERA_CODE", doc.DocumentElement.NamespaceURI);
                MERA_CODE.InnerText = xout.MERA_CODE;
                rowinfo.AppendChild(MERA_CODE);

                XmlElement BILL_TYPE = doc.CreateElement("BILL_TYPE", doc.DocumentElement.NamespaceURI);
                BILL_TYPE.InnerText = xout.BILL_TYPE;
                rowinfo.AppendChild(BILL_TYPE);
            }
            doc.Save(filePath + "\\" + xmlEnv.FILE_NAME);
        }

        private void ExportXmlInit(string filePath, string senderId, string senderName, DateTime generateDate)
        {
            CXmlEnv xmlEnv = new CXmlEnv();
            xmlEnv.MESSAGE_TYPE = "init";
            xmlEnv.SENDER_ID = senderId;
            xmlEnv.SENDERNAME = senderName;
            xmlEnv.GENERATE_DATE = generateDate;
            xmlEnv.SOFTTYPE = "1";

            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", "");//xml文档声明部分
            doc.AppendChild(declaration);
            XmlElement root = doc.CreateElement("SIGNATURE", "www.hebfdea.com");
            doc.AppendChild(root);
            XmlElement obj = doc.CreateElement("OBJECT", doc.DocumentElement.NamespaceURI);
            root.AppendChild(obj);
            XmlElement package = doc.CreateElement("PACKAGE", doc.DocumentElement.NamespaceURI);
            obj.AppendChild(package);
            XmlElement env = doc.CreateElement("ENVELOPINFO", doc.DocumentElement.NamespaceURI);
            package.AppendChild(env);

            XmlElement version = doc.CreateElement("VERSION", doc.DocumentElement.NamespaceURI);
            version.InnerText = xmlEnv.VERSION;
            env.AppendChild(version);

            XmlElement messgageid = doc.CreateElement("MESSAGE_ID", doc.DocumentElement.NamespaceURI);
            messgageid.InnerText = xmlEnv.MESSAGE_ID;
            env.AppendChild(messgageid);

            XmlElement filename = doc.CreateElement("FILE_NAME", doc.DocumentElement.NamespaceURI);
            filename.InnerText = xmlEnv.FILE_NAME;
            env.AppendChild(filename);

            XmlElement msgtype = doc.CreateElement("MESSAGE_TYPE", doc.DocumentElement.NamespaceURI);
            msgtype.InnerText = xmlEnv.MESSAGE_TYPE;
            env.AppendChild(msgtype);

            XmlElement SENDER_ID = doc.CreateElement("SENDER_ID", doc.DocumentElement.NamespaceURI);
            SENDER_ID.InnerText = xmlEnv.SENDER_ID;
            env.AppendChild(SENDER_ID);

            XmlElement SEND_TIME = doc.CreateElement("SEND_TIME", doc.DocumentElement.NamespaceURI);
            SEND_TIME.InnerText = xmlEnv.SEND_TIME.ToString("yyyy-MM-dd HH:mm:ss");
            env.AppendChild(SEND_TIME);
            XmlElement RECEIVER_ID = doc.CreateElement("RECEIVER_ID", doc.DocumentElement.NamespaceURI);
            RECEIVER_ID.InnerText = xmlEnv.RECEIVER_ID;
            env.AppendChild(RECEIVER_ID);

            XmlElement SOFTTYPE = doc.CreateElement("SOFTTYPE", doc.DocumentElement.NamespaceURI);
            SOFTTYPE.InnerText = xmlEnv.SOFTTYPE;
            env.AppendChild(SOFTTYPE);

            XmlElement SENDERNAME = doc.CreateElement("SENDERNAME", doc.DocumentElement.NamespaceURI);
            SENDERNAME.InnerText = xmlEnv.SENDERNAME;
            env.AppendChild(SENDERNAME);

            //添加数据
            XmlElement datainfo = doc.CreateElement("DATAINFO", doc.DocumentElement.NamespaceURI);
            package.AppendChild(datainfo);
            CDBOperate db = new CDBOperate();
            List<CXmlInit> xmlInitList = db.GetXmlInitsList(thisConn, Convert.ToDateTime(xmlEnv.GENERATE_DATE.ToShortDateString()));
            foreach (CXmlInit xinit in xmlInitList)
            {
                XmlElement rowinfo = doc.CreateElement("ROWINFO", doc.DocumentElement.NamespaceURI);
                datainfo.AppendChild(rowinfo);
                XmlElement i_item_code = doc.CreateElement("I_ITEM_CODE", doc.DocumentElement.NamespaceURI);
                i_item_code.InnerText = xinit.I_ITEM_CODE;
                rowinfo.AppendChild(i_item_code);

                XmlElement BARCODE = doc.CreateElement("BARCODE", doc.DocumentElement.NamespaceURI);
                BARCODE.InnerText = xinit.BARCODE;
                rowinfo.AppendChild(BARCODE);

                XmlElement YPPH = doc.CreateElement("YPPH", doc.DocumentElement.NamespaceURI);
                YPPH.InnerText = xinit.YPPH;
                rowinfo.AppendChild(YPPH);

                XmlElement VDATE = doc.CreateElement("VDATE", doc.DocumentElement.NamespaceURI);
                VDATE.InnerText = xinit.VDATE;
                rowinfo.AppendChild(VDATE);

                XmlElement PACKAGE = doc.CreateElement("PACKAGE", doc.DocumentElement.NamespaceURI);
                PACKAGE.InnerText = xinit.PACKAGE;
                rowinfo.AppendChild(PACKAGE);

                XmlElement UNIT = doc.CreateElement("UNIT", doc.DocumentElement.NamespaceURI);
                UNIT.InnerText = xinit.UNIT;
                rowinfo.AppendChild(UNIT);

                XmlElement NUM = doc.CreateElement("NUM", doc.DocumentElement.NamespaceURI);
                NUM.InnerText = xinit.NUM.ToString();
                rowinfo.AppendChild(NUM);

                XmlElement JZ_DATE = doc.CreateElement("JZ_DATE", doc.DocumentElement.NamespaceURI);
                JZ_DATE.InnerText = xinit.JZ_DATE.ToString("yyyy-MM-dd HH:mm:ss");
                rowinfo.AppendChild(JZ_DATE);
            }
            doc.Save(filePath + "\\" + xmlEnv.FILE_NAME);
        }
    }
}
