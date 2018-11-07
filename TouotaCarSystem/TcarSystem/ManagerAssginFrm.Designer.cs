namespace TcarSystem
{
    partial class ManagerAssginFrm
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
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelWoker = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.cbWoker = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(32, 90);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(64, 21);
            this.labelPriority.TabIndex = 0;
            this.labelPriority.Text = "Priority";
            // 
            // labelWoker
            // 
            this.labelWoker.AutoSize = true;
            this.labelWoker.Location = new System.Drawing.Point(32, 171);
            this.labelWoker.Name = "labelWoker";
            this.labelWoker.Size = new System.Drawing.Size(66, 21);
            this.labelWoker.TabIndex = 1;
            this.labelWoker.Text = "Worker";
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(142, 87);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(159, 29);
            this.cbPriority.TabIndex = 2;
            // 
            // cbWoker
            // 
            this.cbWoker.FormattingEnabled = true;
            this.cbWoker.Location = new System.Drawing.Point(142, 171);
            this.cbWoker.Name = "cbWoker";
            this.cbWoker.Size = new System.Drawing.Size(159, 29);
            this.cbWoker.TabIndex = 3;
            this.cbWoker.SelectedIndexChanged += new System.EventHandler(this.cbWoker_SelectedIndexChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(223, 275);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(99, 35);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(60, 275);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(99, 35);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ManagerAssginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 373);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cbWoker);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.labelWoker);
            this.Controls.Add(this.labelPriority);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerAssginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerAssginFrm";
            this.Load += new System.EventHandler(this.ManagerAssginFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelWoker;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.ComboBox cbWoker;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
    }
}