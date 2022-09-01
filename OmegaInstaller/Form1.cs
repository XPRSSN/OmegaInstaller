using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace OmegaInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DownloadDll_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://raw.githubusercontent.com/XPRSSN/Omega/main/DLL/Omega16.8.2022.dll", "Omega31.8.2022.dll");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (var client = new WebClient())
            {
                client.DownloadFile("https://raw.githubusercontent.com/XPRSSN/Omega/main/Injectors/CSGhost-v4.3.1.exe", "CSGhost-v4.3.1.exe");
            }

        }

    }
}
