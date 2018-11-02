using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcarSystem.Model;
using TcarSystem.BLL;
namespace TcarSystem
{
    public partial class userpage : Form
    {
        public userpage()
        {
            InitializeComponent();
        }


        private void btn_checkStatus_Click(object sender, EventArgs e)
        {
            userControlCheckReport1.Show();
            userControlCheckReport1.BringToFront();
            userControlAddReport1.Hide();
        }

        private void btn_addReport_Click(object sender, EventArgs e)
        {
            userControlAddReport1.BringToFront();
            userControlAddReport1.Show();
            userControlAddReport1.BringToFront();
            userControlCheckReport1.Hide();


        }

        private void userpage_Load(object sender, EventArgs e)
        {
            userControlAddReport1.Hide();
            userControlCheckReport1.Show();
            UserInfor user = UserInforBLL.CurrentUser;
            //load welcome infor;
            labelWelcome.Text = "Welcome" + " " + user.UserName + "!";
        }

    }
}
