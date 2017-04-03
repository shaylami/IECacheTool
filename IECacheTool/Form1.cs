using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IECacheTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void SelectWhat2Delete()
        {
            string a, b, c, d, e, f, g;
            if(checkBoxTIF.Checked)
            {
                //Temporary Internet Files
                System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8");
                RTBResultText.AppendText(checkBoxTIF.Text + " Deleted \n");
            }
            if(checkBoxCookies.Checked)
            {
                //Cookies
                System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 2");
                RTBResultText.AppendText(checkBoxCookies.Text + " Deleted \n");
            }
            if(checkBoxHistory.Checked)
            {
                //History
                System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 1");
                RTBResultText.AppendText(checkBoxHistory.Text + " Deleted \n");
            }
            if(checkBoxForm.Checked)
            {
                //Form(Data)
                System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 16");
                RTBResultText.AppendText(checkBoxForm.Text + " Deleted \n");
            }
            if(checkBoxPasswords.Checked)
            {
                //Passwords
                System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 32");
                RTBResultText.AppendText(checkBoxPasswords.Text + " Deleted \n");
            }
            if(checkBoxDeleteAll.Checked)
            {
                //Delete(All)
                System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 255");
                RTBResultText.AppendText(checkBoxDeleteAll.Text + " Deleted \n");
            }
            if(checkBoxAllnadSettings.Checked)
            {
                //Delete All – Also delete files and settings stored by add-ons 
                System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 4351");
                RTBResultText.AppendText(checkBoxAllnadSettings.Text + " Deleted \n");
            }
            a = checkBoxTIF.CheckState.ToString();
            b = checkBoxCookies.CheckState.ToString();
            c = checkBoxHistory.CheckState.ToString();
            d = checkBoxForm.CheckState.ToString();
            e = checkBoxPasswords.CheckState.ToString();
            f = checkBoxDeleteAll.CheckState.ToString();
            g = checkBoxAllnadSettings.CheckState.ToString();
            if((a != "Checked")&& (b != "Checked")&& (c != "Checked")&& (d != "Checked")&& (e != "Checked")&& (f != "Checked")&& (g != "Checked"))
            {
                RTBResultText.Clear();
                MessageBox.Show(this, "You Must choose at least one option", "Alert !!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                RTBResultText.Clear();
                SelectWhat2Delete();
            }
            catch(Exception ex)
            {
                string a = ex.ToString();
            }
        }
        
    }
}
