using System;
using System.Collections.Generic;
using System.Text;

namespace YaoSearch
{
    public  class CXmlInit
    {
        private string message_type;

        public string MESSAGE_TYPE
        {
            get { return "3"; }
            set { message_type = value; }
        }
        private string i_item_code;

        public string I_ITEM_CODE
        {
            get { return i_item_code; }
            set { i_item_code = value; }
        }
        private string barcode;

        public string BARCODE
        {
            get { return barcode; }
            set { barcode = value; }
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
            get { return DateTime.Now; }
            set { jz_date = value; }
        }
    }
}
