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
//
namespace TcarSystem
{
    public partial class TcarLogin : Form
    {

        public TcarLogin()
        {
            InitializeComponent();
            textBoxName.Text = "zoe";
           textBoxPassword.Text = "zoe";

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
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
            //this.DialogResult = System.Windows.Forms.DialogResult.OK;
            UserInforBLL bll = new UserInforBLL();
            string usertype = bll.checkUtype(textBoxName.Text);

            if (usertype == "user")
            {
                this.Hide();
                //UserMDI mdu = new UserMDI();
                //mdu.Show();
                userpage usp = new userpage();
                usp.Show();
            }
            else if (usertype == "hpdesk")
            {
                this.Hide();
                helpDeskForm mdhp = new helpDeskForm();

                mdhp.Show();
            }
            else if (usertype == "work")
            {
                this.Hide();
                WorkerFrm mdwk = new WorkerFrm();
                mdwk.Show();
            }
            else
            {
                this.Hide();
                ManagerFrm mdm = new ManagerFrm();
                mdm.Show();
            }

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

        private void btnSigin_Click(object sender, EventArgs e)
        {
            SignForm signin = new SignForm();
            signin.Show();
        }

        private void TcarLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
