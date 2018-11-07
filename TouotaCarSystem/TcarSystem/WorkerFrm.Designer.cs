namespace TcarSystem
{
    partial class WorkerFrm
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
            this.WorkJobList = new System.Windows.Forms.DataGridView();
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btn_Msearch = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WorkJobList)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkJobList
            // 
            this.WorkJobList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorkJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkJobList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.WorkJobList.Location = new System.Drawing.Point(2, 148);
            this.WorkJobList.Name = "WorkJobList";
            this.WorkJobList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WorkJobList.Size = new System.Drawing.Size(1214, 432);
            this.WorkJobList.TabIndex = 1;
            this.WorkJobList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkJobList_CellDoubleClick);
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
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(994, 23);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(81, 21);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Welcome";
            // 
            // btn_Msearch
            // 
            this.btn_Msearch.Location = new System.Drawing.Point(236, 91);
            this.btn_Msearch.Name = "btn_Msearch";
            this.btn_Msearch.Size = new System.Drawing.Size(116, 33);
            this.btn_Msearch.TabIndex = 8;
            this.btn_Msearch.Text = "Search";
            this.btn_Msearch.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(68, 91);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(132, 33);
            this.btClose.TabIndex = 9;
            this.btClose.Text = "Close a Job";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // WorkerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 584);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btn_Msearch);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.WorkJobList);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "WorkerFrm";
            this.Text = "WorkerFrm";
            this.Load += new System.EventHandler(this.WorkerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkJobList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WorkJobList;
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
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btn_Msearch;
        private System.Windows.Forms.Button btClose;
    }
}