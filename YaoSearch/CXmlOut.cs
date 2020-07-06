using System;
using System.Collections.Generic;
using System.Text;

namespace YaoSearch
{
    class CXmlOut
    {
        private string message_type;

        public string MESSAGE_TYPE
        {
            get { return   "2"; }
            set { message_type = value; }
        }

        private string i_item_code;

        public string I_ITEM_CODE
        {
            get { return i_item_code; }
            set { i_item_code = value; }
        }



        private string ypph;

        public string YPPH
        {
            get { return ypph; }
            set { ypph = value; }
        }
        private string vdate;

        public string VDATE
        {
            get { return vdate; }
            set { vdate = value; }
        }
        private string package;

        public string PACKAGE
        {
            get { return package; }
            set { package = value; }
        }
        private string unit;

        public string UNIT
        {
            get { return unit; }
            set { unit = value; }
        }
        private decimal num;

        public decimal NUM
        {
            get { return num; }
            set { num = value; }
        }
        private DateTime jz_date;

        public DateTime JZ_DATE
        {
            get { return jz_date; }
            set { jz_date = value; }
        }
        private string fph;

        public string FPH
        {
            get { return fph; }
            set { fph = value; }
        }
        private string i_mer_code;

        public string I_MER_CODE
        {
            get { return i_mer_code; }
            set { i_mer_code = value; }
        }
        private string mer_name;

        public string MER_NAME
        {
            get { return mer_name; }
            set { mer_name = value; }
        }
        private string mera_code;

        public string MERA_CODE
        {
            get { return mera_code; }
            set { mera_code = value; }
        }
        private string bill_type;

        public string BILL_TYPE
        {
            get { return bill_type; }
            set { bill_type = value; }
        }

    }
}
