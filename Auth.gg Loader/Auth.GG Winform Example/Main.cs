using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;
using ManualMapInjection.Injection;

namespace Auth.GG_Winform_Example
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            userid.Text = "ID: " + User.ID;
            username.Text = "Username: " + User.Username;
            email.Text = "Email: " + User.Email;
            hwid.Text = "HWID: " + User.HWID;
            uservariable.Text = "User Variable: " + User.UserVariable;
            userrank.Text = "Rank: " + User.Rank;
            ip.Text = "IP: " + User.IP;
            expiry.Text = "Expiry: " + User.Expiry;
            lastlogin.Text = "Last Login: " + User.LastLogin;
            registerdate.Text = "Register Date: " + User.RegisterDate;
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string mainpath = "C:\\Windows\\random.dll"; //You can change the path to wherever you want but just remember to use "\\" instead of just one "\"
            wb.DownloadFile("https://github.com/Luxusususuxd/dzavszavsduvasduzv/raw/main/uizvuvtutcZTCRff.dll", mainpath); //DLL Url
            var name = "csgo"; //Process Name
            var target = Process.GetProcessesByName(name).FirstOrDefault();
            var path = mainpath;
            var file = File.ReadAllBytes(path);

            //Checking if the DLL isn't found
            if (!File.Exists(path))
            {
                MessageBox.Show("DLL not available!");
                return;
            }

            //Injection, just leave this alone if you are a beginner
            var injector = new ManualMapInjector(target) { AsyncInjection = true };
            label2.Text = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";

            if (System.IO.File.Exists(mainpath)) //Checking if the DLL exists
            {
                System.IO.File.Delete(mainpath); //Deleting the DLL
            }
        }

        private void siticoneRoundedButton1_Click_1(object sender, EventArgs e)
        {
            Process.Start("steam://rungameid/730");

        }

        private void userid_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/CAn3pSwc3B");
        }
    }
}
