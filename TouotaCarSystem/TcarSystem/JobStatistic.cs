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
    public partial class JobStatistic : Form
    {
        UserInfor user = UserInforBLL.CurrentUser;
        IList<JobInfo> totaljobs = JobInfoManager.GetAllJobByUid();
        public JobStatistic()
        {
            InitializeComponent();
            btn_Close.DialogResult = DialogResult.Cancel;
        }

        private void JobStatistic_Load(object sender, EventArgs e)
        {
            int jobt = 0;
            foreach(JobInfo t in totaljobs)
            {
                dgStatistic.Rows.Add(new string[]
                {
                   string.Format("{0},{1}", t.worker.UserId, t.worker.UserName),

                });

            }


            //labelTotalJob.Text = "Totail job " +  + "Unsolved job " + ;
        }
    }
}
