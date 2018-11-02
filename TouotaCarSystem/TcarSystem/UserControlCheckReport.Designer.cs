namespace TcarSystem
{
    partial class UserControlCheckReport
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCheckReport = new System.Windows.Forms.Label();
            this.dataGridUserCheckReport = new System.Windows.Forms.DataGridView();
            this.jobid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outletna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserCheckReport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCheckReport
            // 
            this.labelCheckReport.AutoSize = true;
            this.labelCheckReport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCheckReport.Location = new System.Drawing.Point(3, 10);
            this.labelCheckReport.Name = "labelCheckReport";
            this.labelCheckReport.Size = new System.Drawing.Size(193, 21);
            this.labelCheckReport.TabIndex = 0;
            this.labelCheckReport.Text = "Check Car Repair Status";
            // 
            // dataGridUserCheckReport
            // 
            this.dataGridUserCheckReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUserCheckReport.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridUserCheckReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUserCheckReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobid,
            this.carno,
            this.customer,
            this.outletna,
            this.createdate,
            this.closedate,
            this.jobstatus,
            this.comment});
            this.dataGridUserCheckReport.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridUserCheckReport.Location = new System.Drawing.Point(3, 34);
            this.dataGridUserCheckReport.Name = "dataGridUserCheckReport";
            this.dataGridUserCheckReport.RowTemplate.Height = 23;
            this.dataGridUserCheckReport.Size = new System.Drawing.Size(705, 328);
            this.dataGridUserCheckReport.TabIndex = 1;
            this.dataGridUserCheckReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUserCheckReport_CellContentClick);
            // 
            // jobid
            // 
            this.jobid.HeaderText = "Job ID";
            this.jobid.Name = "jobid";
            // 
            // carno
            // 
            this.carno.HeaderText = "Car NO";
            this.carno.Name = "carno";
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer Name";
            this.customer.Name = "customer";
            // 
            // outletna
            // 
            this.outletna.HeaderText = "Outlet Name";
            this.outletna.Name = "outletna";
            // 
            // createdate
            // 
            this.createdate.HeaderText = "Create Date";
            this.createdate.Name = "createdate";
            // 
            // closedate
            // 
            this.closedate.HeaderText = "Close Date";
            this.closedate.Name = "closedate";
            // 
            // jobstatus
            // 
            this.jobstatus.HeaderText = "Job Status";
            this.jobstatus.Name = "jobstatus";
            // 
            // comment
            // 
            this.comment.HeaderText = "Comment";
            this.comment.Name = "comment";
            // 
            // UserControlCheckReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dataGridUserCheckReport);
            this.Controls.Add(this.labelCheckReport);
            this.Name = "UserControlCheckReport";
            this.Size = new System.Drawing.Size(732, 362);
            this.Load += new System.EventHandler(this.UserControlCheckReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserCheckReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCheckReport;
        private System.Windows.Forms.DataGridView dataGridUserCheckReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobid;
        private System.Windows.Forms.DataGridViewTextBoxColumn carno;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn outletna;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn closedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
    }
}
