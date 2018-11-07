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
        public JobStatistic()
        {
            InitializeComponent();
        }

        private void JobStatistic_Load(object sender, EventArgs e)
        {
            IList<JobInfo> totaljobs = JobInfoManager.GetAllJobByUid();



            //labelTotalJob.Text = "Totail job " + + "Unsolved job " + + "Unassgin job ";
        }
    }
}
