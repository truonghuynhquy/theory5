using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Theory5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string from, to, pass, content, subject, fileAttach;
            from = tbSender.Text.Trim();
            to = tbReceiver.Text.Trim();
            pass = tbPassword.Text.Trim();
            subject = tbSubject.Text.Trim();    
            content = tbContent.Text;
            fileAttach = tbAttcach.Text;

            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Subject = subject;
            mailMessage.Body = content;

            if (File.Exists(fileAttach))
            {
                Attachment attachment = new Attachment(fileAttach);
                mailMessage.Attachments.Add(attachment);
            }

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(mailMessage);
                MessageBox.Show("Email sent succesfully.","Email",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All File()|*.*";

            if( openFileDialog.ShowDialog() == DialogResult.OK)
                tbAttcach.Text = openFileDialog.FileName;
        }
    }
}
