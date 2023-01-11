using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace WisenetIPCameraTool
{
	public partial class MainForm : MaterialForm
	{
		private readonly IPCamera ipCamera;
		private readonly DeviceDiscoverer discoverer;
		public MainForm()
		{
			InitializeComponent();			
            discoverer = new DeviceDiscoverer();
            discoverer.Discover += DeviceDiscoverer_Discover;
            discoverer.Start();

            ipCamera = new IPCamera(this);
		
			//ipCamera.Login("YOUR_USER_NAME", "YOUR_PW");
		}

		#region BUTTON

		private void PanBtn_Click(object sender, EventArgs e)
		{
			_ = ipCamera.PanAsync(PanSlt.Text);
		}

		private void TiltBtn_Click(object sender, EventArgs e)
		{
			_ = ipCamera.TiltAsync(TiltSlt.Text);
		}

		private void ZoomBtn_Click(object sender, EventArgs e)
		{
			_ = ipCamera.ZoomAsync(ZoomSlt.Text);
		}

		private void MoveBtn_Click(object sender, EventArgs e)
		{
			_ = ipCamera.PTZAsync(PanSlt.Text, TiltSlt.Text, ZoomSlt.Text);
		}

		private void GotoHomePosBtn_Click(object sender, EventArgs e)
		{
			_ = ipCamera.GotoHomePositionAsync();
		}

		private void SetHomePosBtn_Click(object sender, EventArgs e)
		{
			_ = ipCamera.SetHomePositionAsync();
		}

        private void DiscoverNowBtn_Click(object sender, EventArgs e)
        {
			discoverer.DiscoverNow();
        }

        #endregion

        private void OsdCbox_CheckedChanged(object sender, EventArgs e)
		{
			_ = ipCamera.OsdAsync(OsdCbox.Checked);
		}

		public void WriteLog(string msg)
		{
            SetControlUI(LogRtbox, () => LogRtbox.AppendText(msg + "\n"));
		}


		private void DeviceDiscoverer_Discover(object sender, DeviceDiscoverer.DiscoveredEventArgs e)
		{
			var ip = e.IpAddress;

			if (DiscoveredDevicesLbox.Items.Contains(ip))
			{
				return;
			}

			SetControlUI(DiscoveredDevicesLbox, () => DiscoveredDevicesLbox.Items.Add(ip));
			WriteLog($"New Device Discovered : {ip}");
		}

		private void DiscoveredDevicesLbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedIp = DiscoveredDevicesLbox.SelectedItem.ToString();
			//CurrentIpSlt.Text = selectedIp;
			ipCamera.SetIP(selectedIp);
		}

		private void AbsoluteRdo_CheckedChanged(object sender, EventArgs e)
		{
			ipCamera.ptzMode = AbsoluteRdo.Checked ? "absolute" : "relative";
        }

		private delegate void ControlDelegate(Control ctrl, Action Func);
		private void SetControlUI(Control ctrl, Action Func)
		{
			if (ctrl.InvokeRequired)
			{
				ControlDelegate delegateCallback = new ControlDelegate(SetControlUI);
				this.Invoke(delegateCallback, new object[] { ctrl, Func });
			}
			else
			{
				Func();
			}
		}
    }
}
