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






    }
}
