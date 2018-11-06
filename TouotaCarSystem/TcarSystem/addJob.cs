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
    public partial class addJob : Form
    {
        private JobInfo m_job;
        UserInfor user = UserInforBLL.CurrentUser;

        public addJob()
        {
            InitializeComponent();
        }

       

        private void btn_Submit_Click(object sender, EventArgs e)
        {


            m_job.carNo = textBoxCarNo.Text;
            m_job.customer = UserInforBLL.GetUserByName(textBoxCName.Text);
            m_job.jobType = cbType.Text;
            m_job.jobDescription = jobDes.Text;
            m_job.priority = 0;
            m_job.desk = user;
            m_job.createdate = DateTime.Now;

            


        }

       
    }
}
