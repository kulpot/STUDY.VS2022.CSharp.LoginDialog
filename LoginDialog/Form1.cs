using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            using(LoginDialog frmLogin = new LoginDialog())///change name to LoginDialog.cs---for show only dailog
            {
                if(frmLogin.ShowDialog() == DialogResult.OK)
                {
                    this.Text = "Hello " + frmLogin.UserName;
                }
                else
                {
                    Application.Exit();
                }
            }

            base.OnLoad(e);
        }
    }
}
