using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientEmploi
{
  static  class CommunFuctions
    {
       static String tab = "    ";
      
        public static BunifuThinButton2 CreerCourBtn(String module, int num_salle)
        {

            BunifuThinButton2 bunifuThinButton22 = new BunifuThinButton2();

            bunifuThinButton22.ActiveBorderThickness = 1;
            bunifuThinButton22.ActiveCornerRadius = 20;
            bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            bunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            bunifuThinButton22.ButtonText = "Cours\r\n" + module + "\r\n Amphi " + num_salle;
            bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            bunifuThinButton22.IdleBorderThickness = 1;
            bunifuThinButton22.IdleCornerRadius = 20;
            bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            bunifuThinButton22.Name = "bunifuThinButton22";
            bunifuThinButton22.Size = new System.Drawing.Size(158, 92);
           
         
            bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            return bunifuThinButton22;
        }

        public static BunifuThinButton2 CreerTDBtn(String module, int num_salle)
        {

            BunifuThinButton2 bunifuThinButton22 = new BunifuThinButton2();

            bunifuThinButton22.ActiveBorderThickness = 1;
            bunifuThinButton22.ActiveCornerRadius = 20;
            bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(223)))), ((int)(((byte)(243)))));
            bunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(223)))), ((int)(((byte)(243)))));
            bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            bunifuThinButton22.ButtonText = "TD\r\n" + module + "\r\n Salle TD " + num_salle;
            bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            bunifuThinButton22.IdleBorderThickness = 1;
            bunifuThinButton22.IdleCornerRadius = 20;
            bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(223)))), ((int)(((byte)(243)))));
            bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(223)))), ((int)(((byte)(243)))));
            bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            bunifuThinButton22.Name = "bunifuThinButton22";
            bunifuThinButton22.Size = new System.Drawing.Size(158, 92);
        
            bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            return bunifuThinButton22;
        }

        public static BunifuThinButton2 CreerTPBtn(String module, int num_salle)
        {

            BunifuThinButton2 bunifuThinButton22 = new BunifuThinButton2();

            bunifuThinButton22.ActiveBorderThickness = 1;
            bunifuThinButton22.ActiveCornerRadius = 20;
            bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            bunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            bunifuThinButton22.ButtonText = "TP\r\n" + module + "\r\n Salle TP " + num_salle;
            bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            bunifuThinButton22.IdleBorderThickness = 1;
            bunifuThinButton22.IdleCornerRadius = 20;
            bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            bunifuThinButton22.Name = "bunifuThinButton22";
            bunifuThinButton22.Size = new System.Drawing.Size(158, 92);
            
            bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            return bunifuThinButton22;
        }


        public static BunifuThinButton2 CreerCourBtn(String module, int num_salle,int section)
        {

            BunifuThinButton2 bunifuThinButton22 = new BunifuThinButton2();

            bunifuThinButton22.ActiveBorderThickness = 1;
            bunifuThinButton22.ActiveCornerRadius = 20;
            bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(237)))), ((int)(((byte)(200)))));
            bunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(237)))), ((int)(((byte)(200)))));
            bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            bunifuThinButton22.ButtonText = "Cours " + module + "\r\n Section " + section + "\r\n"+tab+"Amphi " + num_salle;
            bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            bunifuThinButton22.IdleBorderThickness = 1;
            bunifuThinButton22.IdleCornerRadius = 20;
            bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(237)))), ((int)(((byte)(200)))));
            bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(237)))), ((int)(((byte)(200)))));
            bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            bunifuThinButton22.Name = "bunifuThinButton22";
            bunifuThinButton22.Size = new System.Drawing.Size(158, 92);
            ToolTip toolTip1 = new ToolTip();

            toolTip1.SetToolTip(bunifuThinButton22, "Cliquer pour signaler cette séance");
           
           
            bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            return bunifuThinButton22;
        }

        public static BunifuThinButton2 CreerTDBtn(String module, int num_salle,int groupe)
        {

            BunifuThinButton2 bunifuThinButton22 = new BunifuThinButton2();

            bunifuThinButton22.ActiveBorderThickness = 1;
            bunifuThinButton22.ActiveCornerRadius = 20;
            bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(223)))), ((int)(((byte)(243)))));
            bunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(223)))), ((int)(((byte)(243)))));
            bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            bunifuThinButton22.ButtonText = "TD " + module + "\r\n Groupe " + groupe + "\r\n" + tab + "Salle TD " + num_salle;
            bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            bunifuThinButton22.IdleBorderThickness = 1;
            bunifuThinButton22.IdleCornerRadius = 20;
            bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(223)))), ((int)(((byte)(243)))));
            bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(223)))), ((int)(((byte)(243)))));
            bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            bunifuThinButton22.Name = "bunifuThinButton22";
            bunifuThinButton22.Size = new System.Drawing.Size(158, 92);
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(bunifuThinButton22, "Cliquer pour signaler cette séance");
            bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            return bunifuThinButton22;
        }

        public static BunifuThinButton2 CreerTPBtn(String module, int num_salle,int groupe)
        {

            BunifuThinButton2 bunifuThinButton22 = new BunifuThinButton2();

            bunifuThinButton22.ActiveBorderThickness = 1;
            bunifuThinButton22.ActiveCornerRadius = 20;
            bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            bunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            bunifuThinButton22.ButtonText = "TP " + module  + "\r\n Groupe " + groupe + "\r\n" + tab + "Salle TP " + num_salle;
            bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            bunifuThinButton22.IdleBorderThickness = 1;
            bunifuThinButton22.IdleCornerRadius = 20;
            bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            bunifuThinButton22.Name = "bunifuThinButton22";
            bunifuThinButton22.Size = new System.Drawing.Size(158, 92);
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(bunifuThinButton22, "Cliquer pour signaler cette séance");
            bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            return bunifuThinButton22;
        }

        public static void ViderEmploi(TableLayoutPanel emploi)
        {
            for (int ligne = 1; ligne <= 5; ligne++)
            {

                for (int colomne = 1; colomne <= 5; colomne++)
                {

                    emploi.Controls.Remove(emploi.GetControlFromPosition(colomne, ligne));


                }


            }
        }




    }
}
