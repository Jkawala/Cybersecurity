using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encrypt.Model.Engine;
using System.IO;
namespace Encrypt
{
    public partial class FullScan : Form
    {
        

        public FullScan()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //this will clear all the cookies created by the page.

            this.Hide(); // Hide the current form.

            Main f2 = new Main();

            f2.Show();
        }

        private void FullScan_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string directoryPath = @"C:\MyDirectory"; // replace with your directory path
            //string fileExtension = ".txt"; // replace with your file extension

            //string[] files = Directory.GetFiles(directoryPath, "*" + fileExtension, SearchOption.AllDirectories);

            //foreach (string file in files)
            //{
            //  Console.WriteLine(file);
            //}

            //MessageBox.Show("File search complete!"); // Show a message when the search is complete
            MessageBox.Show(@"The specified folder does not exist.", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
