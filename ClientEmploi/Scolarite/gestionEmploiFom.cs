using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ClientEmploi
{
    public partial class gestionEmploiFom : Form
    {
        public gestionEmploiFom()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Title = "Select file";
                openDialog.InitialDirectory = @"c:\";
                openDialog.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                openDialog.FilterIndex = 1;
                openDialog.RestoreDirectory = true;
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openDialog.FileName != "")
                    {
                      String  strExcelPathName = openDialog.FileName;
                        MessageBox.Show(strExcelPathName);
                    }
                    else
                    {
                        MessageBox.Show("chose Excel sheet path..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
