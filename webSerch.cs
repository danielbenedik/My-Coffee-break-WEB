using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace Project1
{
    public partial class webSearch : Form
    {
        WebClient connect;
        string[] dataWeb;

        public webSearch(string[] webForSerching)
        {
            dataWeb = webForSerching;
            InitializeComponent();
            connect = new WebClient();
            updatingPage();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser2.ScriptErrorsSuppressed = true;
        }

        private void updatingPage(string needle = "Trump")
        {
            bool appearsInWeb1 = false, appearsInWeb2 = false;

            for ( int i=0; i< dataWeb.Length; i++)
            {
              string source = (connect).DownloadString(dataWeb[i]);
              if (source.Contains(needle))
              {
                    if (!appearsInWeb1)
                    {
                        webBrowser1.Navigate(dataWeb[i]);
                        appearsInWeb1 = true;
                        toolStripTextBox1.Text = dataWeb[i];
                    }
                    else
                    {
                        if (!appearsInWeb2)
                        {
                            webBrowser2.Navigate(dataWeb[i]);
                            appearsInWeb2 = true;
                            toolStripTextBox2.Text = dataWeb[i];
                        }

                    }
              }
            }
            if(!appearsInWeb1)
            {
                webBrowser1.Navigate("https://www.ynet.co.il/");
                webBrowser2.Navigate("https://www.mako.co.il/");
                toolStripTextBox1.Text = "https://www.ynet.co.il/";
                toolStripTextBox2.Text = "https://www.mako.co.il/";
            }
            if (appearsInWeb1 && !appearsInWeb2)
            {
                webBrowser2.Navigate("https://www.ynet.co.il/");
                toolStripTextBox2.Text = "https://www.ynet.co.il/";
            }
        }

        private void forSerch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updatingPage(forSerch.Text);
                forSerch.Text = string.Empty;
            }
            else if(e.KeyCode == Keys.Back)
            {

            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoBack();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.webBrowser2.GoBack();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.webBrowser2.GoForward();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void toolStripURL_Click(object sender, EventArgs e)
        {

        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

    }
}
