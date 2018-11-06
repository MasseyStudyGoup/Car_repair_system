namespace TcarSystem
{
    partial class helpDeskForm
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
        //
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deskJobList = new System.Windows.Forms.DataGridView();
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdataJob = new System.Windows.Forms.Button();
            this.hd_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deskJobList)).BeginInit();
            this.SuspendLayout();
            // 
            // deskJobList
            // 
            this.deskJobList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deskJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deskJobList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.deskJobList.Location = new System.Drawing.Point(13, 98);
            this.deskJobList.Name = "deskJobList";
            this.deskJobList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deskJobList.Size = new System.Drawing.Size(1214, 468);
            this.deskJobList.TabIndex = 0;
       
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdataJob
            // 
            this.btnUpdataJob.Location = new System.Drawing.Point(134, 35);
            this.btnUpdataJob.Name = "btnUpdataJob";
            this.btnUpdataJob.Size = new System.Drawing.Size(82, 33);
            this.btnUpdataJob.TabIndex = 2;
            this.btnUpdataJob.Text = "Modify";
            this.btnUpdataJob.UseVisualStyleBackColor = true;
            this.btnUpdataJob.Click += new System.EventHandler(this.btnUpdataJob_Click);
            // 
            // hd_search
            // 
            this.hd_search.Location = new System.Drawing.Point(244, 35);
            this.hd_search.Name = "hd_search";
            this.hd_search.Size = new System.Drawing.Size(86, 33);
            this.hd_search.TabIndex = 3;
            this.hd_search.Text = "Search";
            this.hd_search.UseVisualStyleBackColor = true;
            this.hd_search.Click += new System.EventHandler(this.hd_search_Click);
            // 
            // helpDeskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 606);
            this.Controls.Add(this.hd_search);
            this.Controls.Add(this.btnUpdataJob);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.deskJobList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "helpDeskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "helpDeskForm";
            this.Load += new System.EventHandler(this.helpDeskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskJobList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deskJobList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdataJob;
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
        private System.Windows.Forms.Button hd_search;
    }
}