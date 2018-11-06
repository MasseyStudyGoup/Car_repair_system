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
            this.SuspendLayout();
            // 
            // textBoxCName
            // 
            this.textBoxCName.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCName.Location = new System.Drawing.Point(174, 122);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(176, 29);
            this.textBoxCName.TabIndex = 49;
            this.textBoxCName.TextChanged += new System.EventHandler(this.textBoxCName_TextChanged);
            // 
            // textBoxCarNo
            // 
            this.textBoxCarNo.Location = new System.Drawing.Point(174, 74);
            this.textBoxCarNo.Name = "textBoxCarNo";
            this.textBoxCarNo.Size = new System.Drawing.Size(176, 29);
            this.textBoxCarNo.TabIndex = 48;
            this.textBoxCarNo.TextChanged += new System.EventHandler(this.textBoxCarNo_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(174, 460);
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
            this.labelDescb.Location = new System.Drawing.Point(35, 245);
            this.labelDescb.Name = "labelDescb";
            this.labelDescb.Size = new System.Drawing.Size(127, 21);
            this.labelDescb.TabIndex = 46;
            this.labelDescb.Text = "Job Description";
            // 
            // jobDes
            // 
            this.jobDes.Location = new System.Drawing.Point(174, 242);
            this.jobDes.Margin = new System.Windows.Forms.Padding(5);
            this.jobDes.Multiline = true;
            this.jobDes.Name = "jobDes";
            this.jobDes.Size = new System.Drawing.Size(379, 151);
            this.jobDes.TabIndex = 31;
       
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(63, 183);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(46, 21);
            this.labelType.TabIndex = 41;
            this.labelType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(174, 180);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(226, 29);
            this.cbType.TabIndex = 38;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(63, 122);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 21);
            this.labelName.TabIndex = 34;
            this.labelName.Text = "Name";
            // 
            // labelCarNo
            // 
            this.labelCarNo.AutoSize = true;
            this.labelCarNo.Location = new System.Drawing.Point(63, 74);
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
            // addJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 580);
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
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "addJob";
            this.Text = "addJob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBoxCarNo_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBoxCName_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
    }
}