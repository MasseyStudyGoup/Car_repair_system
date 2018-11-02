using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcarSystem.Model;
using TcarSystem.BLL;

namespace TcarSystem
{
    public partial class UserControlCheckReport : UserControl
    {
        public UserControlCheckReport()
        {
            InitializeComponent();
        }

        private void DataGridUserCheckReport_load(object sender, DataGridViewCellEventArgs e)
        {
            //data gride
            IList<JobInfo> jobreports = JobInfoManager.GetAllJobInfos();

            if (jobreports != null)
            {
                foreach (JobInfo jobreport in jobreports)
                {
                    dataGridUserCheckReport.Rows.Add(new string[] {
                            jobreport.id,
                            jobreport.carNo,
                            jobreport.customer.UserName,
                            jobreport.outlet.Name,
                            jobreport.createdate.ToString(),
                            jobreport.closedate.ToString(),
                            jobreport.jobStatus.ToString(),
                            jobreport.comment
                    });
                }
            }
        }



        private void dataGridUserCheckReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
