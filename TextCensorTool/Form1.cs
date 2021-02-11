using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

// created by Paul Cooper on February 11th, 2021

namespace TextCensorTool
{
    public partial class Form1 : Form
    {
        string original;
        string originalCensored;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                StreamReader textStream = new StreamReader(openFileDialog1.FileName);

                original = textStream.ReadToEnd();
                originalCensored = original;

                originalText.Text = original;
                censoredText.Text = originalCensored;

                useNewBtn.Enabled = true;
                censoredText.Enabled = true;
                CensorBtn.Enabled = true;
                itemToCensorTxt.Enabled = true;
                saveFileBtn.Enabled = true;
                resetBtn.Enabled = true;
            }

        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Save your censored text";
            saveFileDialog1.DefaultExt = ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());

                writer.Write(censoredText.Text);

                writer.Close();

            }
        }

        private void CensorBtn_Click(object sender, EventArgs e)
        {
            censoredText.Text = "";
            originalCensored = originalCensored.Replace(itemToCensorTxt.Text, blackBarRadio.Checked ? "██████" : "*REDACTED*");
            censoredText.Text = originalCensored;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            var confirmReset = MessageBox.Show("Are you sure you want to reset back to the Original text?", "Reset", MessageBoxButtons.YesNo);
            if (confirmReset == DialogResult.Yes) {
                originalText.Text = original;
                censoredText.Text = originalCensored;
            }
        }

        private void useNewBtn_Click(object sender, EventArgs e)
        {
            
            original = originalText.Text;
            originalCensored = original;
            censoredText.Text = "";
            originalText.Text = "";

            originalText.Text = original;
            censoredText.Text = originalCensored;

            useNewBtn.Enabled = true;
            censoredText.Enabled = true;
            CensorBtn.Enabled = true;
            itemToCensorTxt.Enabled = true;
            saveFileBtn.Enabled = true;
            resetBtn.Enabled = true;
        }
    }
}
