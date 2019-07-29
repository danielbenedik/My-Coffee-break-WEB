using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace Project1
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            data danielData = new data();
            webSearch mySerch = new webSearch(danielData.WebArry);
            mySerch.ShowDialog();
        }
        

    }
}
