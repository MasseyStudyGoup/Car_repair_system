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
            this.jobId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deskJobList)).BeginInit();
            this.SuspendLayout();
            // 
            // deskJobList
            // 
            this.deskJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deskJobList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobId,
            this.CarNo});
            this.deskJobList.Location = new System.Drawing.Point(13, 73);
            this.deskJobList.Name = "deskJobList";
            this.deskJobList.Size = new System.Drawing.Size(973, 232);
            this.deskJobList.TabIndex = 0;
            this.deskJobList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deskJobList_CellContentClick);
            // 
            // jobId
            // 
            this.jobId.HeaderText = "Job ID";
            this.jobId.Name = "jobId";
            // 
            // CarNo
            // 
            this.CarNo.HeaderText = "Car No";
            this.CarNo.Name = "CarNo";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New Job";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // helpDeskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 467);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.deskJobList);
            this.Name = "helpDeskForm";
            this.Text = "helpDeskForm";
            this.Load += new System.EventHandler(this.helpDeskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskJobList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deskJobList;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNo;
        private System.Windows.Forms.Button btnAdd;
    }
}