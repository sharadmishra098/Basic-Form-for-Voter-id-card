using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Voter_ID_Card_Management
{
    public partial class appbody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public appbody()
        {
            InitializeComponent();

            //initialization for sliding panel
            isSlidingPanelExpanded = true;
            expandSlidingPannelGUI();
        }

        private void appbody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Log_in_timer.Start();
        }

        private void Log_in_timer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity<=1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                Log_in_timer.Stop();
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoffbutton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void expandSlidingPannelGUI()
        {
            //gui adjustment
            MandatoryDetails.Text = "Mandatory Details";
            Address.Text = "Address";
            Constituency.Text = "Constituency";
            Settings.Text = "Settings";
            SlidindPanel_ToggleButton.Image = Properties.Resources.leftarr;
            MandatoryDetails.Image = null;
            Address.Image = null;
            Constituency.Image = null;
            Settings.Image = null;
        }

        public void retractSlidingPannelGUI()
        {
            //gui adjustment
            MandatoryDetails.Text = "";
            Address.Text = "";
            Constituency.Text = "";
            Settings.Text = "";
            SlidindPanel_ToggleButton.Image = Properties.Resources.rightarr;
            MandatoryDetails.Image = Properties.Resources.person2;
            Address.Image = Properties.Resources.add1;
            Constituency.Image = Properties.Resources.vote1;
            Settings.Image = Properties.Resources.settings;
        }

        //sliding panel code
        bool isSlidingPanelExpanded;
        const int MaxSliderWidth = 300;
        const int MinSliderWidth = 100;

        private void SlidindPanel_ToggleButton_Click(object sender, EventArgs e)
        {
            if(isSlidingPanelExpanded)
            {
                retractSlidingPannelGUI();
            }
            SlidingPanel_Timer.Start();
        }

        private void SlidingPanel_Timer_Tick(object sender, EventArgs e)
        {
            if(isSlidingPanelExpanded)
            {
                //retract panel
                SlidingPanel.Width -= 30;
                if(SlidingPanel.Width <= MinSliderWidth)
                {
                    //stop retract
                    isSlidingPanelExpanded = false;
                    SlidingPanel_Timer.Stop();

                    this.Refresh();
                }
            }
            else
            {
                //expand the panel
                SlidingPanel.Width += 30;
                if (SlidingPanel.Width >= MaxSliderWidth)
                {
                    //stop retract
                    isSlidingPanelExpanded = true;
                    SlidingPanel_Timer.Stop();
                    expandSlidingPannelGUI();
                    this.Refresh();
                }
            }
        }

        private void MandatoryDetails_Click(object sender, EventArgs e)
        {
            if(! ContentPannel.Controls.Contains(MandatoryUserControl.Instance))
            {
                ContentPannel.Controls.Add(MandatoryUserControl.Instance);
                MandatoryUserControl.Instance.Dock = DockStyle.Fill;
                MandatoryUserControl.Instance.BringToFront();
            }
            else
            {
                MandatoryUserControl.Instance.BringToFront();
            }
        }

        private void Address_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(AddressControl.Instance))
            {
                ContentPannel.Controls.Add(AddressControl.Instance);
                AddressControl.Instance.Dock = DockStyle.Fill;
                AddressControl.Instance.BringToFront();
            }
            else
            {
                AddressControl.Instance.BringToFront();
            }
        }

        private void Constituency_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(ConstituencyControl.Instance))
            {
                ContentPannel.Controls.Add(ConstituencyControl.Instance);
                ConstituencyControl.Instance.Dock = DockStyle.Fill;
                ConstituencyControl.Instance.BringToFront();
            }
            else
            {
                ConstituencyControl.Instance.BringToFront();
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(SettingsControl.Instance))
            {
                ContentPannel.Controls.Add(SettingsControl.Instance);
                SettingsControl.Instance.Dock = DockStyle.Fill;
                SettingsControl.Instance.BringToFront();
            }
            else
            {
                SettingsControl.Instance.BringToFront();
            }
        }
    }
}
