using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Nikola_Milanovic_S13_18_3S2
{
    public partial class frmWindow : Form
    {


        public frmWindow()
        {
            InitializeComponent();

        }

        private void CloseAppOnEsc_KeyPress(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ocurred:  prilikom zatvaranja aplikacije! Greška: " + ex.ToString(), "Greška prilikom zatvaranja aplikacije", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmDomaci_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Nikola Milanovic S13/18 3S2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ocurred during changing text: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string readTextFromFile(string filename)
        {
            try
            {
                StreamReader readFile = new StreamReader(filename);
                string fileText = readFile.ReadToEnd();
                return fileText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ocurred during reading the text: " + ex.ToString(), "Read error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return String.Empty;
            }
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                ofDialog.Title = "Otvorite fajl";
                ofDialog.Filter = "Text files (.txt)|*.txt|CSV files (.csv)|*.csv";

                if (ofDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                string filename = ofDialog.FileName;
                txbMultiLine.Text = readTextFromFile(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ocurred during reading text: " + ex.ToString(), "Read error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private bool saveFileAs(string filename, string content)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename);
                sw.Write(content);
                sw.Flush();
                sw.Close();
                MessageBox.Show("File saved!", "Info", MessageBoxButtons.OK);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ocurred during saving the file:  " + ex.ToString(), "Read error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                dlgSave.Title = "Save file";
                dlgSave.DefaultExt = "txt";
                //dlgSave.InitialDirectory = @"C:\Users\Sif\Desktop\C# Domaci";
                dlgSave.Filter = "Text files|*.txt|CSV files|*.csv";
                if (dlgSave.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                string nameFile = dlgSave.FileName;
                string fileText = txbMultiLine.Text;
                saveFileAs(nameFile, fileText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ocurred during opening the save file dialog:  " + ex.ToString(), "Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFindReplace_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbMultiLine.Text == String.Empty || txbFind.Text == String.Empty || txbReplace.Text == String.Empty)
                {
                    MessageBox.Show("Error ocurred during replacing the word! Please make sure to enter text in both fields and try again.", "Replace error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string find = txbFind.Text;
                string replace = txbReplace.Text;
                string fileText = txbMultiLine.Text;
                if (!fileText.Contains(find))
                {
                    MessageBox.Show("Word not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                fileText = fileText.Replace(find, replace);
                txbMultiLine.Text = fileText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ocurred during replacing the requested word: " + ex.ToString(), "Find & Replace error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error ocurred during exiting the program: " + ex.ToString(), "Exit error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
