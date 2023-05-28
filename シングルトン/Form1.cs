using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace シングルトン
{
    public partial class Form1 : Form
    {
        //private CheckTimer _checkTimer = new CheckTimer();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CheckTimer.GetInstance().Start();
            //CheckTimer.Instance.Start();
            CheckTimer.Start();
        }
    }
}
