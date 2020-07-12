using System;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Micros_Toolbox.Classes;
using System.Management.Automation;
using System.Collections.ObjectModel;
using Microsoft.PowerShell.Commands;
using Namotion.Reflection;

namespace Micros_Toolbox
{
    public partial class Toolbox : Form
    {
        public Toolbox()
        {
            InitializeComponent();
            Logger.LogRTB = LogRTB;
           // ActionsAllowed(false);
        }

        public static bool PingCheck(string hostname)
        {
            bool online = false;
            Ping sendping = null;

            try
            {
                sendping = new Ping();
                PingReply reply = sendping.Send(hostname);
                online = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                return false;
            }
            finally
            {
                if (sendping != null)
                {
                    sendping.Dispose();
                }
            }

            return online;
        }

        public void CheckStatus()
        {
            if (hostnameInput.Text != "")
            {
                if (PingCheck(hostnameInput.Text))
                {
                    status.Text = "ONLINE";
                    status.BackColor = Color.LawnGreen;
                    hostnameInput.Enabled = false;
                    checkStatusBtn.Text = "Disconnect";
                    ActionsAllowed(true);
                    Logger.Good("Connected to '" + hostnameInput.Text + "' succesfully!");
                }
                else
                {
                    status.Text = "OFFLINE";
                    status.BackColor = Color.Red;
                    ActionsAllowed(false);
                    Logger.Error("ERROR: '" + hostnameInput.Text + "' is offline! Ensure the hostname is correct.");
                }
            } else
            {
                ActionsAllowed(false);
                status.BackColor = Color.Yellow;
                status.Text = "Waiting...";
                Logger.Warning("Enter a hostname or IP address!");
            }
        }

        public void ActionsAllowed(Boolean enableDisable)
        {
            killCalBtn.Enabled = enableDisable;
            killSarOpsBtn.Enabled = enableDisable;
            rebootBtn.Enabled = enableDisable;
            startSarOpsBtn.Enabled = enableDisable;
        }

        private void checkStatusBtn_Click(object sender, EventArgs e)
        {
            if (checkStatusBtn.Text == "Connect")
            {
                CheckStatus();
            } else
            {
                ActionsAllowed(false);
                Logger.Good("Disconnected from '" + hostnameInput.Text + "' succesfully!");
                hostnameInput.Enabled = true;
                checkStatusBtn.Text = "Connect";
                status.Text = "Waiting...";
                status.BackColor = Color.Yellow;
            }
        }

        private void hostnameInput_TextChanged(object sender, EventArgs e)
        {
            //ActionsAllowed(false);
            status.BackColor = Color.Yellow;
            status.Text = "Waiting...";
        }

        private void rebootBtn_Click(object sender, EventArgs e)
        {
            Commands.RunPowershell("Restart-Computer –ComputerName " + hostnameInput.Text);
            Logger.Good("Rebooting Terminal!");
        }

        private void killSarOpsBtn_Click(object sender, EventArgs e)
        {
            Commands.RunPowershell("(Get-WmiObject Win32_Process -ComputerName " + hostnameInput.Text + " | ?{ $_.ProcessName -match 'SarOps' }).Terminate()");
            Logger.Good("\"Kill SarOps\" Command sent!");
        }

        private void killCalBtn_Click(object sender, EventArgs e)
        {
            Commands.RunPowershell("(Get-WmiObject Win32_Process -ComputerName " + hostnameInput.Text + " | ?{ $_.ProcessName -match 'McrsCal' }).Terminate()");
            Logger.Good("\"Kill McrsCal\" Command sent!");
        }

        private void getServicesBtn_Click(object sender, EventArgs e)
        {


            //SEE DYLANS TEXT MESSAGE ABOUT SERVICECONTROLLER!


            var test = "Get-Service -ComputerName " + hostnameInput.Text;
            Logger.Log("Getting Services List from '" + hostnameInput.Text + "'");
            using (PowerShell ps = PowerShell.Create())
            {
                //ps.AddScript("Get-Service -ComputerName " + hostnameInput.Text);
                ps.AddScript(test);
                Collection<PSObject> PSOutput = ps.Invoke();

                foreach (PSObject outputItem in PSOutput)
                {
                    if (outputItem != null)
                    {
                        Logger.List(outputItem.BaseObject.ToString());

                        Logger.List(outputItem.BaseObject.GetType().GetProperty("ServiceName").GetValue(outputItem.BaseObject, null).ToString());
                    } else
                    {
                        Logger.Warning("null");
                    }
                }
            }
        }
    }
}
