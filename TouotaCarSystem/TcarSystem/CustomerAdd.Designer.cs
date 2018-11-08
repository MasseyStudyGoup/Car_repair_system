namespace TcarSystem
{
    partial class CustomerAdd
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
            this.txCarNo = new System.Windows.Forms.TextBox();
            this.labelCarNo = new System.Windows.Forms.Label();
            this.labelDescb = new System.Windows.Forms.Label();
            this.txJobDes = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cbOutlet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txCarNo
            // 
            this.txCarNo.Location = new System.Drawing.Point(163, 36);
            this.txCarNo.Name = "txCarNo";
            this.txCarNo.Size = new System.Drawing.Size(176, 21);
            this.txCarNo.TabIndex = 50;
            // 
            // labelCarNo
            // 
            this.labelCarNo.AutoSize = true;
            this.labelCarNo.Location = new System.Drawing.Point(52, 36);
            this.labelCarNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCarNo.Name = "labelCarNo";
            this.labelCarNo.Size = new System.Drawing.Size(41, 12);
            this.labelCarNo.TabIndex = 49;
            this.labelCarNo.Text = "Car NO";
            // 
            // labelDescb
            // 
            this.labelDescb.AutoSize = true;
            this.labelDescb.Location = new System.Drawing.Point(24, 177);
            this.labelDescb.Name = "labelDescb";
            this.labelDescb.Size = new System.Drawing.Size(95, 12);
            this.labelDescb.TabIndex = 54;
            this.labelDescb.Text = "Job Description";
            // 
            // txJobDes
            // 
            this.txJobDes.Location = new System.Drawing.Point(163, 174);
            this.txJobDes.Margin = new System.Windows.Forms.Padding(5);
            this.txJobDes.Multiline = true;
            this.txJobDes.Name = "txJobDes";
            this.txJobDes.Size = new System.Drawing.Size(379, 140);
            this.txJobDes.TabIndex = 51;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(52, 120);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(29, 12);
            this.labelType.TabIndex = 53;
            this.labelType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(163, 117);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(226, 20);
            this.cbType.TabIndex = 52;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 55;
            this.label1.Text = "Outlet";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(120, 352);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(138, 42);
            this.btn_cancel.TabIndex = 58;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(370, 352);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(138, 42);
            this.btn_Submit.TabIndex = 57;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // cbOutlet
            // 
            this.cbOutlet.FormattingEnabled = true;
            this.cbOutlet.Location = new System.Drawing.Point(163, 75);
            this.cbOutlet.Name = "cbOutlet";
            this.cbOutlet.Size = new System.Drawing.Size(176, 20);
            this.cbOutlet.TabIndex = 59;
            this.cbOutlet.SelectedIndexChanged += new System.EventHandler(this.cbOutlet_SelectedIndexChanged);
            // 
            // CustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.cbOutlet);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDescb);
            this.Controls.Add(this.txJobDes);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txCarNo);
            this.Controls.Add(this.labelCarNo);
            this.Name = "CustomerAdd";
            this.Text = "CustomerAdd";
            this.Load += new System.EventHandler(this.CustomerAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txCarNo;
        private System.Windows.Forms.Label labelCarNo;
        private System.Windows.Forms.Label labelDescb;
        private System.Windows.Forms.TextBox txJobDes;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ComboBox cbOutlet;
    }
}