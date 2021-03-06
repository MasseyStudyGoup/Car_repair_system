﻿using System;
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
        private Dictionary<string, JobInfo> m_jobDict = new Dictionary<string, JobInfo>();
        public helpDeskForm()
        {
            InitializeComponent();
            
        }
        //
        private void helpDeskForm_Load(object sender, EventArgs e)
        {
            deskJobList.Rows.Clear();
            m_jobDict.Clear();
            IList<JobInfo> jobs = JobInfoManager.GetAllJobInfos();

            if (jobs != null )
            {
                foreach (JobInfo job in jobs)
                {
                    m_jobDict.Add("" + job.id, job);

                    deskJobList.Rows.Add(new string[] {
                    job.id.ToString(),
                    job.carNo,
                    (job.outlet==null)?"":job.outlet.Name,
                    job.jobType.ToString(),
                    //job.priority.ToString(),
                    job.jobStatus.ToString(),
                    job.jobDescription,
                    job.resolve.ToString(),
                    job.comment,
                    job.createdate.ToString("yyyy-MM-dd HH:mm:ss")

                });
                }
            }
            
        }
       
        

      //  public event EventHandler evtMember;

        //ShowFrmUpdataCreate 1 == add job 2 == updata jobs
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addJob jobForm = new addJob();
            jobForm.ShowDialog();
            helpDeskForm_Load(null, null);
           // ShowFrmUpdataCreate(1);

        }

        private void btnUpdataJob_Click(object sender, EventArgs e)
        {
            EditJob();
            
        }
        

        private void inforfrm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void hd_search_Click(object sender, EventArgs e)
        {
            hd_search jobForm = new hd_search();
            jobForm.ShowDialog();
        }

        

        private void deskJobList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditJob();
        }


        private void EditJob()
        {
            JobInfo job = m_jobDict[deskJobList.SelectedRows[0].Cells[0].Value.ToString()];
            if (job != null)
            {
                addJob jobForm = new addJob(job);
                jobForm.ShowDialog();
                helpDeskForm_Load(null, null);

            }
        }
    }
}
