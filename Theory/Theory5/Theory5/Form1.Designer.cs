namespace Theory5
{
    partial class Form1
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
            this.lbReceiver = new System.Windows.Forms.Label();
            this.lbSender = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.tbReceiver = new System.Windows.Forms.TextBox();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbTittle = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbAttcach = new System.Windows.Forms.TextBox();
            this.lbAttach = new System.Windows.Forms.Label();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbReceiver
            // 
            this.lbReceiver.AutoSize = true;
            this.lbReceiver.Location = new System.Drawing.Point(142, 77);
            this.lbReceiver.Name = "lbReceiver";
            this.lbReceiver.Size = new System.Drawing.Size(62, 16);
            this.lbReceiver.TabIndex = 0;
            this.lbReceiver.Text = "Receiver";
            // 
            // lbSender
            // 
            this.lbSender.AutoSize = true;
            this.lbSender.Location = new System.Drawing.Point(153, 114);
            this.lbSender.Name = "lbSender";
            this.lbSender.Size = new System.Drawing.Size(51, 16);
            this.lbSender.TabIndex = 1;
            this.lbSender.Text = "Sender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password of Sender Email";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Location = new System.Drawing.Point(152, 264);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(52, 16);
            this.lbContent.TabIndex = 3;
            this.lbContent.Text = "Content";
            // 
            // tbReceiver
            // 
            this.tbReceiver.Location = new System.Drawing.Point(236, 74);
            this.tbReceiver.Name = "tbReceiver";
            this.tbReceiver.Size = new System.Drawing.Size(304, 22);
            this.tbReceiver.TabIndex = 4;
            // 
            // tbSender
            // 
            this.tbSender.Location = new System.Drawing.Point(236, 108);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(304, 22);
            this.tbSender.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(236, 147);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(304, 22);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(236, 226);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(304, 137);
            this.tbContent.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(362, 442);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 31);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(465, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.Blue;
            this.lbTittle.Location = new System.Drawing.Point(279, 18);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(220, 29);
            this.lbTittle.TabIndex = 10;
            this.lbTittle.Text = "SEND AN EMAIL";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(152, 190);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(52, 16);
            this.lbSubject.TabIndex = 11;
            this.lbSubject.Text = "Subject";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(236, 184);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(304, 22);
            this.tbSubject.TabIndex = 12;
            // 
            // tbAttcach
            // 
            this.tbAttcach.Enabled = false;
            this.tbAttcach.Location = new System.Drawing.Point(236, 387);
            this.tbAttcach.Name = "tbAttcach";
            this.tbAttcach.ReadOnly = true;
            this.tbAttcach.Size = new System.Drawing.Size(225, 22);
            this.tbAttcach.TabIndex = 14;
            // 
            // lbAttach
            // 
            this.lbAttach.AutoSize = true;
            this.lbAttach.Location = new System.Drawing.Point(152, 393);
            this.lbAttach.Name = "lbAttach";
            this.lbAttach.Size = new System.Drawing.Size(44, 16);
            this.lbAttach.TabIndex = 13;
            this.lbAttach.Text = "Attach";
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.ImageKey = "(none)";
            this.btnAttachFile.Location = new System.Drawing.Point(468, 387);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(75, 30);
            this.btnAttachFile.TabIndex = 15;
            this.btnAttachFile.Text = "File";
            this.btnAttachFile.UseVisualStyleBackColor = true;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 495);
            this.Controls.Add(this.btnAttachFile);
            this.Controls.Add(this.tbAttcach);
            this.Controls.Add(this.lbAttach);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbSender);
            this.Controls.Add(this.tbReceiver);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSender);
            this.Controls.Add(this.lbReceiver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbReceiver;
        private System.Windows.Forms.Label lbSender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.TextBox tbReceiver;
        private System.Windows.Forms.TextBox tbSender;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbAttcach;
        private System.Windows.Forms.Label lbAttach;
        private System.Windows.Forms.Button btnAttachFile;
    }
}

