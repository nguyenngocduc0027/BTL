using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1CAndNSecurity
{
    public partial class FormMain : Form
    {



        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            //Set properties form main.
            this.FormBorderStyle = FormBorderStyle.Sizable;


        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnDecryption_Click(object sender, EventArgs e)
        {
            FormMD5 fe = new FormMD5();
             this.Hide();
             fe.ShowDialog();
             this.Close();
        }

        private void btnEncryption_Click(object sender, EventArgs e)
        {
//             FormDES fe = new FormDES();
//             fe.ShowDialog(this);

//             FormDES fe = new FormDES();
//              this.Hide();
//              fe.ShowDialog();
//              this.Close();

//             FormAES fe = new FormAES();
//              this.Hide();
//              fe.ShowDialog();
//              this.Close();


            FormRSA fe = new FormRSA();
             this.Hide();
             fe.ShowDialog();
             this.Close();

        }

        private void btnEncryption_MouseHover(object sender, EventArgs e)
        {
            btnRSA.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnRSASel;
        }

        private void btnDecryption_MouseHover(object sender, EventArgs e)
        {
            btnHashAlg.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnHashAlgSel;
        }

        private void btnDecryption_MouseLeave(object sender, EventArgs e)
        {
            btnHashAlg.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnHashAlg;
        }

        private void btnEncryption_MouseLeave(object sender, EventArgs e)
        {
            btnRSA.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnRSANon;
        }

        private void btnDecryption_MouseMove(object sender, MouseEventArgs e)
        {
            btnHashAlg.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnHashAlgSel;
        }

        private void btnEncryption_MouseMove(object sender, MouseEventArgs e)
        {
            btnRSA.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnRSASel;
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnExitSelected;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnExitSelected;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnExit;
        }

        private void btnDES_Click(object sender, EventArgs e)
        {
            FormDES fe = new FormDES();
             this.Hide();
             fe.ShowDialog();
             this.Close();

        }

        private void btnAES_Click(object sender, EventArgs e)
        {
//             FormAES fe = new FormAES();
//             fe.ShowDialog(this);
            FormAES fe = new FormAES();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }


        private void btnDES_MouseHover(object sender, EventArgs e)
        {
            this.btnDES.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnDESSel;
        }
        private void btnDES_MouseLeave(object sender, EventArgs e)
        {
            this.btnDES.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnDESNon;
        }
        private void btnDES_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnDES.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnDESSel;
        }

        private void btnAES_MouseHover(object sender, EventArgs e)
        {
            this.btnAES.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnAESSel;
        }
        private void btnAES_MouseLeave(object sender, EventArgs e)
        {
            this.btnAES.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnAESNon;
        }
        private void btnAES_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnAES.BackgroundImage = global::Assignment1CAndNSecurity.Properties.Resources.btnAESSel;
        }



    }
   
}
