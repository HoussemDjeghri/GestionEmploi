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
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using EmploiDuTempsDLL;
using System.IO;
using System.Collections;
using Bunifu.Framework.UI;
using static ClientEmploi.CommunFuctions;
namespace ClientEmploi
{
    public partial class gestionEmploiFom : Form
    {
        IScolarite obj;
        NotificationClass notifObj;
        _Worksheet worksheet;
        public gestionEmploiFom(IScolarite obj)
        {
            this.obj = obj;
            notifObj = (NotificationClass)Activator.GetObject(typeof(NotificationClass), "tcp://localhost:1235/ObjNotification");

            InitializeComponent();
            this.ajouterNiveaux();



        }

        public _Worksheet Worksheet { get => worksheet; set => worksheet = value; }
        public _Worksheet Worksheet1 { get => worksheet; set => worksheet = value; }

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
                        String strExcelPathName = openDialog.FileName;
                        MessageBox.Show(strExcelPathName);

                        Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@strExcelPathName);
                        Worksheet = xlWorkbook.Sheets[1];



                        ///////////////////////////////////////////////////////////////////

                        Range xlRange = worksheet.UsedRange;
                        int rowCount = xlRange.Rows.Count;
                        int colCount = xlRange.Columns.Count;
                        //iterate over the rows and columns and print to the console as it appears in the file
                        //excel is not zero based!!

                        Dictionary<String, int> columns = new Dictionary<string, int>();

                        for (int j = 1; j <= colCount; j++)
                        {
                            if (xlRange.Cells[1, j] != null && xlRange.Cells[1, j].Value2 != null)
                                columns.Add(xlRange.Cells[1, j].Value2, j);
                        }

                        List<EmploiObj> emplois = new List<EmploiObj>();
                      
                        for (int i = 2; i <= rowCount; i++)
                        {

                            EmploiObj emp = new EmploiObj();
                            emp.id_en = Int32.Parse(xlRange.Cells[i, columns["Enseignant"]].Value2.ToString());
                            emp.id_creaneau = Int32.Parse(xlRange.Cells[i, columns["Creneau"]].Value2.ToString());
                            emp.salle = Int32.Parse(xlRange.Cells[i, columns["Salle"]].Value2.ToString());
                            emp.group = Int32.Parse(xlRange.Cells[i, columns["Groupe"]].Value2.ToString());
                            emp.section = Int32.Parse(xlRange.Cells[i, columns["Section"]].Value2.ToString());
                            emp.id_module = Int32.Parse(xlRange.Cells[i, columns["Module"]].Value2.ToString());

                            emplois.Add(emp);
                            
                        }



                      
                        ///////////////////////////////////////////////////////////
                        Boolean ajoute = obj.InsererEmploi(emplois);
                        this.ajouterNiveaux();

                        if (ajoute)
                        {

                            MessageBox.Show("Emploi ajouté avec succés");
                        }
                        else
                        {
                            MessageBox.Show("Emploi non ajouté");
                        }


                        //cleanup
                        GC.Collect();
                        GC.WaitForPendingFinalizers();

                        //rule of thumb for releasing com objects:
                        //  never use two dots, all COM objects must be referenced and released individually
                        //  ex: [somthing].[something].[something] is bad

                        //close and release
                        xlWorkbook.Close();
                        Marshal.ReleaseComObject(xlWorkbook);

                        //quit and release
                        xlApp.Quit();
                        Marshal.ReleaseComObject(xlApp);

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            AjouterSeanceForm2 emp = new AjouterSeanceForm2(obj);
            emp.ShowDialog();
        }

        private void niveauDrop_onItemSelected(object sender, EventArgs e)
        {
            this.ajouterSections();

            sectionDrop.Enabled = true;
        }

        private void ajouterNiveaux()
        {

            ArrayList niveaux = obj.acceder_Niveaux(loginForm.user.specialite);
            if (niveaux != null)
            {
                niveauDrop.Clear();
                foreach (String item in niveaux)
                {
                    switch (item)
                    {
                        case "1" :
                            niveauDrop.AddItem("1er License");
                            break;
                        case "2":
                            niveauDrop.AddItem("2éme License");
                            break;
                        case "3":
                            niveauDrop.AddItem("3éme License");
                            break;
                        case "4":
                            niveauDrop.AddItem("1er Master");
                            break;
                        case "5":
                            niveauDrop.AddItem("2éme Master");
                            break;
                    }
                    
                }



            }


        }
        private void ajouterSections()
        {
            int niveau=0;
            switch (niveauDrop.selectedValue)
            {
                case "1er License":  niveau = 1;    break;
                case "2éme License": niveau = 2; break;
                case "3éme License": niveau = 3; break;
                case "1er Master": niveau = 4; break;
                case "2éme Master": niveau = 5; break;
            }

            ArrayList sections = obj.acceder_Section_par_niveau(loginForm.user.specialite, niveau);
            if (sections != null)
            {
                sectionDrop.Clear();
                foreach (String item in sections)
                {

                    sectionDrop.AddItem("Section "+item);
                }




            }
        }

        private void sectionDrop_onItemSelected(object sender, EventArgs e)
        {


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.AfficherEmploi();

        }


           void signaler_Click(object sd, EventArgs ev, EmploiObj seance,IScolarite obj)
            {

              
                if (ModifierSeance.ShowBox(seance,obj))
                {

                    MessageBox.Show("Séance Modifiée");
                
                String notif = "La séance de " + seance.type + " du Module " + seance.module + " a changé";

                notifObj.OnEmploiChanged(seance.id_en, notif);

                this.AfficherEmploi();
                }
                else
                {

                    MessageBox.Show("Séance Non Modifiée");
                    

                }



            }

        private void AfficherEmploi()
        {
            String[] temp = sectionDrop.selectedValue.Split(' ');

            int niveau = 0;
            switch (niveauDrop.selectedValue)
            {
                case "1er License": niveau = 1; break;
                case "2éme License": niveau = 2; break;
                case "3éme License": niveau = 3; break;
                case "1er Master": niveau = 4; break;
                case "2éme Master": niveau = 5; break;
            }

            ArrayList emploi = obj.acceder_emploi(loginForm.user.specialite, niveau, Int32.Parse(temp[temp.Length-1]));
            ViderEmploi(emploiPanel);
            for (int ligne = 1; ligne <= 5; ligne++)
            {

                for (int colomne = 1; colomne <= 5; colomne++)
                {
                    int cr = (ligne * 5) - (5 - colomne);
                    foreach (EmploiObj item in emploi)
                    {


                        if (item.id_creaneau == cr)
                        {

                            BunifuThinButton2 bc = null;
                            switch (item.type)
                            {
                                case "amphi":
                                    bc = CreerCourBtn(item.module, item.salle, item.group);

                                    break;
                                case "td":
                                    bc = CreerTDBtn(item.module, item.salle, item.group);
                                    break;
                                case "tp":
                                    bc = CreerTPBtn(item.module, item.salle, item.group);
                                    break;
                                default:
                                    break;
                            }

                            if (bc != null)
                            {


                                emploiPanel.Controls.Add(bc, colomne, ligne);
                                bc.Click += (sd, EventArgs) => { signaler_Click(sd, EventArgs, item, obj); };



                            }
                        }
                    }
                }


            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emploiPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}           
