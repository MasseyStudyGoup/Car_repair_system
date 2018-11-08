using System;

namespace TcarSystem
{
    partial class addJob
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
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.textBoxCarNo = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.labelDescb = new System.Windows.Forms.Label();
            this.jobDes = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCarNo = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cbOpen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbopen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCName
            // 
            this.textBoxCName.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCName.Location = new System.Drawing.Point(200, 91);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(176, 29);
            this.textBoxCName.TabIndex = 49;
           
            // 
            // textBoxCarNo
            // 
            this.textBoxCarNo.Location = new System.Drawing.Point(200, 43);
            this.textBoxCarNo.Name = "textBoxCarNo";
            this.textBoxCarNo.Size = new System.Drawing.Size(176, 29);
            this.textBoxCarNo.TabIndex = 48;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(144, 460);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(138, 45);
            this.btn_cancel.TabIndex = 47;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // labelDescb
            // 
            this.labelDescb.AutoSize = true;
            this.labelDescb.Location = new System.Drawing.Point(61, 214);
            this.labelDescb.Name = "labelDescb";
            this.labelDescb.Size = new System.Drawing.Size(127, 21);
            this.labelDescb.TabIndex = 46;
            this.labelDescb.Text = "Job Description";
            // 
            // jobDes
            // 
            this.jobDes.Location = new System.Drawing.Point(200, 211);
            this.jobDes.Margin = new System.Windows.Forms.Padding(5);
            this.jobDes.Multiline = true;
            this.jobDes.Name = "jobDes";
            this.jobDes.Size = new System.Drawing.Size(379, 151);
            this.jobDes.TabIndex = 31;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(89, 152);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(46, 21);
            this.labelType.TabIndex = 41;
            this.labelType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(200, 149);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(226, 29);
            this.cbType.TabIndex = 38;
            this.cbType.Text = "Please select a job type";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(89, 91);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 21);
            this.labelName.TabIndex = 34;
            this.labelName.Text = "Name";
            // 
            // labelCarNo
            // 
            this.labelCarNo.AutoSize = true;
            this.labelCarNo.Location = new System.Drawing.Point(89, 43);
            this.labelCarNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCarNo.Name = "labelCarNo";
            this.labelCarNo.Size = new System.Drawing.Size(67, 21);
            this.labelCarNo.TabIndex = 33;
            this.labelCarNo.Text = "Car NO";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(394, 460);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(138, 45);
            this.btn_Submit.TabIndex = 32;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // cbOpen
            // 
            this.cbOpen.FormattingEnabled = true;
            this.cbOpen.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.cbOpen.Location = new System.Drawing.Point(200, 386);
            this.cbOpen.Name = "cbOpen";
            this.cbOpen.Size = new System.Drawing.Size(226, 29);
            this.cbOpen.TabIndex = 50;
            this.cbOpen.Text = "Please select one option";
            this.cbOpen.VisibleChanged += new System.EventHandler(this.addJob_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 51;
            // 
            // lbopen
            // 
            this.lbopen.AutoSize = true;
            this.lbopen.Location = new System.Drawing.Point(91, 389);
            this.lbopen.Name = "lbopen";
            this.lbopen.Size = new System.Drawing.Size(67, 21);
            this.lbopen.TabIndex = 52;
            this.lbopen.Text = "Open it";
            this.lbopen.VisibleChanged += new System.EventHandler(this.addJob_Load);
            // 
            // addJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 580);
            this.Controls.Add(this.lbopen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOpen);
            this.Controls.Add(this.textBoxCName);
            this.Controls.Add(this.textBoxCarNo);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.labelDescb);
            this.Controls.Add(this.jobDes);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCarNo);
            this.Controls.Add(this.btn_Submit);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "addJob";
            this.Text = "addJob";
            this.Load += new System.EventHandler(this.addJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBoxCarNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCName_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCName;
        private System.Windows.Forms.TextBox textBoxCarNo;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label labelDescb;
        private System.Windows.Forms.TextBox jobDes;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCarNo;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ComboBox cbOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbopen;
    }
}