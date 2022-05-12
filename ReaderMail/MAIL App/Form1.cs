using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Limilabs;
using Limilabs.Mail;
using Limilabs.Client.IMAP;


namespace MAIL_App
{
    public partial class Form1 : Form
    {
        private Imap imap;
        private IMail imail;
        private DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            imap = new Imap();
            imap.Connect("imap.google.com",993);
            try
            {

                imap.Login(txtTaiKhoan.Text, txtMatkhau.Text);
                table = new DataTable(); ;
                table.Columns.Add("IDmail", typeof(string));
                table.Columns.Add("Subject", typeof(string));
                 
                MessageBox.Show("Dang nhap thanh cong");
            }
            catch
            {
                MessageBox.Show("Dang nhap that bai");
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imap.SelectInbox();
            List<long>uids = imap.SearchFlag(Flag.All);
            int i = int.Parse(txtSoThu.Text);
            if (i > uids.Count) i = uids.Count ;
            int j = 0;
            foreach (long uid in uids)
            {
                if (i < j)
                {
         
              
                    imail = new MailBuilder().CreateFromEml(imap.GetHeadersByUID(uid));
                    DataRow row = table.NewRow();
                    row["IDMail"] = uid.ToString();
                    row["Subject"] = imail.Subject;
                    table.Rows.Add(row);
                    table.AcceptChanges();
                    j++;
                }
                else
                    break;
            }
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (e.ColumnIndex == 0)
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    imail = new MailBuilder().CreateFromEml(imap.GetMessageByUID(long.Parse(id)));
                    richTextBox1.Text = imail.Text; 
                  }
            }
        }
    }
}
