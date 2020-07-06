using System;
using System.Collections.Generic;
using System.Text;

namespace YaoSearch
{
    public class CXmlEnv
    {
        private const string version = "v1.0";
        private string message_id;
        private string file_name;
        private string message_type;
        private string sender_id;
        private DateTime send_time;
        private const string receiver_id = "1300000000";
        private string softtype;

        public string RECEIVER_ID
        {
            get { return receiver_id; }
        }


        public string SOFTTYPE
        {
            get { return softtype; }
            set { softtype = value; }
        } 

        private string sendername;
        private DateTime generate_date;

        public string MESSAGE_ID
        {
            get
            {
                return  Guid.NewGuid().ToString();
            }
        }

        public string FILE_NAME
        {
            get
            {
                return "k_" + MESSAGE_TYPE + "_" + this.SEND_TIME.ToString("yyyyMMddHHmmss") + "_" + this.SENDER_ID + "#" + SOFTTYPE + ".xml"; ;
            }
            set
            {
                file_name = value;
            }
        }
        public string MESSAGE_TYPE
        {
            get
            {
                return message_type;
            }
            set
            {
                message_type = value;
            }
        }
        public string SENDER_ID
        {
            get
            {
                return sender_id;
            }
            set
            {
                sender_id = value;
            }
        }

        public DateTime SEND_TIME
        {
            get
            {
                return DateTime.Now;
            }
        }
        public string SENDERNAME
        {
            get
            {
                return sendername;
            }
            set
            {
                sendername = value;
            }
        }
        public DateTime GENERATE_DATE
        {
            get { return generate_date; }
            set { generate_date = value; }
        }
        public string VERSION
        {
            get { return version; }
        } 

    }
}
