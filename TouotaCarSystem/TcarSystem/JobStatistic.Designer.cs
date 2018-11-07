namespace TcarSystem
{
    partial class JobStatistic
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unsolveJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTotalJob = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.worker,
            this.unsolveJob});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 83);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(652, 479);
            this.dataGridView1.TabIndex = 0;
            // 
            // worker
            // 
            this.worker.HeaderText = "Worker";
            this.worker.Name = "worker";
            // 
            // unsolveJob
            // 
            this.unsolveJob.HeaderText = "Unsolve Job";
            this.unsolveJob.Name = "unsolveJob";
            // 
            // labelTotalJob
            // 
            this.labelTotalJob.AutoSize = true;
            this.labelTotalJob.Location = new System.Drawing.Point(12, 35);
            this.labelTotalJob.Name = "labelTotalJob";
            this.labelTotalJob.Size = new System.Drawing.Size(81, 21);
            this.labelTotalJob.TabIndex = 1;
            this.labelTotalJob.Text = "Totail job";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(537, 30);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(89, 31);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // JobStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 561);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.labelTotalJob);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "JobStatistic";
            this.Text = "JobStatistic";
            this.Load += new System.EventHandler(this.JobStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn unsolveJob;
        private System.Windows.Forms.Label labelTotalJob;
        private System.Windows.Forms.Button btn_Close;
    }
}