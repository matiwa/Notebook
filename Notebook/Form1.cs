using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Notebook
{
    public partial class frmNotatnik : Form
    {
        private string plik = "";

        public frmNotatnik()
        {
            InitializeComponent();
        }

        private DialogResult Czyzapisac()
        {
            DialogResult odp = MessageBox.Show("Do you want to save your changes?", "Notebook",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (odp == DialogResult.Yes)
                MSave_Click(null, null);
            return odp;
        }

        private void MNowy_Click(object sender, EventArgs e)
        {
            if (TxtTresc.Text != "")
            {
                DialogResult odp = Czyzapisac();
                if (odp == DialogResult.Cancel)
                    return;
                plik = "";
                TxtTresc.Clear();
            }
        }

        private void MOpen_Click(object sender, EventArgs e)
        {
            if (TxtTresc.Text != "")
            {
                DialogResult odp = Czyzapisac();
                if (odp == DialogResult.Cancel)
                    return;
                plik = "";
                TxtTresc.Clear();
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text file (*.txt)|*.txt";
            dialog.Multiselect = false;
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                plik = dialog.FileName;
                StreamReader f = new StreamReader(plik);
                TxtTresc.Text = f.ReadToEnd();
                f.Close();
            }
        }

        private void MSave_Click(object sender, EventArgs e)
        {
            if (plik != "")
            {
                StreamWriter f = new StreamWriter(plik);
                f.Write(TxtTresc.Text);
                f.Close();
            }
            else MSaveAs_Click(sender, e);
        }

        private void MSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text file (*.txt)|*.txt";
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                plik = dialog.FileName;
                StreamWriter f = new StreamWriter(plik);
                f.Write(TxtTresc.Text);
                f.Close();
            }
        }

        private void frmNotatnik_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TxtTresc.Text != "")
            {
                DialogResult odp = Czyzapisac();
                if (odp == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}
