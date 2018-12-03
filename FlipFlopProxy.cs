using Proxy;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Proxy
{
    public partial class FlipFlopProxy : Form
    {
        // flags
        public const int  HTTP_LIST = 1;
        public const int HTTPs_LIST = 2;
        public const int FTP_LIST = 3;
        public const int SOCKS_LIST = 4;
        // title app
        public static string AppTitle = "Flip-flop Proxy";
        // temp flag it is selected
        public static int tmpFlag;
        //uses of list  -> HTTP,HTTPS,FTP,SOCKS => ture,false
        private Dictionary<string, bool> Uses;



        //trigger for button click
        private bool isRun = false;

        // constructor
        public FlipFlopProxy()
        {
            InitializeComponent();
            Uses = new Dictionary<string, bool>();
            // pass UI elements to setting class to use them there
            settingProxy.Instance.settingProps(resultOfProxy,LHTTP, LHTTPS, LFTP, LSOCKS, Uses);
        }

        // event when click on checkBox for (use)
        private void AllowTypeOfProxy(object sender, EventArgs e)
        {
            CheckBox checkedBtn = (CheckBox)sender;
            Uses[checkedBtn.Name] = checkedBtn.Checked;
        }
        // off prxoy when exit if user do not click Stop
        private void OnApplicationExit(Object sender, FormClosingEventArgs e)
        {
            settingProxy.Instance.OFF();
        }

        //when open add page ...
        private void addToHTTP(object sender, EventArgs e)
        {
            // set flag which list we will use
            // hide current page
            tmpFlag = HTTP_LIST;
            TogglePanel(true);
        }
        private void addToHTTPs(object sender, EventArgs e)
        {
            // set flag which list we will use
            // hide current page
            tmpFlag = HTTPs_LIST;
            TogglePanel(true);
        }
        private void addToFTP(object sender, EventArgs e)
        {
            // set flag which list we will use
            // hide current page
            tmpFlag = FTP_LIST;
            TogglePanel(true);
        }
        private void addToSOCKS(object sender, EventArgs e)
        {
            // set flag which list we will use
            // hide current page
            tmpFlag = SOCKS_LIST;
            TogglePanel(true);
        }

      
        // save data from add page to list
        private void saveList(object sender, EventArgs e)
        {
            // check we have data to add it

            if (!ListOfElements.Text.Equals("") && ListOfElements.Text.Length != 0)
            {
                // split string in TextArea to array to add them in list
                string[] data = ListOfElements.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                // send flag and data  ... to store them in correct list
                SaveData(tmpFlag, data);
                // hide add page and return to main page
                TogglePanel(false);
                // return TextArea to empty
                ListOfElements.Text = null;
            }
        }

        private void SaveData(int flag, string[] result)
        {
            // swtich flag
            // and set data to list
            switch (tmpFlag)
            {
                
                case HTTP_LIST:
                    string[] listHTTP = result;
                    AddDataToCollection(listHTTP, LHTTP.Items);
                  //  LHTTP.Items.
                    break;
                case HTTPs_LIST:
                    string[] listHTTPs = result;
                    AddDataToCollection(listHTTPs, LHTTPS.Items);
                    break;
                case FTP_LIST:
                    string[] listFTP = result;
                    AddDataToCollection(listFTP, LFTP.Items);
                    break;
                case SOCKS_LIST:
                    string[] listSOCKS = result;
                    AddDataToCollection(listSOCKS, LSOCKS.Items);
                    break;
            }
        }
        // when click on OK button do not do any thing just return to main page
        private void okEvent(object sender, EventArgs e)
        {
            
            TogglePanel(false);
        }
        // take selected elements and save them manually
        // selected form lists => HTTP, HTTPS , FTP , SOCKS
        private void ChangeManually(object sender, EventArgs e)
        {
            settingProxy.Instance.ChangeManually();
        }

        //event when click on clear btn clear list
            private void ClearEvent(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;
            switch (tmp.Name)
            {
                case "delHTTP":
                    LHTTP.Items.Clear();
                    break;

                case "delHTTPS":
                    LHTTPS.Items.Clear();
                    break;

                case "delFTP":
                    LFTP.Items.Clear();
                    break;

                case "delSOCKS":
                    LSOCKS.Items.Clear();
                    break;
            }
        }
        // add data to ListBox
        private void AddDataToCollection(string[] from , ListBox.ObjectCollection to)
        {
           foreach(Object item in from)
            {
                to.Add(item);
            }
        }

      
        // event when click on Apply Button
            private void saveTime(object sender, EventArgs e)
        {
            // check string which we are entered it is Number
            bool isNum = true , initialStep = false;
            foreach(char num in TimeValue.Text)
            {
                if(num >='0' && num <= '9')
                {
                    isNum &= true;
                    initialStep |= isNum;
                }
                else
                {
                    initialStep &= false;
                    MessageBox.Show("Enter a valid number ,now using the old value ",
                            FlipFlopProxy.AppTitle,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
                    break;
                }

            }
            if (isNum && initialStep)
            {
                // convert it is to integer and pass it setting class to save them there
                // to control in  thread sleep
                int time = Int32.Parse(TimeValue.Text);
                settingProxy.Instance.setTimer(time);
            }
            
                     
        }
        // hide,show => mainPage and AddPage
        private void TogglePanel(bool Active)
        {
            addList.Visible = Active;
            flowLayoutPanel1.Visible = !addList.Visible;
            flowLayoutPanel2.Visible = !addList.Visible;
            flowLayoutPanel3.Visible = !addList.Visible;
        }
        //check list which will use it not Empty!!
        private bool NotEmptyList()
        {
            // if there are data set this => true
            bool isExistAnDNotEmpty = true;
            // this to check first step
            bool initialCheck = false;
            // check if clicked on Uses CheckBox or not
            if (Uses.ContainsKey("uHTTP") && Uses["uHTTP"])
            {
                // check the data on list it is not empty
                isExistAnDNotEmpty &= LHTTP.Items.Count > 0;
                initialCheck |= true;


            }
            if (Uses.ContainsKey("uHTTPS") && Uses["uHTTPS"])
            {
                    isExistAnDNotEmpty &= LHTTPS.Items.Count > 0;
                initialCheck |= true;
            }
            if (Uses.ContainsKey("uFTP") && Uses["uFTP"])
            {
                    isExistAnDNotEmpty &= LFTP.Items.Count > 0;
                initialCheck |= true;
            }
            if (Uses.ContainsKey("uSOCKS") && Uses["uSOCKS"])
            {
                    isExistAnDNotEmpty &= LSOCKS.Items.Count > 0;
                initialCheck |= true;
            }
            return !(initialCheck && isExistAnDNotEmpty);
        }
        // event when click on Run button
        private  void RunEvent(object sender, EventArgs e)
        {
            // check from all lists we are used that are not empty..
            if (NotEmptyList())
            {
                MessageBox.Show("You can not use Empty List. or check use list",
    AppTitle,
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);
                return;

            }
            
            if (!isRun)
            {
                isRun = true;
                runBtn.Text = "Stop";
                // run thread to start save data on registry
                settingProxy.Instance.ON();
            }
            else
            {
                isRun = false;
                runBtn.Text = "Run";
                // run thread to stop save data on registry
                settingProxy.Instance.OFF();
            }
          
        }
    }
}
