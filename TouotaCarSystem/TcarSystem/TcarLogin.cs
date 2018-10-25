using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcarSystem.BLL;
using TcarSystem.Model;

namespace TcarSystem
{
    public partial class TcarLogin : Form
    {
        public TcarLogin()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check the user
            if (CheckText())
            {
                //seting current login form value
                string msg = "";
                UserInforBLL bll = new UserInforBLL();
                if(bll.IsLoginByLoginName(textBoxName.Text, textBoxPassword.Text,out msg))
                {
                    MessageBox.Show(msg);
                    Bind();
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }

            
        }

        public void Bind()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        //function for check name and password not null
        private bool CheckText()
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Sorry, name can not be empty!");
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Sorry, password can not be empty!");
                return false;
            }

            return true;
        }
    }
}
