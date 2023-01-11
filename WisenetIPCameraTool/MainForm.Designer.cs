namespace WisenetIPCameraTool
{
	partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DeviceDiscoverGbox = new System.Windows.Forms.GroupBox();
            this.OsdCbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.CurrentIpSlt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DiscoveredDevicesLbox = new System.Windows.Forms.ListBox();
            this.nowIp_lb = new MaterialSkin.Controls.MaterialLabel();
            this.PtzGbox = new System.Windows.Forms.GroupBox();
            this.GotoHomePosPtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SetHomePosBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RelativeRdo = new MaterialSkin.Controls.MaterialRadioButton();
            this.AbsoluteRdo = new MaterialSkin.Controls.MaterialRadioButton();
            this.MoveBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ZoomBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TiltBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PanBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PanSlt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ZoomSlt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TiltSlt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogRtbox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DiscoverNowBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeviceDiscoverGbox.SuspendLayout();
            this.PtzGbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeviceDiscoverGbox
            // 
            this.DeviceDiscoverGbox.BackColor = System.Drawing.Color.White;
            this.DeviceDiscoverGbox.Controls.Add(this.DiscoverNowBtn);
            this.DeviceDiscoverGbox.Controls.Add(this.OsdCbox);
            this.DeviceDiscoverGbox.Controls.Add(this.materialLabel1);
            this.DeviceDiscoverGbox.Controls.Add(this.CurrentIpSlt);
            this.DeviceDiscoverGbox.Controls.Add(this.DiscoveredDevicesLbox);
            this.DeviceDiscoverGbox.Controls.Add(this.nowIp_lb);
            this.DeviceDiscoverGbox.Location = new System.Drawing.Point(12, 3);
            this.DeviceDiscoverGbox.Name = "DeviceDiscoverGbox";
            this.DeviceDiscoverGbox.Size = new System.Drawing.Size(154, 222);
            this.DeviceDiscoverGbox.TabIndex = 0;
            this.DeviceDiscoverGbox.TabStop = false;
            this.DeviceDiscoverGbox.Text = "Devices";
            // 
            // OsdCbox
            // 
            this.OsdCbox.AutoSize = true;
            this.OsdCbox.Checked = true;
            this.OsdCbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OsdCbox.Depth = 0;
            this.OsdCbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.OsdCbox.Location = new System.Drawing.Point(10, 189);
            this.OsdCbox.Margin = new System.Windows.Forms.Padding(0);
            this.OsdCbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OsdCbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.OsdCbox.Name = "OsdCbox";
            this.OsdCbox.Ripple = true;
            this.OsdCbox.Size = new System.Drawing.Size(57, 30);
            this.OsdCbox.TabIndex = 18;
            this.OsdCbox.Text = "OSD";
            this.OsdCbox.UseVisualStyleBackColor = true;
            this.OsdCbox.CheckedChanged += new System.EventHandler(this.OsdCbox_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(7, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(141, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Discoverd Devices :";
            // 
            // CurrentIpSlt
            // 
            this.CurrentIpSlt.Depth = 0;
            this.CurrentIpSlt.Hint = "";
            this.CurrentIpSlt.Location = new System.Drawing.Point(10, 39);
            this.CurrentIpSlt.MouseState = MaterialSkin.MouseState.HOVER;
            this.CurrentIpSlt.Name = "CurrentIpSlt";
            this.CurrentIpSlt.PasswordChar = '\0';
            this.CurrentIpSlt.SelectedText = "";
            this.CurrentIpSlt.SelectionLength = 0;
            this.CurrentIpSlt.SelectionStart = 0;
            this.CurrentIpSlt.Size = new System.Drawing.Size(137, 23);
            this.CurrentIpSlt.TabIndex = 3;
            this.CurrentIpSlt.Text = "-";
            this.CurrentIpSlt.UseSystemPasswordChar = false;
            // 
            // DiscoveredDevicesLbox
            // 
            this.DiscoveredDevicesLbox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DiscoveredDevicesLbox.FormattingEnabled = true;
            this.DiscoveredDevicesLbox.ItemHeight = 21;
            this.DiscoveredDevicesLbox.Location = new System.Drawing.Point(10, 97);
            this.DiscoveredDevicesLbox.Name = "DiscoveredDevicesLbox";
            this.DiscoveredDevicesLbox.Size = new System.Drawing.Size(138, 88);
            this.DiscoveredDevicesLbox.TabIndex = 2;
            this.DiscoveredDevicesLbox.SelectedIndexChanged += new System.EventHandler(this.DiscoveredDevicesLbox_SelectedIndexChanged);
            // 
            // nowIp_lb
            // 
            this.nowIp_lb.AutoSize = true;
            this.nowIp_lb.Depth = 0;
            this.nowIp_lb.Font = new System.Drawing.Font("Roboto", 11F);
            this.nowIp_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nowIp_lb.Location = new System.Drawing.Point(6, 17);
            this.nowIp_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.nowIp_lb.Name = "nowIp_lb";
            this.nowIp_lb.Size = new System.Drawing.Size(124, 19);
            this.nowIp_lb.TabIndex = 0;
            this.nowIp_lb.Text = "Now Connected :";
            // 
            // PtzGbox
            // 
            this.PtzGbox.BackColor = System.Drawing.Color.White;
            this.PtzGbox.Controls.Add(this.GotoHomePosPtn);
            this.PtzGbox.Controls.Add(this.SetHomePosBtn);
            this.PtzGbox.Controls.Add(this.RelativeRdo);
            this.PtzGbox.Controls.Add(this.AbsoluteRdo);
            this.PtzGbox.Controls.Add(this.MoveBtn);
            this.PtzGbox.Controls.Add(this.ZoomBtn);
            this.PtzGbox.Controls.Add(this.TiltBtn);
            this.PtzGbox.Controls.Add(this.PanBtn);
            this.PtzGbox.Controls.Add(this.PanSlt);
            this.PtzGbox.Controls.Add(this.ZoomSlt);
            this.PtzGbox.Controls.Add(this.TiltSlt);
            this.PtzGbox.Location = new System.Drawing.Point(172, 3);
            this.PtzGbox.Name = "PtzGbox";
            this.PtzGbox.Size = new System.Drawing.Size(156, 222);
            this.PtzGbox.TabIndex = 5;
            this.PtzGbox.TabStop = false;
            this.PtzGbox.Text = "PTZ";
            // 
            // GotoHomePosPtn
            // 
            this.GotoHomePosPtn.BackColor = System.Drawing.Color.Transparent;
            this.GotoHomePosPtn.Depth = 0;
            this.GotoHomePosPtn.FlatAppearance.BorderSize = 0;
            this.GotoHomePosPtn.Location = new System.Drawing.Point(6, 148);
            this.GotoHomePosPtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.GotoHomePosPtn.Name = "GotoHomePosPtn";
            this.GotoHomePosPtn.Primary = true;
            this.GotoHomePosPtn.Size = new System.Drawing.Size(69, 37);
            this.GotoHomePosPtn.TabIndex = 20;
            this.GotoHomePosPtn.Text = "Goto Home";
            this.GotoHomePosPtn.UseVisualStyleBackColor = false;
            this.GotoHomePosPtn.Click += new System.EventHandler(this.GotoHomePosBtn_Click);
            // 
            // SetHomePosBtn
            // 
            this.SetHomePosBtn.Depth = 0;
            this.SetHomePosBtn.Location = new System.Drawing.Point(81, 148);
            this.SetHomePosBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SetHomePosBtn.Name = "SetHomePosBtn";
            this.SetHomePosBtn.Primary = true;
            this.SetHomePosBtn.Size = new System.Drawing.Size(69, 37);
            this.SetHomePosBtn.TabIndex = 19;
            this.SetHomePosBtn.Text = "Set Home";
            this.SetHomePosBtn.UseVisualStyleBackColor = true;
            this.SetHomePosBtn.Click += new System.EventHandler(this.SetHomePosBtn_Click);
            // 
            // RelativeRdo
            // 
            this.RelativeRdo.AutoSize = true;
            this.RelativeRdo.Depth = 0;
            this.RelativeRdo.Font = new System.Drawing.Font("Roboto", 10F);
            this.RelativeRdo.Location = new System.Drawing.Point(81, 188);
            this.RelativeRdo.Margin = new System.Windows.Forms.Padding(0);
            this.RelativeRdo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RelativeRdo.MouseState = MaterialSkin.MouseState.HOVER;
            this.RelativeRdo.Name = "RelativeRdo";
            this.RelativeRdo.Ripple = true;
            this.RelativeRdo.Size = new System.Drawing.Size(53, 30);
            this.RelativeRdo.TabIndex = 16;
            this.RelativeRdo.Text = "REL";
            this.RelativeRdo.UseVisualStyleBackColor = true;
            // 
            // AbsoluteRdo
            // 
            this.AbsoluteRdo.AutoSize = true;
            this.AbsoluteRdo.Checked = true;
            this.AbsoluteRdo.Depth = 0;
            this.AbsoluteRdo.Font = new System.Drawing.Font("Roboto", 10F);
            this.AbsoluteRdo.Location = new System.Drawing.Point(6, 188);
            this.AbsoluteRdo.Margin = new System.Windows.Forms.Padding(0);
            this.AbsoluteRdo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AbsoluteRdo.MouseState = MaterialSkin.MouseState.HOVER;
            this.AbsoluteRdo.Name = "AbsoluteRdo";
            this.AbsoluteRdo.Ripple = true;
            this.AbsoluteRdo.Size = new System.Drawing.Size(55, 30);
            this.AbsoluteRdo.TabIndex = 15;
            this.AbsoluteRdo.TabStop = true;
            this.AbsoluteRdo.Text = "ABS";
            this.AbsoluteRdo.UseVisualStyleBackColor = true;
            this.AbsoluteRdo.CheckedChanged += new System.EventHandler(this.AbsoluteRdo_CheckedChanged);
            // 
            // MoveBtn
            // 
            this.MoveBtn.Depth = 0;
            this.MoveBtn.Location = new System.Drawing.Point(6, 104);
            this.MoveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.MoveBtn.Name = "MoveBtn";
            this.MoveBtn.Primary = true;
            this.MoveBtn.Size = new System.Drawing.Size(144, 38);
            this.MoveBtn.TabIndex = 14;
            this.MoveBtn.Text = "Move";
            this.MoveBtn.UseVisualStyleBackColor = true;
            this.MoveBtn.Click += new System.EventHandler(this.MoveBtn_Click);
            // 
            // ZoomBtn
            // 
            this.ZoomBtn.Depth = 0;
            this.ZoomBtn.Location = new System.Drawing.Point(81, 75);
            this.ZoomBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZoomBtn.Name = "ZoomBtn";
            this.ZoomBtn.Primary = true;
            this.ZoomBtn.Size = new System.Drawing.Size(69, 23);
            this.ZoomBtn.TabIndex = 10;
            this.ZoomBtn.Text = "Zoom";
            this.ZoomBtn.UseVisualStyleBackColor = true;
            this.ZoomBtn.Click += new System.EventHandler(this.ZoomBtn_Click);
            // 
            // TiltBtn
            // 
            this.TiltBtn.Depth = 0;
            this.TiltBtn.Location = new System.Drawing.Point(81, 46);
            this.TiltBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TiltBtn.Name = "TiltBtn";
            this.TiltBtn.Primary = true;
            this.TiltBtn.Size = new System.Drawing.Size(69, 23);
            this.TiltBtn.TabIndex = 9;
            this.TiltBtn.Text = "Tilt";
            this.TiltBtn.UseVisualStyleBackColor = true;
            this.TiltBtn.Click += new System.EventHandler(this.TiltBtn_Click);
            // 
            // PanBtn
            // 
            this.PanBtn.Depth = 0;
            this.PanBtn.Location = new System.Drawing.Point(81, 17);
            this.PanBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.PanBtn.Name = "PanBtn";
            this.PanBtn.Primary = true;
            this.PanBtn.Size = new System.Drawing.Size(69, 23);
            this.PanBtn.TabIndex = 8;
            this.PanBtn.Text = "Pan";
            this.PanBtn.UseVisualStyleBackColor = true;
            this.PanBtn.Click += new System.EventHandler(this.PanBtn_Click);
            // 
            // PanSlt
            // 
            this.PanSlt.Depth = 0;
            this.PanSlt.Hint = "";
            this.PanSlt.Location = new System.Drawing.Point(6, 17);
            this.PanSlt.MouseState = MaterialSkin.MouseState.HOVER;
            this.PanSlt.Name = "PanSlt";
            this.PanSlt.PasswordChar = '\0';
            this.PanSlt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PanSlt.SelectedText = "";
            this.PanSlt.SelectionLength = 0;
            this.PanSlt.SelectionStart = 0;
            this.PanSlt.Size = new System.Drawing.Size(69, 23);
            this.PanSlt.TabIndex = 3;
            this.PanSlt.Text = "0";
            this.PanSlt.UseSystemPasswordChar = false;
            // 
            // ZoomSlt
            // 
            this.ZoomSlt.Depth = 0;
            this.ZoomSlt.Hint = "";
            this.ZoomSlt.Location = new System.Drawing.Point(6, 75);
            this.ZoomSlt.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZoomSlt.Name = "ZoomSlt";
            this.ZoomSlt.PasswordChar = '\0';
            this.ZoomSlt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ZoomSlt.SelectedText = "";
            this.ZoomSlt.SelectionLength = 0;
            this.ZoomSlt.SelectionStart = 0;
            this.ZoomSlt.Size = new System.Drawing.Size(69, 23);
            this.ZoomSlt.TabIndex = 7;
            this.ZoomSlt.Text = "0";
            this.ZoomSlt.UseSystemPasswordChar = false;
            // 
            // TiltSlt
            // 
            this.TiltSlt.Depth = 0;
            this.TiltSlt.Hint = "";
            this.TiltSlt.Location = new System.Drawing.Point(6, 46);
            this.TiltSlt.MouseState = MaterialSkin.MouseState.HOVER;
            this.TiltSlt.Name = "TiltSlt";
            this.TiltSlt.PasswordChar = '\0';
            this.TiltSlt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TiltSlt.SelectedText = "";
            this.TiltSlt.SelectionLength = 0;
            this.TiltSlt.SelectionStart = 0;
            this.TiltSlt.Size = new System.Drawing.Size(69, 23);
            this.TiltSlt.TabIndex = 5;
            this.TiltSlt.Text = "0";
            this.TiltSlt.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DeviceDiscoverGbox);
            this.panel1.Controls.Add(this.PtzGbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 285);
            this.panel1.TabIndex = 6;
            // 
            // LogRtbox
            // 
            this.LogRtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogRtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogRtbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogRtbox.Location = new System.Drawing.Point(3, 17);
            this.LogRtbox.Name = "LogRtbox";
            this.LogRtbox.Size = new System.Drawing.Size(310, 38);
            this.LogRtbox.TabIndex = 8;
            this.LogRtbox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogRtbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 58);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // DiscoverNowBtn
            // 
            this.DiscoverNowBtn.Depth = 0;
            this.DiscoverNowBtn.Location = new System.Drawing.Point(70, 189);
            this.DiscoverNowBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DiscoverNowBtn.Name = "DiscoverNowBtn";
            this.DiscoverNowBtn.Primary = true;
            this.DiscoverNowBtn.Size = new System.Drawing.Size(78, 31);
            this.DiscoverNowBtn.TabIndex = 21;
            this.DiscoverNowBtn.Text = "Discover Now";
            this.DiscoverNowBtn.UseVisualStyleBackColor = true;
            this.DiscoverNowBtn.Click += new System.EventHandler(this.DiscoverNowBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 349);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Wisenet IPCamera Tool";
            this.TopMost = true;
            this.DeviceDiscoverGbox.ResumeLayout(false);
            this.DeviceDiscoverGbox.PerformLayout();
            this.PtzGbox.ResumeLayout(false);
            this.PtzGbox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox DeviceDiscoverGbox;
		private MaterialSkin.Controls.MaterialCheckBox OsdCbox;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private System.Windows.Forms.ListBox DiscoveredDevicesLbox;
		private MaterialSkin.Controls.MaterialLabel nowIp_lb;
		private System.Windows.Forms.GroupBox PtzGbox;
		private MaterialSkin.Controls.MaterialRaisedButton GotoHomePosPtn;
		private MaterialSkin.Controls.MaterialRaisedButton SetHomePosBtn;
		private MaterialSkin.Controls.MaterialRadioButton RelativeRdo;
		private MaterialSkin.Controls.MaterialRadioButton AbsoluteRdo;
		private MaterialSkin.Controls.MaterialRaisedButton MoveBtn;
		private MaterialSkin.Controls.MaterialRaisedButton ZoomBtn;
		private MaterialSkin.Controls.MaterialRaisedButton TiltBtn;
		private MaterialSkin.Controls.MaterialRaisedButton PanBtn;
		private MaterialSkin.Controls.MaterialSingleLineTextField PanSlt;
		private MaterialSkin.Controls.MaterialSingleLineTextField ZoomSlt;
		private MaterialSkin.Controls.MaterialSingleLineTextField TiltSlt;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox LogRtbox;
        private System.Windows.Forms.GroupBox groupBox1;
        internal MaterialSkin.Controls.MaterialSingleLineTextField CurrentIpSlt;
        private MaterialSkin.Controls.MaterialRaisedButton DiscoverNowBtn;
    }
}

