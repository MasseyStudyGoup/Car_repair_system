namespace TcarSystem
{
    partial class ManagerFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.ManagerJobList = new System.Windows.Forms.DataGridView();
            this.JobId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobCus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDesk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Msearch = new System.Windows.Forms.Button();
            this.btnAssgin = new System.Windows.Forms.Button();
            this.btn_Jobstatistic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerJobList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(961, 22);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(81, 21);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Welcome";
            // 
            // ManagerJobList
            // 
            this.ManagerJobList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ManagerJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagerJobList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobId,
            this.CarNo,
            this.JobCus,
            this.outlet,
            this.workType,
            this.JobStatus,
            this.JobDes,
            this.JobDesk,
            this.JobRes,
            this.JobComment,
            this.JobCreate});
            this.ManagerJobList.Location = new System.Drawing.Point(2, 154);
            this.ManagerJobList.Name = "ManagerJobList";
            this.ManagerJobList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ManagerJobList.Size = new System.Drawing.Size(1214, 432);
            this.ManagerJobList.TabIndex = 3;
            // 
            // JobId
            // 
            this.JobId.HeaderText = "Job ID";
            this.JobId.Name = "JobId";
            // 
            // CarNo
            // 
            this.CarNo.HeaderText = "Car No";
            this.CarNo.Name = "CarNo";
            // 
            // JobCus
            // 
            this.JobCus.HeaderText = "Customer";
            this.JobCus.Name = "JobCus";
            // 
            // outlet
            // 
            this.outlet.HeaderText = "Outlets";
            this.outlet.Name = "outlet";
            // 
            // workType
            // 
            this.workType.HeaderText = "Type";
            this.workType.Name = "workType";
            // 
            // JobStatus
            // 
            this.JobStatus.HeaderText = "Status";
            this.JobStatus.Name = "JobStatus";
            // 
            // JobDes
            // 
            this.JobDes.HeaderText = "Description";
            this.JobDes.Name = "JobDes";
            // 
            // JobDesk
            // 
            this.JobDesk.HeaderText = "Desk";
            this.JobDesk.Name = "JobDesk";
            // 
            // JobRes
            // 
            this.JobRes.HeaderText = "Resolve";
            this.JobRes.Name = "JobRes";
            // 
            // JobComment
            // 
            this.JobComment.HeaderText = "Comment";
            this.JobComment.Name = "JobComment";
            // 
            // JobCreate
            // 
            this.JobCreate.HeaderText = "CreateDate";
            this.JobCreate.Name = "JobCreate";
            // 
            // btn_Msearch
            // 
            this.btn_Msearch.Location = new System.Drawing.Point(118, 60);
            this.btn_Msearch.Name = "btn_Msearch";
            this.btn_Msearch.Size = new System.Drawing.Size(86, 33);
            this.btn_Msearch.TabIndex = 6;
            this.btn_Msearch.Text = "Search";
            this.btn_Msearch.UseVisualStyleBackColor = true;
            this.btn_Msearch.Click += new System.EventHandler(this.btn_Msearch_Click);
            // 
            // btnAssgin
            // 
            this.btnAssgin.Location = new System.Drawing.Point(8, 60);
            this.btnAssgin.Name = "btnAssgin";
            this.btnAssgin.Size = new System.Drawing.Size(82, 33);
            this.btnAssgin.TabIndex = 5;
            this.btnAssgin.Text = "Assign";
            this.btnAssgin.UseVisualStyleBackColor = true;
            this.btnAssgin.Click += new System.EventHandler(this.btnAssgin_Click);
            // 
            // btn_Jobstatistic
            // 
            this.btn_Jobstatistic.Location = new System.Drawing.Point(246, 60);
            this.btn_Jobstatistic.Name = "btn_Jobstatistic";
            this.btn_Jobstatistic.Size = new System.Drawing.Size(108, 33);
            this.btn_Jobstatistic.TabIndex = 7;
            this.btn_Jobstatistic.Text = "Job Statistic";
            this.btn_Jobstatistic.UseVisualStyleBackColor = true;
            this.btn_Jobstatistic.Click += new System.EventHandler(this.btn_Jobstatistic_Click);
            // 
            // ManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 587);
            this.Controls.Add(this.btn_Jobstatistic);
            this.Controls.Add(this.btn_Msearch);
            this.Controls.Add(this.btnAssgin);
            this.Controls.Add(this.ManagerJobList);
            this.Controls.Add(this.labelWelcome);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManagerFrm";
            this.Text = "ManagerFrm";
            this.Load += new System.EventHandler(this.ManagerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManagerJobList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.DataGridView ManagerJobList;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobCus;
        private System.Windows.Forms.DataGridViewTextBoxColumn outlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn workType;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDesk;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobCreate;
        private System.Windows.Forms.Button btn_Msearch;
        private System.Windows.Forms.Button btnAssgin;
        private System.Windows.Forms.Button btn_Jobstatistic;
    }
}