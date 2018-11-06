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
        private JobInfo m_job = new JobInfo();
        UserInfor user = UserInforBLL.CurrentUser;

        public addJob()
        {
            InitializeComponent();
            this.CancelButton = btn_cancel;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
       

        private void btn_Submit_Click(object sender, EventArgs e)
        {


            m_job.carNo = textBoxCarNo.Text;
            m_job.customer = UserInforBLL.GetUserByName(textBoxCName.Text);
            m_job.jobType = cbType.Text;
            m_job.jobDescription = jobDes.Text;
            m_job.priority = Priority.Normal;
            m_job.resolve = ResolveStatus.Unresolved;
            m_job.jobStatus = JobStatus.Open;
            m_job.desk = user;
            m_job.createdate = DateTime.Now;

            JobInfoManager.AddJob(m_job);

            DialogResult = System.Windows.Forms.DialogResult.OK;



        }

       
    }
}
