using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Proxy
{
    class settingProxy
    {
        // use singleton pattern 
        private static settingProxy instance;
        private static Thread Proxy;
        // ON = 1  OFF =0 to save value in registry => ProxyEnable
        private int isON = 1;
        //Start Pointers to Elements in UI Thread
        private Label resultProxy;
        private ListBox LHTTP;
        private ListBox LHTTPS;
        private ListBox LFTP;
        private ListBox LSOCKS;
        private Dictionary<string, bool> Uses;
        //End Pointers to Elements in UI Thread

        //Start format string for all types (HTTP,HTTPS,FTP,SOCKS)
        // that will save in registry => serverProxy
        private const string fHTTP = "http={0};";
        private const string fHTTPS = "https={0};";
        private const string fFtp = "ftp={0};";
        private const string fSOCKS = "socks={0};";
        //End Pointers to Elements in UI Thread
        // full string to save it in registry
        private StringBuilder formatProxy;
        // Start Counters to lists =>  (HTTP,HTTPS,FTP,SOCKS)
        private int cHTTP = -1;
        private int cHTTPS = -1;
        private int cFTP = -1;
        private int cSOCKS = -1;
        //End Counters to lists

            // Timer for thread sleep
        private static int Timer = 30000;

        // save value timer
        public  void setTimer(int time)
        {
            // convert form millisecond to second
            Timer = time * 1000;
        }

        // make private constructor to prevent create new Object
        private settingProxy() {
            //setting initial values
            isON = 0;
            formatProxy = new StringBuilder();
        }

        // return instance 
        public static settingProxy Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new settingProxy();


                }
                return instance;
            }
        }
        // set up all pointers coming form UI from class GlobalProxy
        public void settingProps(Label resultProxy, ListBox LHTTP, ListBox LHTTPS, ListBox LFTP, ListBox LSOCKS, Dictionary<string, bool> Uses)
        {
            this.resultProxy = resultProxy;
            this.LHTTP = LHTTP;
            this.LHTTPS = LHTTPS;
            this.LFTP = LFTP;
            this.LSOCKS = LSOCKS;
            this.Uses = Uses;
        }

        // run proxy
        public void ON()
        {
            isON = 1;
            Proxy = new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                while (true)
                {
                    saveProxy();
                    Thread.Sleep(Timer);

                }
            });
            Proxy.Start();
            {
                MessageBox.Show("The proxy has been turned on",
               "Global Proxy",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                //  Console.WriteLine("The proxy has been turned on.");
            }
        }

        public void ChangeManually()
        {
            // stop auto change
            // auto depends on counters
            // manually depends on selected items , user clicked on them
            Proxy.Abort();
            //Update the values
            UpdateIndexs(true);

        }

        public void OFF()
        {
            // change value to zero
            isON = 0;
            // save value after edited
            saveProxy();
            // stop thread
            if(Proxy != null)Proxy.Abort();
            {
                MessageBox.Show("The proxy has been turned off",
                FlipFlopProxy.AppTitle,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                //  Console.WriteLine("The proxy has been turned off");
            }
        }

        [DllImport("wininet.dll")]
        /// access to Proxy setting 
        public static extern bool InternetSetOption
          (IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;

        public void saveProxy()
        {
            bool settingsReturn, refreshReturn;

            //   Console.WriteLine("*************Proxy ON OFF*************\n");
            //   Console.WriteLine("1 for ON\n");
            //   Console.WriteLine("0 for OFF\n");

            // open registry to edit data there
            RegistryKey registry = Registry.CurrentUser.OpenSubKey
               ("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);

            switch (isON)
            {
                case 1:
                    {
                        UpdateIndexs();
                        registry.SetValue("ProxyEnable", 1);
                        registry.SetValue
                        ("ProxyServer", formatProxy.ToString());
                        if ((int)registry.GetValue("ProxyEnable", 0) == 0)
                        {
                            MessageBox.Show("Unable to enable the proxy.",
                             FlipFlopProxy.AppTitle,
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1);
                            //   Console.WriteLine("Unable to enable the proxy.");

                        }                        
                         break;
                    }
                case 0:
                    {
                        registry.SetValue("ProxyEnable", 0);
                        registry.SetValue("ProxyServer", 0);
                        if ((int)registry.GetValue("ProxyEnable", 1) == 1)
                        {
                            MessageBox.Show("Unable to disable the proxy.",
                            FlipFlopProxy.AppTitle,
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1);
                            //Console.WriteLine("Unable to disable the proxy.");


                        }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Invalid Argument!.",
                             FlipFlopProxy.AppTitle,
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error,
                             MessageBoxDefaultButton.Button1);
                        return;
                    }
            }
            // after save data close registry
            registry.Close();
            settingsReturn = InternetSetOption
            (IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption
            (IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }
        //uses for update counter and change item selected in ListBox
        private void UpdateIndexs(bool isManually = false)
        {
            formatProxy.Clear(); //remove previous string because use append
            //check if list that are used
            if (Uses.ContainsKey("uHTTP") && Uses["uHTTP"])
            {
                // return counter to zero if bypass the list count
                if (cHTTP >= LHTTP.Items.Count - 1) cHTTP = -1;
                // if manually send selected index , if auto send counter of list
                UpdateList(isManually? LHTTP.SelectedIndex: ++cHTTP, LHTTP, fHTTP);
            }

            if (Uses.ContainsKey("uHTTPS") && Uses["uHTTPS"])
            {
                if (cHTTPS >= LHTTPS.Items.Count - 1) cHTTPS = -1;
                UpdateList(isManually ? LHTTPS.SelectedIndex : ++cHTTPS, LHTTPS, fHTTPS);
            }

            if (Uses.ContainsKey("uFTP") && Uses["uFTP"])
            {
                if (cFTP >= LFTP.Items.Count - 1) cFTP = -1;
                UpdateList(isManually ? LFTP.SelectedIndex : ++cFTP, LFTP, fFtp);
            }

            if (Uses.ContainsKey("uSOCKS") && Uses["uSOCKS"])
            {
                if (cSOCKS >= LSOCKS.Items.Count -1) cSOCKS = -1;
                UpdateList(isManually ? LSOCKS.SelectedIndex : ++cSOCKS, LSOCKS, fSOCKS);
               
            }

        }
        // pass counter , list , format to build full format for proxy , which will save in registry
        // update selected item in List
        private void UpdateList(int counter , ListBox list,string formatString)
        {
            // Invoke item , which it from UI-Thread to current Thread
            list.Invoke(new MethodInvoker(delegate {
            // load the control with the appropriate data
            list.SelectedIndex = counter; // current counter to list
             //set data to string
            formatProxy.AppendFormat(formatString, list.SelectedItem);
             // show to result for user in main page
            resultProxy.Text = formatProxy.ToString();
            // update the list after selected item
            list.Update();
            list.Focus();
            }));
            return;
            
        }
    }
}
