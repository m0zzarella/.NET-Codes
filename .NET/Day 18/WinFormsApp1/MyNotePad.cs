using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class MyNotePad : Form
    {
        public MyNotePad()
        {
            InitializeComponent();
        }

        FileStream myFile;
        StreamReader read;
        StreamWriter write;



        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void opnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            myFile = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
            write = new StreamWriter(myFile);
            write.WriteLine(richTextBox1.Text);




        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
