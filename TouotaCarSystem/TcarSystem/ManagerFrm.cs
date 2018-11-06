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
    public partial class ManagerFrm : Form
    {
        public ManagerFrm()
        {
            InitializeComponent();
        }

        //Loading datagraid
        private void ManagerFrm_Load(object sender, EventArgs e)
        {
            UserInfor user = UserInforBLL.CurrentUser;
            labelWelcome.Text = "Welcome" + " " + user.UserName + "!";


            IList<JobInfo> jobs = JobInfoManager.GetAllJobInfos();

            if (jobs != null)
            {
                foreach (JobInfo job in jobs)
                {
                    ManagerJobList.Rows.Add(new string[] {
                    job.id,
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

        private void btnAssgin_Click(object sender, EventArgs e)
        {
            ManagerAssginFrm assgin = new ManagerAssginFrm();
            assgin.ShowDialog();
            ManagerFrm_Load(null, null);
        }

        private void btn_Msearch_Click(object sender, EventArgs e)
        {
            ManagerSearchFrm search = new ManagerSearchFrm();
            search.ShowDialog();
        }
    }
}
