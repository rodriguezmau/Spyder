using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        public static int totalBytes = 0;

        public Form1()
        {
            InitializeComponent();
        }

   

        string url_Text = "http://www.google.com/";

      

        private void Form1_Load(object sender, EventArgs e)
        {


        


            webBrowser1.Navigate(url_Text);

        }

        private void Bwt_Go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txt_url.Text);

         
        }

        private void Bwt_Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Bwt_Forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Bwt_Stop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txt_url.Text = webBrowser1.Url.ToString();
        }

        private void txt_url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Bwt_Go.PerformClick();
                webBrowser1.Navigate(txt_url.Text);

            }


        }

        private void txt_url_MouseClick(object sender, MouseEventArgs e)
        {
            txt_url.SelectAll();

        }


            
        }
    }
    





 


