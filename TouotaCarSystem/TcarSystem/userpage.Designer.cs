namespace TcarSystem
{
    partial class userpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userpage));
            this.btn_checkStatus = new System.Windows.Forms.Button();
            this.btn_addReport = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.userControlAddReport1 = new TcarSystem.UserControlAddReport();
            this.userControlCheckReport1 = new TcarSystem.UserControlCheckReport();
            this.SuspendLayout();
            // 
            // btn_checkStatus
            // 
            this.btn_checkStatus.Location = new System.Drawing.Point(31, 187);
            this.btn_checkStatus.Name = "btn_checkStatus";
            this.btn_checkStatus.Size = new System.Drawing.Size(153, 55);
            this.btn_checkStatus.TabIndex = 0;
            this.btn_checkStatus.Text = "Check Car Status";
            this.btn_checkStatus.UseVisualStyleBackColor = true;
            this.btn_checkStatus.Click += new System.EventHandler(this.btn_checkStatus_Click);
            // 
            // btn_addReport
            // 
            this.btn_addReport.Location = new System.Drawing.Point(31, 299);
            this.btn_addReport.Name = "btn_addReport";
            this.btn_addReport.Size = new System.Drawing.Size(153, 50);
            this.btn_addReport.TabIndex = 1;
            this.btn_addReport.Text = "Add Report";
            this.btn_addReport.UseVisualStyleBackColor = true;
            this.btn_addReport.Click += new System.EventHandler(this.btn_addReport_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(31, 414);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(153, 48);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(27, 26);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(69, 21);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "welcom";
            // 
            // userControlAddReport1
            // 
            this.userControlAddReport1.Location = new System.Drawing.Point(192, 44);
            this.userControlAddReport1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlAddReport1.Name = "userControlAddReport1";
            this.userControlAddReport1.Size = new System.Drawing.Size(1232, 653);
            this.userControlAddReport1.TabIndex = 4;
            // 
            // userControlCheckReport1
            // 
            this.userControlCheckReport1.AutoScroll = true;
            this.userControlCheckReport1.AutoSize = true;
            this.userControlCheckReport1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControlCheckReport1.Location = new System.Drawing.Point(206, 58);
            this.userControlCheckReport1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlCheckReport1.Name = "userControlCheckReport1";
            this.userControlCheckReport1.Size = new System.Drawing.Size(1220, 639);
            this.userControlCheckReport1.TabIndex = 3;
            // 
            // userpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1438, 709);
            this.Controls.Add(this.labelWelcome);
//            this.Controls.Add(this.userControlAddReport1);
//            this.Controls.Add(this.userControlCheckReport1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_addReport);
            this.Controls.Add(this.btn_checkStatus);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "userpage";
            this.Text = "Welcome Toyota Car Repair Report System";

            this.Load += new System.EventHandler(this.userpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_checkStatus;
        private System.Windows.Forms.Button btn_addReport;
        private System.Windows.Forms.Button btn_exit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControlCheckReport userControlCheckReport1;
        private UserControlAddReport userControlAddReport1;
        private System.Windows.Forms.Label labelWelcome;
    }
}