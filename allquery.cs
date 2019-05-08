using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSecurityInformationSystem
{
    public class allquery
    {
        public int sampfunc(int num1)
        {
            string samplemessage = "Sample Success";
            //nt numsamp=1;
            if (num1==1)
            {
                MessageBox.Show(samplemessage,"Infobox");
            }
            else
            {
                MessageBox.Show("Sample Fail", "Infobox");
            }
            return 0;
        }

    }
}
