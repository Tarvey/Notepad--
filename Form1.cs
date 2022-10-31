using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad__
{
    public partial class Form1 : Form
    {
        private string fucktext;
        private string filename;
        private string cmdcom;
        private int i;
        private int c;
        public string dir;
        


        public Form1()
        {
            InitializeComponent();
            dir = @"%USERPROFILE%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            fucktext = fastColoredTextBox1.Text;
            filename = textBox1.Text;
            cmdcom = "echo " + fucktext + " > " + filename;
            i = fastColoredTextBox1.LinesCount;

            // Create a string array with the lines of text
            string[] lines = { fastColoredTextBox1.Text };
            string docPath = dir;

            // Set a variable to the Documents path.
            

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, filename)))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            };
            

        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var loadedText = File.ReadAllText(ofd.FileName);
                fastColoredTextBox1.Text = loadedText;
            }
        }
    }
}
