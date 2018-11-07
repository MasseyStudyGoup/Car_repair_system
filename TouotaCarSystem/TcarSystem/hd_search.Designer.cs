namespace TcarSystem
{
    partial class hd_search
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
            this.dhSearcjJobList = new System.Windows.Forms.DataGridView();
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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbResolve = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hdSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dhSearcjJobList)).BeginInit();
            this.SuspendLayout();
            // 
            // dhSearcjJobList
            // 
            this.dhSearcjJobList.AllowUserToAddRows = false;
            this.dhSearcjJobList.AllowUserToDeleteRows = false;
            this.dhSearcjJobList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dhSearcjJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dhSearcjJobList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dhSearcjJobList.Location = new System.Drawing.Point(12, 121);
            this.dhSearcjJobList.Name = "dhSearcjJobList";
            this.dhSearcjJobList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dhSearcjJobList.Size = new System.Drawing.Size(1214, 432);
            this.dhSearcjJobList.TabIndex = 1;
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
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(126, 43);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(108, 20);
            this.cbStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "JobStatus";
            // 
            // cbResolve
            // 
            this.cbResolve.FormattingEnabled = true;
            this.cbResolve.Location = new System.Drawing.Point(381, 43);
            this.cbResolve.Name = "cbResolve";
            this.cbResolve.Size = new System.Drawing.Size(121, 20);
            this.cbResolve.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resolve";
            // 
            // hdSearch
            // 
            this.hdSearch.Location = new System.Drawing.Point(582, 43);
            this.hdSearch.Name = "hdSearch";
            this.hdSearch.Size = new System.Drawing.Size(75, 21);
            this.hdSearch.TabIndex = 6;
            this.hdSearch.Text = "Search";
            this.hdSearch.UseVisualStyleBackColor = true;
            this.hdSearch.Click += new System.EventHandler(this.hdSearch_Click);
            // 
            // hd_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 571);
            this.Controls.Add(this.hdSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbResolve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dhSearcjJobList);
            this.Name = "hd_search";
            this.Text = "hd_search";
            this.Load += new System.EventHandler(this.hd_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dhSearcjJobList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dhSearcjJobList;
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
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbResolve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hdSearch;
    }
}