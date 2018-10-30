namespace TcarSystem
{
    partial class NewJobForm
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
            this.jobDes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listCus = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // jobDes
            // 
            this.jobDes.Location = new System.Drawing.Point(41, 37);
            this.jobDes.Multiline = true;
            this.jobDes.Name = "jobDes";
            this.jobDes.Size = new System.Drawing.Size(122, 84);
            this.jobDes.TabIndex = 0;
            this.jobDes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Description";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "High",
            "Normal",
            "Low"});
            this.cbPriority.Location = new System.Drawing.Point(51, 150);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(111, 21);
            this.cbPriority.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Priority";
            // 
            // listCus
            // 
            this.listCus.FormattingEnabled = true;
            this.listCus.Location = new System.Drawing.Point(41, 195);
            this.listCus.Name = "listCus";
            this.listCus.Size = new System.Drawing.Size(120, 56);
            this.listCus.TabIndex = 4;
            // 
            // NewJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 311);
            this.Controls.Add(this.listCus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobDes);
            this.Name = "NewJobForm";
            this.Text = "NewJobForm";
            this.Load += new System.EventHandler(this.NewJobForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jobDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCus;
    }
}