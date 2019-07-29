using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class data
    {
        string[] webArray;
        int sizeOfWeb = 4;

        public data()
        {
            webArray = new string[sizeOfWeb];
            setarry();
        }

        public string[] WebArry { get => webArray; }

        public void setarry()
        {
            webArray[0] = "https://www.bbc.com/";
            webArray[1] = "https://edition.cnn.com/";
            webArray[2] = "https://www.nytimes.com/";
            webArray[3] = "https://www.jpost.com/";
        }
    }
}
