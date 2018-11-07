namespace TcarSystem
{
    partial class closeJob
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
            this.btClose = new System.Windows.Forms.Button();
            this.txCName = new System.Windows.Forms.TextBox();
            this.txCarNo = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCarNo = new System.Windows.Forms.Label();
            this.txID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDescb = new System.Windows.Forms.Label();
            this.txDescrip = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(257, 489);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(113, 44);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // txCName
            // 
            this.txCName.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txCName.Location = new System.Drawing.Point(234, 129);
            this.txCName.Name = "txCName";
            this.txCName.ReadOnly = true;
            this.txCName.Size = new System.Drawing.Size(176, 29);
            this.txCName.TabIndex = 53;
            // 
            // txCarNo
            // 
            this.txCarNo.Location = new System.Drawing.Point(234, 91);
            this.txCarNo.Name = "txCarNo";
            this.txCarNo.ReadOnly = true;
            this.txCarNo.Size = new System.Drawing.Size(176, 21);
            this.txCarNo.TabIndex = 52;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(123, 139);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 12);
            this.labelName.TabIndex = 51;
            this.labelName.Text = "Name";
            // 
            // labelCarNo
            // 
            this.labelCarNo.AutoSize = true;
            this.labelCarNo.Location = new System.Drawing.Point(123, 91);
            this.labelCarNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCarNo.Name = "labelCarNo";
            this.labelCarNo.Size = new System.Drawing.Size(41, 12);
            this.labelCarNo.TabIndex = 50;
            this.labelCarNo.Text = "Car NO";
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(234, 48);
            this.txID.Name = "txID";
            this.txID.ReadOnly = true;
            this.txID.Size = new System.Drawing.Size(176, 21);
            this.txID.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 54;
            this.label1.Text = "Job Id";
            // 
            // labelDescb
            // 
            this.labelDescb.AutoSize = true;
            this.labelDescb.Location = new System.Drawing.Point(96, 223);
            this.labelDescb.Name = "labelDescb";
            this.labelDescb.Size = new System.Drawing.Size(95, 12);
            this.labelDescb.TabIndex = 59;
            this.labelDescb.Text = "Job Description";
            // 
            // txDescrip
            // 
            this.txDescrip.Location = new System.Drawing.Point(234, 220);
            this.txDescrip.Margin = new System.Windows.Forms.Padding(5);
            this.txDescrip.Multiline = true;
            this.txDescrip.Name = "txDescrip";
            this.txDescrip.ReadOnly = true;
            this.txDescrip.Size = new System.Drawing.Size(343, 106);
            this.txDescrip.TabIndex = 56;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(123, 177);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(29, 12);
            this.labelType.TabIndex = 58;
            this.labelType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(234, 174);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(226, 20);
            this.cbType.TabIndex = 57;
            // 
            // txComment
            // 
            this.txComment.Location = new System.Drawing.Point(234, 351);
            this.txComment.Margin = new System.Windows.Forms.Padding(5);
            this.txComment.Multiline = true;
            this.txComment.Name = "txComment";
            this.txComment.Size = new System.Drawing.Size(343, 106);
            this.txComment.TabIndex = 60;
            this.txComment.TextChanged += new System.EventHandler(this.txComment_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 61;
            this.label2.Text = "Comments";
            // 
            // closeJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 613);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txComment);
            this.Controls.Add(this.labelDescb);
            this.Controls.Add(this.txDescrip);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txCName);
            this.Controls.Add(this.txCarNo);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCarNo);
            this.Controls.Add(this.btClose);
            this.Name = "closeJob";
            this.Text = "closeJob";
            this.Load += new System.EventHandler(this.closeJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox txCName;
        private System.Windows.Forms.TextBox txCarNo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCarNo;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDescb;
        private System.Windows.Forms.TextBox txDescrip;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txComment;
        private System.Windows.Forms.Label label2;
    }
}