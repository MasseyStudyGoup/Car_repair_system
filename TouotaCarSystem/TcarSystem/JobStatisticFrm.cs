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
    public partial class JobStatisticFrm : Form

    {

        public JobStatisticFrm(IList<JobStatistic> jobstatus)
        {
            InitializeComponent();
            btn_Close.DialogResult = DialogResult.Cancel;

            int jobt = 0;
            int woknb = 0;
            foreach (JobStatistic js in jobstatus)
            {
                dgStatistic.Rows.Add(new string[]
                {
                    js.Worker.UserName.ToString(),
                    js.ClosedJob.ToString()
                });
                jobt += js.ClosedJob;
                woknb += js.Worker.UserId;//need adjust
            }

            labelTotalJob.Text = "Total job " + jobt +"Unsolved job " + woknb;
        }

        private void JobStatistic_Load(object sender, EventArgs e)
        {

        }

        
    }
}
