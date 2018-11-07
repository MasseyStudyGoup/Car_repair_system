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
                      
                    job.id.ToString(),
                    job.carNo,
                    (job.customer==null)?"":job.customer.UserName,
                    (job.outlet==null)?"":job.outlet.Name,
                    (job.jobType==null)?"":job.jobType,
                    //job.priority.ToString(),
                    job.jobStatus.ToString(),
                    job.jobDescription,
                    (job.desk==null)?"":job.desk.UserName,
                    job.resolve.ToString(),
                    job.comment,
                    job.createdate.ToString("yyyy-MM-dd HH:mm:ss")

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
