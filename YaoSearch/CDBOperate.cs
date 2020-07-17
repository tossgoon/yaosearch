using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;
namespace YaoSearch
{
    class CDBOperate
    {
        /// <summary>
        /// 从根目录\data\setting.txt中读取密码
        /// </summary>
        /// <returns></returns>
        public static string GetDBConnectFromTxt()
        {
            string txtFilePath = System.Windows.Forms.Application.StartupPath + "\\setting.ini";
            string connstr = "";
            if (File.Exists(txtFilePath))
            {
                CIniFile myFile = new CIniFile(txtFilePath);
                connstr = myFile.IniReadValue("Setting", "DataBase");
            }
            return connstr;
        }
        //远程数据库连接字符串
        public static string GetRemoteDBConnectFromTxt()
        {
            string txtFilePath = System.Windows.Forms.Application.StartupPath + "\\setting.ini";
            string connstr = "";
            if (File.Exists(txtFilePath))
            {
                CIniFile myFile = new CIniFile(txtFilePath);
                connstr = myFile.IniReadValue("Setting", "RemoteDataBase");
            }
            return connstr;
        }
        //获取xml文件路径
        public static string GetZxXmlPathFromTxt()
        {
            string txtFilePath = System.Windows.Forms.Application.StartupPath + "\\setting.ini";
            string connstr = "";
            if (File.Exists(txtFilePath))
            {
                CIniFile myFile = new CIniFile(txtFilePath);
                connstr = myFile.IniReadValue("Setting", "ZxUploadXmlPath");
            }
            return connstr;
        }
        //获取xml上传文件中的公司编号
        public static string GetZxXmlComcodeFromTxt()
        {
            string txtFilePath = System.Windows.Forms.Application.StartupPath + "\\setting.ini";
            string connstr = "";
            if (File.Exists(txtFilePath))
            {
                CIniFile myFile = new CIniFile(txtFilePath);
                connstr = myFile.IniReadValue("Setting", "ZxUploadXmlComcode");
            }
            return connstr;
        }
        //获取xml文件路径
        public static string GetZxXmlComnameFromTxt()
        {
            string txtFilePath = System.Windows.Forms.Application.StartupPath + "\\setting.ini";
            string connstr = "";
            if (File.Exists(txtFilePath))
            {
                CIniFile myFile = new CIniFile(txtFilePath);
                connstr = myFile.IniReadValue("Setting", "ZxUploadXmlComname");
            }
            return connstr;
        }
        public static string GetDianMa()
        {
            string txtFilePath = System.Windows.Forms.Application.StartupPath + "\\setting.ini";
            string connstr = "";
            if (File.Exists(txtFilePath))
            {
                CIniFile myFile = new CIniFile(txtFilePath);
                connstr = myFile.IniReadValue("Setting", "DianMa");
            }
            return connstr;
        }
        /// <summary>
        /// 将新密码进行加密后，写入配置文件
        /// </summary>
        /// <param name="newPassWord"></param>
        /// <returns></returns>
        public static bool WriteDBConnect2Txt(string newConnStr)
        {
            string filePath = System.Windows.Forms.Application.StartupPath + "\\setting.ini";
            if(!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            CIniFile myFile = new CIniFile(filePath);
            try
            {
                myFile.IniWriteValue("Setting", "DataBase", newConnStr);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static SqlConnection GetConnection()
        {
            string connectStr = GetDBConnectFromTxt();
            SqlConnection thisConn = new SqlConnection(connectStr);
            return thisConn;
        }
        public static bool TryConnect(SqlConnection thisConn)
        {
            bool isConnected = false;
            try
            {
                thisConn.Open();
            }
            catch
            {
                isConnected = false;
            }
            if (thisConn.State == ConnectionState.Open)
            {
                isConnected = true;
            }
            return isConnected;
        }
        /// <summary>
        /// @begindate VARCHAR(50),@enddate VARCHAR(50),@buydate  VARCHAR(50)
        /// </summary>
        /// <param name="thisConn"></param>
        /// <returns></returns>
        public List<DataTable> GetUnSalableDrug(SqlConnection thisConn, DateTime begindate, DateTime enddate, DateTime buydate, int num)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandTimeout = 0;
            thisCommand.CommandText = "z_select_unsalable";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParme;
            /*
            sqlParme = thisCommand.Parameters.Add("@begindate", SqlDbType.DateTime);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = begindate;
            //参数2
            sqlParme = thisCommand.Parameters.Add("@enddate", SqlDbType.DateTime);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = enddate;
            //参数3
            sqlParme = thisCommand.Parameters.Add("@buydate", SqlDbType.DateTime);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = buydate;
            */
            //参数4
            sqlParme = thisCommand.Parameters.Add("@num", SqlDbType.Int);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = num;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(thisReader);
            //DataTable dtclone = dt.Clone();
            List<DataTable> dtlist = new List<DataTable>(4);//初始化datatable数组
            for (int i = 0; i < 4; i++)
            {
                DataTable newtb = new DataTable();
                newtb = dt.Clone();
                dtlist.Add(newtb);
            }
            foreach (DataRow row in dt.Rows)
                {
                    String info = row[8].ToString();
                    switch (info)
                    {
                        case "备货品种":
                            dtlist[0].Rows.Add(row.ItemArray);
                            break;
                        case "严重超标":
                            dtlist[1].Rows.Add(row.ItemArray);
                            break;
                        case "一般超标":
                            dtlist[2].Rows.Add(row.ItemArray);
                            break;
                        case "建议采购":
                            dtlist[3].Rows.Add(row.ItemArray);
                            break;
                        default:
                            break;
                    }
                }
            return dtlist;
        }

        public String GetUnSalableDrug_ZongDian(SqlConnection thisConn){
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandTimeout = 0;
            thisCommand.CommandText = "z_select_unsalable_zong";
            thisCommand.CommandType = CommandType.StoredProcedure;
           object r=  thisCommand.ExecuteScalar();
           if (r != null)
           {
               return r.ToString();
           }
           else
           {
               return "";
           }
        }

        public String GetUnSalableDrug_ZongDian_Zhongyao(SqlConnection thisConn)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandTimeout = 0;
            thisCommand.CommandText = "z_select_unsalable_zong_zhongyao";
            thisCommand.CommandType = CommandType.StoredProcedure;
            object r = thisCommand.ExecuteScalar();
            if (r != null)
            {
                return r.ToString();
            }
            else
            {
                return "";
            }
        }

        public DataTable GetUnSalableDrug_ZhongYao(SqlConnection thisConn)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandTimeout = 0;
            thisCommand.CommandText = "z_select_unsalable_zhongyao";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(thisReader);
            return dt;
        }

        public DataTable GetGYS(SqlConnection thisConn, string dm,string gysmc,string gysbm)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandTimeout = 0;
            thisCommand.CommandText = "z_select_gys";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParme;
            sqlParme = thisCommand.Parameters.Add("@dm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = dm;
            //参数2
            sqlParme = thisCommand.Parameters.Add("@gysmc", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = gysmc;
            //参数3
            sqlParme = thisCommand.Parameters.Add("@gbm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = gysbm;

            SqlDataReader thisReader = thisCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(thisReader);
            return dt;
        }
        public void UpdatePinMingPPC(SqlConnection thisConn,string dm)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "z_update_pinming_ppc";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParme;
            sqlParme = thisCommand.Parameters.Add("@dm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = dm;

            thisCommand.CommandTimeout = 0;
            thisCommand.ExecuteNonQuery();
        }
        public DataTable UpdateScore(SqlConnection thisConn, string dm)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "z_update_jifen";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParme;
            sqlParme = thisCommand.Parameters.Add("@dm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = dm;

            DataTable dtable = new DataTable();
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            thisCommand.CommandTimeout = 0;
            dtable.Load(thisReader);
            return dtable;
        }
        public void UpdatePercentage(SqlConnection thisConn, string gsbm)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "z_update_percentage";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParme;
            sqlParme = thisCommand.Parameters.Add("@gsbm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = gsbm;
            thisCommand.CommandTimeout = 0;
            thisCommand.ExecuteNonQuery();
        }
        public DataTable SelectGYS(SqlConnection thisConn, string mc)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = string.Format("SELECT bm as 供应商编码,mc as 供应商,lxr as 联系人"
                + " FROM  p_gysxx_wh WHERE (mc LIKE '%{0}%' or zjm LIKE '%{0}%') and bm IN(select bm from p_gysxx_wh_fd)  ORDER BY 供应商", mc);
            DataTable dtable = new DataTable();
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            thisCommand.CommandTimeout = 0;
            dtable.Load(thisReader);
            return dtable;
        }

        public DataTable SelectVIP(SqlConnection thisConn, string dm)
        {
            string dmstr = dm;
            if(dm=="001")//店码是001的，会员所在店码可能是000和001
            {
                dmstr = "000','001";
            }
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = string.Format("SELECT bm1 as 卡号,mc as 姓名,dh as 电话,sj as 地址,jf as 积分"
                +" FROM  p_hyxx_wh WHERE dm IN('{0}') ORDER BY 积分 desc", dmstr);
            DataTable dtable = new DataTable();
            thisCommand.CommandTimeout = 0;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            dtable.Load(thisReader);
            return dtable;
        }
        public DataTable SelectMedicine(SqlConnection thisConn, string dm)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = string.Format("SELECT bm as 药品编码,mc as 药品,sccj as 厂家,gg as 规格"
                + " FROM  p_spjcxx_sz WHERE mc LIKE '%{0}%' or zjm LIKE '%{0}%' ORDER BY 药品编码", dm);
            DataTable dtable = new DataTable();
            thisCommand.CommandTimeout = 0;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            dtable.Load(thisReader);
            return dtable;
        }
        public DataTable SelectMedicineByVIP(SqlConnection thisConn, string dm, string ypbm, DateTime begindate, DateTime enddate)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "z_select_vip_sale";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParme;
            sqlParme = thisCommand.Parameters.Add("@dm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = dm;
            sqlParme = thisCommand.Parameters.Add("@ypbm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = ypbm;
            sqlParme = thisCommand.Parameters.Add("@begindate", SqlDbType.DateTime);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = begindate;
            sqlParme = thisCommand.Parameters.Add("@enddate", SqlDbType.DateTime);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = enddate;
            thisCommand.CommandTimeout = 0;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            DataTable dtable = new DataTable();
            dtable.Load(thisReader);
            return dtable;
        }
        public DataTable SelectMedicineDetailByVIP(SqlConnection thisConn,string khbm, string dm, string ypbm, DateTime begindate, DateTime enddate)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "z_select_vip_sale_detail";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParme;

            sqlParme = thisCommand.Parameters.Add("@vipdm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = khbm;
            
            sqlParme = thisCommand.Parameters.Add("@dm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = dm;
            
            sqlParme = thisCommand.Parameters.Add("@ypbm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = ypbm;
            
            sqlParme = thisCommand.Parameters.Add("@begindate", SqlDbType.DateTime);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = begindate;
            
            sqlParme = thisCommand.Parameters.Add("@enddate", SqlDbType.DateTime);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = enddate;
            
            thisCommand.CommandTimeout = 0;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            DataTable dtable = new DataTable();
            dtable.Load(thisReader);
            return dtable;
        }
        public DataTable SelectVIPLevel(SqlConnection thisConn,string dm)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "z_compute_vip_level";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParme;
            sqlParme = thisCommand.Parameters.Add("@dm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = dm;

            DataTable dtable = new DataTable();
            thisCommand.CommandTimeout = 0;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            dtable.Load(thisReader);
            return dtable;
        }
        public DataTable SelectSpxx(SqlConnection thisConn, string spname)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = string.Format("Select  bm,mc,sccj,gg,jhdw From p_spjcxx_sz Where mc like '%{0}%' Order By mc",spname);
            
            DataTable dtable = new DataTable();
            thisCommand.CommandTimeout = 0;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            dtable.Load(thisReader);
            return dtable;
        }

        public DataTable SelectNeedBuy(SqlConnection thisConn)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "z_select_need_buy";
            thisCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtable = new DataTable();
            thisCommand.CommandTimeout = 0;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            dtable.Load(thisReader);
            return dtable;
        }
        public void UploadPur(SqlConnection thisConn, string bm,string mc,string sccj,string gg,string jhdw,double yssl,string dm)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "z_upload_pur";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParme;
            sqlParme = thisCommand.Parameters.Add("@bm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = bm;
            sqlParme = thisCommand.Parameters.Add("@mc", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = mc;
            sqlParme = thisCommand.Parameters.Add("@sccj", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = sccj;
            sqlParme = thisCommand.Parameters.Add("@gg", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = gg;
            sqlParme = thisCommand.Parameters.Add("@jhdw", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = jhdw;
            sqlParme = thisCommand.Parameters.Add("@yssl", SqlDbType.Decimal);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = yssl;
            sqlParme = thisCommand.Parameters.Add("@dm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = dm;
            thisCommand.CommandTimeout = 0;
            thisCommand.ExecuteNonQuery();
        }

        public DataTable SelectSpxxByName(SqlConnection thisConn, string spname)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = string.Format("Select  bm,mc,sccj,gg,jhdw,spmc,is_gzyp From p_spjcxx_sz Where mc like '%{0}%' Order By mc", spname);

            DataTable dtable = new DataTable();
            thisCommand.CommandTimeout = 0;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            dtable.Load(thisReader);
            return dtable;
        }
        public DataTable SelectGYSForUpdate(SqlConnection thisConn, string mc)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = string.Format("SELECT bm as 供应商编码,mc as 供应商,lxr as 联系人,xkzh as 区域编码"
                + " FROM  p_gysxx_wh WHERE (mc LIKE '%{0}%' or zjm LIKE '%{0}%') and bm IN(select bm from p_gysxx_wh_fd)  ORDER BY 供应商", mc);
            DataTable dtable = new DataTable();
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            thisCommand.CommandTimeout = 0;
            dtable.Load(thisReader);
            return dtable;
        }

        public List<CXmlIn> GetXmlInsList(SqlConnection thisConn,DateTime date)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "z_up_xml_in";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParme;
            sqlParme = thisCommand.Parameters.Add("@vdate", SqlDbType.DateTime);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = date;

            thisCommand.CommandTimeout = 0;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            List<CXmlIn> xmlInList = new List<CXmlIn>();
            while (thisReader.Read())
            {
                CXmlIn xin = new CXmlIn();
                xin.FPH = thisReader["fph"].ToString();
                xin.YPPH = thisReader["ypph"].ToString();
                xin.VDATE = thisReader["vdate"].ToString();
                xin.PACKAGE = thisReader["package"].ToString();
                xin.UNIT = thisReader["unit"].ToString();
                xin.NUM = Convert.ToDecimal(thisReader["num"]);
                xin.JZ_DATE = thisReader.GetDateTime(7);
                xin.FPH = thisReader["fph"].ToString();
                xin.I_MER_CODE = thisReader["i_mer_code"].ToString();
                xin.MER_NAME = thisReader["mer_name"].ToString();
                xin.MERA_CODE = thisReader["mera_code"].ToString();
                xin.I_ITEM_CODE = thisReader["i_item_code"].ToString();
                xin.BILL_TYPE = thisReader["bill_type"].ToString();
                xmlInList.Add(xin);
            }
            thisReader.Close();
            return xmlInList;
        }
        public List<CXmlOut> GetXmlOutsList(SqlConnection thisConn, DateTime date)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "z_up_xml_out";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParme;
            sqlParme = thisCommand.Parameters.Add("@vdate", SqlDbType.DateTime);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = date;

            thisCommand.CommandTimeout = 0;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            List<CXmlOut> xmlOutList = new List<CXmlOut>();
            while (thisReader.Read())
            {
                CXmlOut xout = new CXmlOut();
                xout.I_ITEM_CODE = thisReader["i_item_code"].ToString();
                xout.YPPH = thisReader["ypph"].ToString();
                xout.VDATE = thisReader["vdate"].ToString(); ;
                xout.PACKAGE = thisReader["package"].ToString();
                xout.UNIT = thisReader["unit"].ToString();
                xout.NUM = Convert.ToDecimal(thisReader["num"]);
                xout.JZ_DATE = thisReader.GetDateTime(7);
                xout.FPH = thisReader["fph"].ToString();
                xout.I_MER_CODE = thisReader["i_mer_code"].ToString();
                xout.MER_NAME = thisReader["mer_name"].ToString();
                xout.MERA_CODE = thisReader["mera_code"].ToString();
                xout.BILL_TYPE = thisReader["bill_type"].ToString();
                xmlOutList.Add(xout);
            }
            thisReader.Close();
            return xmlOutList;
        }

        public List<CXmlInit> GetXmlInitsList(SqlConnection thisConn, DateTime date)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "z_up_xml_init";
            thisCommand.CommandType = CommandType.StoredProcedure;
            thisCommand.CommandTimeout = 0;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            List<CXmlInit> xmlInitList = new List<CXmlInit>();
            while (thisReader.Read())
            {
                CXmlInit xinit = new CXmlInit();
                xinit.I_ITEM_CODE = thisReader["i_item_code"].ToString();
                xinit.BARCODE = thisReader["barcode"].ToString();
                xinit.YPPH = thisReader["ypph"].ToString();
                xinit.VDATE = thisReader["vdate"].ToString();
                xinit.PACKAGE = thisReader["package"].ToString();
                xinit.UNIT = thisReader["unit"].ToString();
                xinit.NUM = Convert.ToDecimal(thisReader["num"]);
                xmlInitList.Add(xinit);
            }
            thisReader.Close();
            return xmlInitList;
        }

        public DataTable SelectYxqx(SqlConnection thisConn, int flag)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            if (flag == 0)
            {
                thisCommand.CommandText = " SELECT lsh,bm,mc,sccj,gg,dw,yxqx From kcgl_sprkd_xx "
                                                        +" Where ISDATE( REPLACE(ISNULL(yxqx,'')+'01',' ',''))<>1 "
                                                        +" AND ISDATE( REPLACE(yxqx,' ',''))<>1 AND bm IN (SELECT bm FROM p_spjcxx_sz WHERE is_gzyp=1) "
                                                        +" Order By lsh";
            }
            else if (flag == 1)
            {
                thisCommand.CommandText = " SELECT lsh,bm,mc,sccj,gg,dw,yxqx From sale_xsd_xx "
                                                        + " Where ISDATE( REPLACE(ISNULL(yxqx,'')+'01',' ',''))<>1 "
                                                        + " AND ISDATE( REPLACE(yxqx,' ',''))<>1 AND bm IN (SELECT bm FROM p_spjcxx_sz WHERE is_gzyp=1) "
                                                        + " Order By lsh";
            }
            else
            {
                thisCommand.CommandText = "SELECT kc.lsh,kc.bm,sp.mc,sp.sccj,sp.gg,sp.dw,kc.yxqx FROM   kcgl_spkcxx kc "
                                            +" LEFT JOIN dbo.p_spjcxx_sz sp ON kc.bm=sp.bm "
                                            +" Where ISDATE( REPLACE(ISNULL(kc.yxqx,'')+'01',' ',''))<>1 "
                                            +" AND ISDATE( REPLACE(kc.yxqx,' ',''))<>1 AND kc.bm IN (SELECT bm FROM p_spjcxx_sz WHERE is_gzyp=1) "
                                            +" Order By kc.lsh";
            }
            DataTable dtable = new DataTable();
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            thisCommand.CommandTimeout = 0;
            dtable.Load(thisReader);
            return dtable;
        }

        //药品的单品汇总查询
        public DataTable SelectSingMedicineStatis(SqlConnection thisConn, string bm,DateTime begindate, DateTime enddate)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "z_select_buy_sum";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParme;
            sqlParme = thisCommand.Parameters.Add("@date1", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = begindate.ToString("yyyyMM");
            sqlParme = thisCommand.Parameters.Add("@date2", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = enddate.ToString("yyyyMM");
            sqlParme = thisCommand.Parameters.Add("@bm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = bm;
            thisCommand.CommandTimeout = 0;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            DataTable dtable = new DataTable();
            dtable.Load(thisReader);
            return dtable;
        }
        //药品的明细查询
        public DataTable SelectSingMedicineDetail(SqlConnection thisConn, string bm, string dm, DateTime begindate, DateTime enddate)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "z_select_buy_sum_detail";
            thisCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParme;
            sqlParme = thisCommand.Parameters.Add("@date1", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = begindate.ToString("yyyyMM");

            sqlParme = thisCommand.Parameters.Add("@date2", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = enddate.ToString("yyyyMM");

            sqlParme = thisCommand.Parameters.Add("@bm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = bm;

            sqlParme = thisCommand.Parameters.Add("@dm", SqlDbType.NVarChar);
            sqlParme.Direction = ParameterDirection.Input;
            sqlParme.Value = dm;
            
            thisCommand.CommandTimeout = 0;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            DataTable dtable = new DataTable();
            dtable.Load(thisReader);
            return dtable;
        }
    }
}