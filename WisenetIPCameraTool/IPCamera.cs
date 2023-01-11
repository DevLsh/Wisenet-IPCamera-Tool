using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WisenetIPCameraTool
{
    public class IPCamera
    {
        private string cameraIp;
        public string ptzMode = "absolute";
        private NetworkCredential networkCredential;
        private readonly MainForm parent; 

        public IPCamera(MainForm parent)
        {
            this.parent = parent;
        }        

        // Call by login button
        public void Login(string userName, string password)
		{
            networkCredential = new NetworkCredential(userName, password);
		}

        public void SetIP(string ip)
		{
            this.cameraIp = ip;
            parent.CurrentIpSlt.Text = ip;
		}


        public async Task PanAsync(string value)
        {
            if (!double.TryParse(value, out _))
            {
                parent.WriteLog($"Pan Value Error: {value}");
                return;
            }
            await PTZCtrlAsync("Pan=" + value);
        }

        public async Task TiltAsync(string value)
        {
            if (!double.TryParse(value, out _))
            {
                parent.WriteLog($"Tilt Value Error: {value}");
                return;
            }

            await PTZCtrlAsync("Tilt=" + value);
        }

        public async Task ZoomAsync(string value)
        {
            if (!double.TryParse(value, out _))
            {
                parent.WriteLog($"Zoom Value Error: {value}");
                return;
            }
            await PTZCtrlAsync("Zoom=" + value);
        }

        public async Task PTZAsync(string pan, string tilt, string zoom)
        {
            if (!double.TryParse(pan + tilt + zoom, out var _))
            {
                parent.WriteLog($"Value Error: {pan}, {tilt}, {zoom}");
                return;
            }
            await PTZCtrlAsync($"Pan={pan}&Tilt={tilt}&Zoom={zoom}");
        }

        private async Task PTZCtrlAsync(string PTZ)
        {
            try
            {
                var request = $"http://{cameraIp}/stw-cgi/ptzcontrol.cgi?msubmenu={ptzMode}&action=control&{PTZ}";
                //parent.WriteLog(request);
                parent.WriteLog($"PTZ {ptzMode} : {PTZ}");
                var res = await WebRequestAsync(request);
                res.Dispose();
            }
            catch (Exception ex)
            {
                //parent.WriteLog(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public async Task OsdAsync(bool enable)
        {
            try
            {
                var request = $"http://{cameraIp}/stw-cgi/image.cgi?msubmenu=multilineosd&action=update&Index=6&OSDType=Date&Enable={enable}";
                parent.WriteLog($"OSD Enable : {enable}");
                var res = await WebRequestAsync(request);
                res.Dispose();
            }
            catch (Exception ex)
            {
                //parent.WriteLog(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public async Task ConfigBackupAsync()
        {
            try
            {
                var request = $"http://{cameraIp}/stw-cgi/system.cgi?msubmenu=configbackup&action=control&SunapiSeqId=27";
                parent.WriteLog("Config backup Started");
                var res = await WebRequestAsync(request);

                var configFilePath = Path.Combine(Directory.GetCurrentDirectory(), $"{DateTime.Now.ToString("ddHHmmss")}IPCamConfig.bin");
                using (var configFileStream = File.OpenWrite(configFilePath))
                using (var resStream = res.GetResponseStream())
                {
                    resStream.CopyTo(configFileStream);
                    parent.WriteLog(configFilePath + " Saved");
                }
            }
            catch (Exception ex)
            {
                //parent.WriteLog(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        public async Task SetHomePositionAsync()
        {
            try
            {
                var request = $"http://{cameraIp}/stw-cgi/ptzconfig.cgi?msubmenu=home&action=set&Channel=0&SunapiSeqId=42";
                parent.WriteLog(nameof(SetHomePositionAsync));
                var res = await WebRequestAsync(request);
                res.Dispose();
            }
            catch (Exception ex)
            {
                //parent.WriteLog(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public async Task GotoHomePositionAsync()
        {
            try
            {
                var request = $"http://{cameraIp}/stw-cgi/ptzcontrol.cgi?msubmenu=home&action=control&Channel=0&SunapiSeqId=49";
                parent.WriteLog(nameof(GotoHomePositionAsync));
                var res = await WebRequestAsync(request);
                res.Dispose();
            }
            catch (Exception ex)
            {
                //parent.WriteLog(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public async Task<WebResponse> WebRequestAsync(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.Timeout = 10000;
            webRequest.Credentials = networkCredential;
            webRequest.UserAgent = "Mozilla/5.0";
            webRequest.Method = "Get";
            webRequest.ContentLength = 0;
            webRequest.AllowWriteStreamBuffering = false;

            return await webRequest.GetResponseAsync();
        }

    }
}
