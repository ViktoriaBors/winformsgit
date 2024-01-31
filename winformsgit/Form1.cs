using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformsgit
{
    public partial class Form1 : Form
    {
        Color betuSzin = Color.Gold;
        Color Panel = Color.LightSteelBlue;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // szinek csere
            BackColor = Panel;
           ForeColor = betuSzin;
        }
    }
}
