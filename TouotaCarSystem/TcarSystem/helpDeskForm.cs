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
    public partial class helpDeskForm : Form
    {
        public helpDeskForm()
        {
            InitializeComponent();
        }
        //
        private void helpDeskForm_Load(object sender, EventArgs e)
        {
            IList<JobInfo> jobs = JobInfoManager.GetAllJobInfos();
            foreach(JobInfo job in jobs)
            {
                deskJobList.Rows.Add(new string[] {
                    job.id,
                    job.carNo
                });
            }
        }

        private void deskJobList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewJobForm jobForm = new NewJobForm();
            jobForm.ShowDialog();

        }
    }
}
