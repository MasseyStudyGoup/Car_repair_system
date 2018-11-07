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
        private JobInfo jobcurrent = new JobInfo();
        UserInfor user = UserInforBLL.CurrentUser;
        
        public ManagerAssginFrm()
        {
            InitializeComponent();
            this.CancelButton = btn_cancel;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public ManagerAssginFrm(JobInfo currentJob)
        {
            InitializeComponent();
            this.CancelButton = btn_cancel;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            jobcurrent = currentJob;
        }

        private void cbWoker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.CancelButton = btn_cancel;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //get priority in model enum
            jobcurrent.priority = (Priority)Enum.Parse(typeof(Priority), cbPriority.Text);

            //get worker in sys_roleService
            if(cbWoker.SelectedItem != null)
            {
                jobcurrent.worker = (UserInfor)((ItemData)cbWoker.SelectedItem).Value;
            }

            jobcurrent.assigndate = DateTime.Now;
            jobcurrent.jobStatus = JobStatus.Assigned;

            //submit value
            JobInfoManager.assign(jobcurrent);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void ManagerAssginFrm_Load(object sender, EventArgs e)
        {
            //Get and set priority value 
            cbPriority.DataSource = System.Enum.GetNames(typeof(Priority));
            cbPriority.Text = jobcurrent.priority.ToString();

            //Get and set worker value
            IList<UserInfor> userlist = UserInforBLL.GetAllWorkers(user.outlet);
            foreach (UserInfor worker in userlist)
            {

                 ItemData item = new ItemData(worker.UserName, worker);
                 cbWoker.Items.Add(item);
                 if (jobcurrent.worker != null && jobcurrent.worker.UserId == worker.UserId)
                 {
                     cbWoker.SelectedItem = item;
                 }

            }
            
            if(jobcurrent.worker != null)
            {
                cbWoker.Text = jobcurrent.worker.UserName.ToString();
            }
            else
            {
                cbWoker.Text = "Plese select";
            }

        }

    }
}
