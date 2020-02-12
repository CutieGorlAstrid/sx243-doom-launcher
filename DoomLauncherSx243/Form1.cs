using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoomLauncherSx243
{
    public partial class MainWindow : Form
    {
        public int IWADSelectFunc()
        {

            DirectoryInfo dinfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] WADs = dinfo.GetFiles("*.wad");
            foreach (FileInfo file in WADs)
            {
                if (file.Name.Contains("DOOM") | file.Name.Contains("DOOM1") | file.Name.Contains("DOOM2") | file.Name.Contains("PLUTONIA") | file.Name.Contains("TNT") | file.Name.Contains("freedoom1") | file.Name.Contains("freedoom2") | file.Name.Contains("freedm"))
                {
                    iwadSelect.Items.Add(file.Name);
                }
            }
            return 0;
        }

        public int PWADSelectFunc()
        {

            DirectoryInfo dinfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] WADs = dinfo.GetFiles("*.wad");
            foreach (FileInfo file in WADs)
            {
                if (!(file.Name.Contains("DOOM") | file.Name.Contains("DOOM1") | file.Name.Contains("DOOM2") | file.Name.Contains("PLUTONIA") | file.Name.Contains("TNT")))
                {
                    pwadSelect.Items.Add(file.Name);
                }
            }
            return 0;
        }

        public MainWindow()
        {
            InitializeComponent();
            IWADSelectFunc();
            PWADSelectFunc();
            sourcePortLabel.Text = "Source port: None";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void chooseSPButton_Click(object sender, EventArgs e)
        {
            chooseSourcePort.ShowDialog();
            sourcePortLabel.Text = "Source port: ";
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program must be in the same location as your Doom IWADs and PWADs.","I'm not seeing all my PWADs...");
        }
    }
}
