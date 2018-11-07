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
    public partial class ManagerAssginFrm : Form
    {
        IList<JobInfo> joblist = JobInfoManager.GetAllJobByUid();
        UserInfor user = UserInforBLL.CurrentUser;
        
        public ManagerAssginFrm()
        {
            InitializeComponent();
        }

        private void cbWoker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

        }

        private void ManagerAssginFrm_Load(object sender, EventArgs e)
        {
            cbPriority.DataSource = System.Enum.GetNames(typeof(Priority));
            Priority penum = Priority.High;

            cbPriority.SelectedIndex = this.cbPriority.FindString();


        }

    }
}
