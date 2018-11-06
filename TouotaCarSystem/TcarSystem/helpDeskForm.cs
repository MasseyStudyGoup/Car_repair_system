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

            if (jobs != null )
            {
                foreach (JobInfo job in jobs)
                {
                    deskJobList.Rows.Add(new string[] {
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
       
        

        public event EventHandler evtMember;

        //ShowFrmUpdataCreate 1 == add job 2 == updata jobs
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addJob jobForm = new addJob();
            jobForm.ShowDialog();
            ShowFrmUpdataCreate(1);

        }

        private void btnUpdataJob_Click(object sender, EventArgs e)
        {
            if(deskJobList.SelectedRows.Count>0)
            {
                int id = Convert.ToInt32(deskJobList.SelectedRows[0].Cells[0].Value.ToString());

                JobInfo job = JobInfoManager.GetJobById(id);
                meg.obj = job;

                ShowFrmUpdataCreate(2);
                //NewJobForm jobForm = new NewJobForm();
                //jobForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select which line you want change!");
            }

            
        }
        MyEventArgs meg = new MyEventArgs();//For pass value
        public void ShowFrmUpdataCreate(int numb)
        {
            addJob inforfrm = new addJob();
            this.evtMember += new EventHandler(inforfrm.SetText);
            meg.Temp = numb;
            if(this.evtMember != null)
            {
                this.evtMember(this, meg);
                inforfrm.FormClosed += new FormClosedEventHandler(inforfrm_FormClosed);
                inforfrm.ShowDialog();
            }
            
                 
        }

        private void inforfrm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void hd_search_Click(object sender, EventArgs e)
        {
            hd_search jobForm = new hd_search();
            jobForm.ShowDialog();
        }
    }
}
