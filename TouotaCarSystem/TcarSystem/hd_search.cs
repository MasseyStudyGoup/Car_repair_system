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
    public partial class hd_search : Form
    {
        public hd_search()
        {
            InitializeComponent();
        }

        private void hd_search_Load(object sender, EventArgs e)
        {
            string sql = "";
           
            IList<JobInfo> jobs = JobInfoManager.GetAllJobByUid();

            if (jobs != null)
            {
                foreach (JobInfo job in jobs)
                {
                    dhSearcjJobList.Rows.Add(new string[] {
                    job.id,
                    job.carNo,
                    job.customer.UserName,
                    job.outlet.Name,
                    //job.priority.ToString(),
                    //job.jobStatus.ToString(),
                    job.jobDescription,
                    //job.desk.UserName,
                    //job.resove,
                    //job.jobStatus.ToString(),
                    //job.resolve.ToString(),
                    //job.comment,
                    job.createdate.ToString()

                });
                }
            }


            

        }

        private void hdSearch_Click(object sender, EventArgs e)
        {
            string status = "";
            string resolve = "";


        }
    }
}
