﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.WindowsAPICodePack.Taskbar;
using Microsoft.WindowsAPICodePack.Shell;
using System.Threading;

namespace Unowhy_Tools
{
    public partial class PCName : Form
    {
        public string resxFile = "null";

        //Set dark mode title bar
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4);
            DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            DwmSetWindowAttribute(Handle, 35, new[] { 1 }, 4);
            DwmSetWindowAttribute(Handle, 38, new[] { 1 }, 4);
        }

        public void WaitScreen()
        {
            Application.Run(new wait());
        }

        public PCName()
        {
            var e = new wait();
            e.Show();

            RegistryKey utl = Registry.CurrentUser.OpenSubKey(@"Software\STY1001\Unowhy Tools", false);
            string utls = utl.GetValue("Lang").ToString();

            string enresx = @".\en.resx";
            string frresx = @".\fr.resx";
            //Chose the ResX file
            if (utls == "EN") resxFile = enresx;    //English   
            else resxFile = frresx;               //French

            InitializeComponent();

            ResXResourceSet resxSet = new ResXResourceSet(resxFile);

            cncat.Text = resxSet.GetString("cncat");
            ancat.Text = resxSet.GetString("ancat");
            close.Text = resxSet.GetString("cancel");
            avert.Text = resxSet.GetString("avert");
            this.Text = resxSet.GetString("pcname");

            string filePath = ".\\fullpcinfo.txt";
            StreamReader inputFile = new StreamReader(filePath);
            int lineNumber = 1;
            for (int i = 1; i < lineNumber; i++)
            {
                inputFile.ReadLine();
            }
            string hnpcname = inputFile.ReadLine();
            actualname.Text = hnpcname;

            e.Close();

        }

        private void pcname_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(@"[~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_]");

            if (r.IsMatch(changename.Text.ToString().Trim()) || changename.Text.Length < 2 || changename.Text.Length > 15 || changename.Text.Contains(" "))
            {
                this.Height = 244;
                this.Width = 236;
                avert.Visible = true;
            }
            else
            {
                this.Height = 169;
                this.Width = 236;
                string msg = this.Text;
                dialog d = new dialog(msg);
                d.ShowDialog();
                if (d.DialogResult.Equals(DialogResult.Yes))
                {
                    avert.Visible = false;
                    string name = changename.Text;
                    string arg = ($"-Command \"& {{Rename-Computer -NewName \"{name}\" -Force}}\"");
                    //MessageBox.Show(arg); //Debug
                    actualname.Text = name;
                    Thread t = new Thread(new ThreadStart(WaitScreen));               //Splash Screen
                    t.Start();
                    TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Indeterminate);
                    Process p = new Process();
                    p.StartInfo.FileName = "powershell";
                    p.StartInfo.Arguments = arg;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                    p.Start();
                    p.WaitForExit();
                    t.Abort();
                    TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);
                    var f = new reboot();
                    f.ShowDialog();
                }
            }
        }
    }
}
