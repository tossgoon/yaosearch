using System;
using System.Collections.Generic;
using System.Text;

namespace YaoSearch
{
    class CSpxx
    {
        private string bm;

        public string Bm
        {
            get { return bm; }
            set { bm = value; }
        }
        private string mc;

        public string Mc
        {
            get { return mc; }
            set { mc = value; }
        }
        private string gg;

        public string Gg
        {
            get { return gg; }
            set { gg = value; }
        }
        private string sccj;

        public string Sccj
        {
            get { return sccj; }
            set { sccj = value; }
        }
        private string jhdw;

        public string Jhdw
        {
            get { return jhdw; }
            set { jhdw = value; }
        }
        public CSpxx()
        {

        }
        public CSpxx(string bm, string mc, string gg, string sccj, string jhdw)
        {
            this.bm = bm;
            this.mc = mc;
            this.gg = gg;
            this.sccj = sccj;
            this.jhdw = jhdw;
        }
        
    }
}
