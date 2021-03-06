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
    public partial class CustomerAdd : Form
    {
        private JobInfo m_job;
        private static UserInfor user = UserInforBLL.CurrentUser;
        public CustomerAdd()
        {
            m_job = new JobInfo();
            InitializeComponent();
            this.CancelButton = btn_cancel;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public CustomerAdd(JobInfo currentJob)
        {
            m_job = currentJob;
            InitializeComponent();
            this.CancelButton = btn_cancel;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

        private void CustomerAdd_Load(object sender, EventArgs e)
        {
            cbType.DataSource = System.Enum.GetNames(typeof(JobType));
            //cbType.Text = m_job.jobType.ToString();
            foreach (Outlet o in JobInfoManager.getAllOutletsBycus())
            {
                ItemData item = new ItemData(o.Name, o);
                cbOutlet.Items.Add(item);
                if (m_job.outlet != null && o.Id == m_job.outlet.Id)
                    cbOutlet.SelectedItem = item;
            }
            
            if (m_job.id != null)
            {

                txCarNo.Text = m_job.carNo;
                cbOutlet.Text = (m_job.outlet == null) ? "" : m_job.outlet.Name;
                cbType.Text =  m_job.jobType.ToString();
                txJobDes.Text = m_job.jobDescription;



            }
        }

        private void cbOutlet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (cbOutlet.SelectedItem == null)
            {
                cbOutlet.Focus();
                return;
            }
            //cbType.DataSource = System.Enum.GetNames(typeof(JobType));
            


            m_job.carNo = txCarNo.Text;
            // m_job.jobType = (JobType)cbType.SelectedItem.ToString();
            
            m_job.jobType = (JobType)Enum.Parse(typeof(JobType), cbType.Text);

            m_job.jobDescription = txJobDes.Text;
            m_job.priority = Priority.Normal;
            m_job.createdate = DateTime.Now;
            m_job.customer = user;
            m_job.outlet = (Outlet)((ItemData)cbOutlet.SelectedItem).Value;
            if (m_job.id == null)
                m_job.jobStatus = JobStatus.Unconfirmed;
             m_job.resolve = ResolveStatus.Unresolved;


            if (m_job.id == null)
                JobInfoManager.AddJob(m_job);
            else if (m_job.jobStatus == JobStatus.Unconfirmed)
                JobInfoManager.UpdateJob(m_job);
            else 
            {
                JobStatus temp = m_job.jobStatus;
                MessageBox.Show("Sorry, cannot modify the job!");
                //System.Windows.Forms.DialogResult.Cancel;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
