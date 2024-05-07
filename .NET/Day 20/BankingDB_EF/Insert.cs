using BankingDB_EF;
using System.Security.AccessControl;

namespace BankingDB_EF
{
    public partial class Insert : Form
    {
        BankingDbEfContext db = new BankingDbEfContext();
        public Insert()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Delete 
        {

            var accToDelete = (from a in db.AccountsInfos
                               where a.AccNo == Convert.ToInt32(textBox1.Text)
                               select a).Single();

            if (accToDelete != null)
            {
                db.AccountsInfos.Remove(accToDelete);
                db.SaveChanges();
                MessageBox.Show("Account Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Account Not Found");
            }

        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  //add
        {
            AccountsInfo newAccobj = new AccountsInfo()
            {
                AccNo = Convert.ToInt32(textBox1.Text),
                AccName = textBox2.Text,
                AccType = comboBox1.Text,
                AccBalance = Convert.ToInt32(textBox3.Text),
                AccBranch = Convert.ToInt32(textBox4.Text),

            };
            if (radioButton1.Checked) { newAccobj.AccIsActive = true; }
            else { newAccobj.AccIsActive = false; }
            db.AccountsInfos.Add(newAccobj);

            MessageBox.Show("New Account is Inserted");
            db.SaveChanges();

        }

        private void button3_Click(object sender, EventArgs e) //Update Button
        {
            var accToUpdate = (from b in db.AccountsInfos
                               where b.AccNo == Convert.ToInt32(textBox1.Text)
                               select b).Single();

            if (accToUpdate != null)
            {

                accToUpdate.AccName = textBox2.Text;
                accToUpdate.AccType = comboBox1.Text;
                accToUpdate.AccBalance = Convert.ToInt32(textBox3.Text);
                accToUpdate.AccBranch = Convert.ToInt32(textBox4.Text);
                if (radioButton1.Checked)
                    accToUpdate.AccIsActive = true;
                else
                    accToUpdate.AccIsActive = false;
            }
            else { MessageBox.Show("Invalid Account Number"); }

            MessageBox.Show("Account Updated");
            db.SaveChanges();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
             try
            {
                var accToUpdate = (from b in db.AccountsInfos
                                   where b.AccNo == Convert.ToInt32(textBox1.Text)
                                   select b).Single();

                textBox2.Text = accToUpdate.AccName;
                comboBox1.Text = accToUpdate.AccType;
                textBox3.Text = accToUpdate.AccBalance.ToString();
                textBox4.Text = accToUpdate.AccBranch.ToString();
                if (accToUpdate.AccIsActive == true)
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;

            }
            catch(Exception es)
            {
                MessageBox.Show("Account Not Found");
            }
        }
    }
}