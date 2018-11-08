namespace TcarSystem
{
    partial class ManagerSearchFrm
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_resolve = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbJobStatus = new System.Windows.Forms.ComboBox();
            this.MSearcjJobList = new System.Windows.Forms.DataGridView();
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbWoker = new System.Windows.Forms.ComboBox();
            this.btn_changeWoker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MSearcjJobList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(721, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(91, 33);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resolve";
            // 
            // cb_resolve
            // 
            this.cb_resolve.FormattingEnabled = true;
            this.cb_resolve.Location = new System.Drawing.Point(319, 27);
            this.cb_resolve.Name = "cb_resolve";
            this.cb_resolve.Size = new System.Drawing.Size(121, 29);
            this.cb_resolve.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "JobStatus";
            // 
            // cbJobStatus
            // 
            this.cbJobStatus.FormattingEnabled = true;
            this.cbJobStatus.Location = new System.Drawing.Point(101, 27);
            this.cbJobStatus.Name = "cbJobStatus";
            this.cbJobStatus.Size = new System.Drawing.Size(108, 29);
            this.cbJobStatus.TabIndex = 8;
            // 
            // MSearcjJobList
            // 
            this.MSearcjJobList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MSearcjJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MSearcjJobList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.MSearcjJobList.Location = new System.Drawing.Point(0, 90);
            this.MSearcjJobList.Name = "MSearcjJobList";
            this.MSearcjJobList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MSearcjJobList.Size = new System.Drawing.Size(1214, 468);
            this.MSearcjJobList.TabIndex = 7;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Woker";
            // 
            // cbWoker
            // 
            this.cbWoker.FormattingEnabled = true;
            this.cbWoker.Location = new System.Drawing.Point(545, 27);
            this.cbWoker.Name = "cbWoker";
            this.cbWoker.Size = new System.Drawing.Size(121, 29);
            this.cbWoker.TabIndex = 13;
            // 
            // btn_changeWoker
            // 
            this.btn_changeWoker.Location = new System.Drawing.Point(853, 23);
            this.btn_changeWoker.Name = "btn_changeWoker";
            this.btn_changeWoker.Size = new System.Drawing.Size(134, 33);
            this.btn_changeWoker.TabIndex = 15;
            this.btn_changeWoker.Text = "Reassgin Woker";
            this.btn_changeWoker.UseVisualStyleBackColor = true;
            this.btn_changeWoker.Click += new System.EventHandler(this.btn_changeWoker_Click);
            // 
            // ManagerSearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 560);
            this.Controls.Add(this.btn_changeWoker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbWoker);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_resolve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJobStatus);
            this.Controls.Add(this.MSearcjJobList);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManagerSearchFrm";
            this.Text = "ManagerSearchFrm";
            this.Load += new System.EventHandler(this.ManagerSearchFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MSearcjJobList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_resolve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbJobStatus;
        private System.Windows.Forms.DataGridView MSearcjJobList;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbWoker;
        private System.Windows.Forms.Button btn_changeWoker;
    }
}