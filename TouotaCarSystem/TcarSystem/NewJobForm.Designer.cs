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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.labelCarNo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOutlet = new System.Windows.Forms.Label();
            this.cbOutlet = new System.Windows.Forms.ComboBox();
            this.gbJobDes = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelWorker = new System.Windows.Forms.Label();
            this.cbworker = new System.Windows.Forms.ComboBox();
            this.labelDescb = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.textBoxCarNo = new System.Windows.Forms.TextBox();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // jobDes
            // 
            this.jobDes.Location = new System.Drawing.Point(151, 427);
            this.jobDes.Margin = new System.Windows.Forms.Padding(5);
            this.jobDes.Multiline = true;
            this.jobDes.Name = "jobDes";
            this.jobDes.Size = new System.Drawing.Size(379, 151);
            this.jobDes.TabIndex = 0;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(520, 611);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(138, 45);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // labelCarNo
            // 
            this.labelCarNo.AutoSize = true;
            this.labelCarNo.Location = new System.Drawing.Point(40, 61);
            this.labelCarNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCarNo.Name = "labelCarNo";
            this.labelCarNo.Size = new System.Drawing.Size(67, 21);
            this.labelCarNo.TabIndex = 12;
            this.labelCarNo.Text = "Car NO";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(40, 109);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 21);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name";
            // 
            // labelOutlet
            // 
            this.labelOutlet.AutoSize = true;
            this.labelOutlet.Location = new System.Drawing.Point(40, 160);
            this.labelOutlet.Name = "labelOutlet";
            this.labelOutlet.Size = new System.Drawing.Size(58, 21);
            this.labelOutlet.TabIndex = 16;
            this.labelOutlet.Text = "Outlet";
            // 
            // cbOutlet
            // 
            this.cbOutlet.FormattingEnabled = true;
            this.cbOutlet.Location = new System.Drawing.Point(151, 152);
            this.cbOutlet.Name = "cbOutlet";
            this.cbOutlet.Size = new System.Drawing.Size(226, 29);
            this.cbOutlet.TabIndex = 17;
            // 
            // gbJobDes
            // 
            this.gbJobDes.Location = new System.Drawing.Point(574, 27);
            this.gbJobDes.Name = "gbJobDes";
            this.gbJobDes.Size = new System.Drawing.Size(430, 551);
            this.gbJobDes.TabIndex = 18;
            this.gbJobDes.TabStop = false;
            this.gbJobDes.Text = "Job History";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(151, 257);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(226, 29);
            this.cbType.TabIndex = 19;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(151, 314);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(226, 29);
            this.cbStatus.TabIndex = 20;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(151, 203);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(226, 29);
            this.cbPriority.TabIndex = 21;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(40, 260);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(46, 21);
            this.labelType.TabIndex = 22;
            this.labelType.Text = "Type";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(41, 322);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(57, 21);
            this.labelStatus.TabIndex = 23;
            this.labelStatus.Text = "Status";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(40, 211);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(64, 21);
            this.labelPriority.TabIndex = 24;
            this.labelPriority.Text = "Priority";
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(40, 378);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(66, 21);
            this.labelWorker.TabIndex = 26;
            this.labelWorker.Text = "Worker";
            // 
            // cbworker
            // 
            this.cbworker.FormattingEnabled = true;
            this.cbworker.Location = new System.Drawing.Point(151, 370);
            this.cbworker.Name = "cbworker";
            this.cbworker.Size = new System.Drawing.Size(226, 29);
            this.cbworker.TabIndex = 25;
            // 
            // labelDescb
            // 
            this.labelDescb.AutoSize = true;
            this.labelDescb.Location = new System.Drawing.Point(12, 430);
            this.labelDescb.Name = "labelDescb";
            this.labelDescb.Size = new System.Drawing.Size(127, 21);
            this.labelDescb.TabIndex = 27;
            this.labelDescb.Text = "Job Description";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(300, 611);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(138, 45);
            this.btn_cancel.TabIndex = 28;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // textBoxCarNo
            // 
            this.textBoxCarNo.Location = new System.Drawing.Point(151, 61);
            this.textBoxCarNo.Name = "textBoxCarNo";
            this.textBoxCarNo.Size = new System.Drawing.Size(176, 29);
            this.textBoxCarNo.TabIndex = 29;
            // 
            // textBoxCName
            // 
            this.textBoxCName.Location = new System.Drawing.Point(151, 109);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(176, 29);
            this.textBoxCName.TabIndex = 30;
            this.textBoxCName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NewJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 670);
            this.Controls.Add(this.textBoxCName);
            this.Controls.Add(this.textBoxCarNo);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.labelDescb);
            this.Controls.Add(this.jobDes);
            this.Controls.Add(this.labelWorker);
            this.Controls.Add(this.cbworker);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.gbJobDes);
            this.Controls.Add(this.cbOutlet);
            this.Controls.Add(this.labelOutlet);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCarNo);
            this.Controls.Add(this.btn_Submit);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewJobForm";
            this.Text = "NewJobForm";
            this.Load += new System.EventHandler(this.NewJobForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jobDes;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label labelCarNo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOutlet;
        private System.Windows.Forms.ComboBox cbOutlet;
        private System.Windows.Forms.GroupBox gbJobDes;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.ComboBox cbworker;
        private System.Windows.Forms.Label labelDescb;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox textBoxCarNo;
        private System.Windows.Forms.TextBox textBoxCName;
    }
}