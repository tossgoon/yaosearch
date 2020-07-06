using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YaoSearch
{
    public partial class FormLoading : Form
    {

        public FormLoading()
        {
            InitializeComponent();
        }
        public FormLoading(string txt)
        {
            InitializeComponent();
            lbtip.Text = "当前操作：" + txt + ".     请耐心等待......";
        }
    }
}
