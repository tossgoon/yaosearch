using System;
using System.Collections.Generic;
using System.Text;

namespace YaoSearch
{
    class CXmlIn
    {
        public const string MESSAGE_TYPE = "1";
        private string i_item_code;
        private string ypph;
        private string vdate;//有效日期
        private string package;
        private string unit;
        private decimal num;
        private DateTime jz_date;
        private string fph;
        private string i_mer_code;
        private string mer_name;
        private string mera_code;
        private string bill_type;
        public string YPPH
        {
            get { return ypph; }
            set { ypph = value; }
        }
        public string VDATE
        {
            get { return vdate; }
            set { vdate = value; }
        }
        public string PACKAGE
        {
            get { return package; }
            set { package = value; }
        }
        public string UNIT
        {
            get { return unit; }
            set { unit = value; }
        }
        public decimal NUM
        {
            get { return num; }
            set { num = value; }
        }
        public DateTime JZ_DATE
        {
            get { return jz_date; }
            set { jz_date = value; }
        }
        public string FPH
        {
            get { return fph; }
            set { fph = value; }
        }
        public string I_MER_CODE
        {
            get { return i_mer_code; }
            set { i_mer_code = value; }
        }
        public string MER_NAME
        {
            get { return mer_name; }
            set { mer_name = value; }
        }
        public string MERA_CODE
        {
            get { return mera_code; }
            set { mera_code = value; }
        }
        public string I_ITEM_CODE
        {
            get { return i_item_code; }
            set { i_item_code = value; }
        }
        public string BILL_TYPE
        {
            get { return bill_type; }
            set { bill_type = value; }
        }
    }
}
