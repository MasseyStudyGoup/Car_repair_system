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
    public partial class NewJobForm : Form
    {
        public NewJobForm()
        {
            InitializeComponent();
        }


        private void NewJobForm_Load(object sender, EventArgs e)
        {
            JobInfoManager jobdetaile = new JobInfoManager();
            //MyEventArgs mag = new MyEventArgs();

            //List<JobInfo> jobinf = JobInfoManager.GetAllJobInfos
            //JobInfo jobs = mag.obj as JobInfo;
            //Outlet outlet = mag.obj as Outlet;
            //textBoxCarNo.Text = jobs.carNo.ToString();
            //textBoxCName.Text = jobs.customer.ToString();
            //cbOutlet.SelectedValue = outlet.Id;


        }

        private int TP { get; set; }
        //Assign values to all text boxes in the form

        private void LoadOutlet(int numb)
        {
            List<Outlet> getOutlet = JobInfoManager.GetOutlets(numb);
            getOutlet.Insert(0, new Outlet() { Id = -1, Name = "Plese select outlet"});
            cbOutlet.DataSource = getOutlet;
            cbOutlet.DisplayMember = "Name";
            cbOutlet.ValueMember = "Id";

        }

        public void SetText(object sender, EventArgs e)
        {
            LoadOutlet(0);
            MyEventArgs mag = new MyEventArgs();
            this.TP = mag.Temp;//save the identification
            if (this.TP == 1)//create
            {

            }
            else if (this.TP == 2)//update
            {
                JobInfo jobs =  mag.obj as JobInfo;
                Outlet outlet = mag.obj as Outlet;
                textBoxCarNo.Text = jobs.carNo.ToString();
                textBoxCName.Text = jobs.customer.ToString();
                cbOutlet.SelectedValue = outlet.Id;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //When it clicked should know is create or updata
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
