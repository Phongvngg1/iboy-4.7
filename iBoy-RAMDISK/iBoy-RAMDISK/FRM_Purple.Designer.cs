// Token: 0x02000016 RID: 22
public partial class FRM_Purple : global::MetroFramework.Forms.MetroForm
{
	// Token: 0x06000080 RID: 128 RVA: 0x000089CC File Offset: 0x00006BCC
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FRM_Purple));
		this.serialPort_0 = new global::System.IO.Ports.SerialPort(this.icontainer_0);
		this.metroButton5 = new global::MetroFramework.Controls.MetroButton();
		this.metroButton4 = new global::MetroFramework.Controls.MetroButton();
		this.metroButton3 = new global::MetroFramework.Controls.MetroButton();
		this.metroLabel2 = new global::MetroFramework.Controls.MetroLabel();
		this.metroTextBox1 = new global::MetroFramework.Controls.MetroTextBox();
		this.btn_Reboot = new global::MetroFramework.Controls.MetroButton();
		this.metroButton1 = new global::MetroFramework.Controls.MetroButton();
		this.btn_connect = new global::MetroFramework.Controls.MetroButton();
		this.metroLabel1 = new global::MetroFramework.Controls.MetroLabel();
		this.cBoxPORT = new global::System.Windows.Forms.ComboBox();
		this.metroLabel3 = new global::MetroFramework.Controls.MetroLabel();
		this.metroButton2 = new global::MetroFramework.Controls.MetroButton();
		this.backgroundWorker_0 = new global::System.ComponentModel.BackgroundWorker();
		base.SuspendLayout();
		this.metroButton5.Enabled = false;
		this.metroButton5.Location = new global::System.Drawing.Point(12, 164);
		this.metroButton5.Name = "metroButton5";
		this.metroButton5.Size = new global::System.Drawing.Size(79, 23);
		this.metroButton5.TabIndex = 25;
		this.metroButton5.Text = "Backup SN";
		this.metroButton5.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.metroButton5.UseSelectable = true;
		this.metroButton5.Click += new global::System.EventHandler(this.metroButton5_Click);
		this.metroButton4.Location = new global::System.Drawing.Point(238, 103);
		this.metroButton4.Name = "metroButton4";
		this.metroButton4.Size = new global::System.Drawing.Size(75, 23);
		this.metroButton4.TabIndex = 23;
		this.metroButton4.Text = "Refresh";
		this.metroButton4.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.metroButton4.UseSelectable = true;
		this.metroButton4.Click += new global::System.EventHandler(this.metroButton4_Click);
		this.metroButton3.Location = new global::System.Drawing.Point(12, 70);
		this.metroButton3.Name = "metroButton3";
		this.metroButton3.Size = new global::System.Drawing.Size(111, 23);
		this.metroButton3.TabIndex = 22;
		this.metroButton3.Text = "BOOT PURPLE";
		this.metroButton3.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.metroButton3.UseSelectable = true;
		this.metroButton3.Click += new global::System.EventHandler(this.metroButton3_Click);
		this.metroLabel2.AutoSize = true;
		this.metroLabel2.Location = new global::System.Drawing.Point(8, 136);
		this.metroLabel2.Name = "metroLabel2";
		this.metroLabel2.Size = new global::System.Drawing.Size(83, 19);
		this.metroLabel2.TabIndex = 21;
		this.metroLabel2.Text = "NEW SERIAL";
		this.metroLabel2.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.metroTextBox1.CustomButton.Image = null;
		this.metroTextBox1.CustomButton.Location = new global::System.Drawing.Point(99, 1);
		this.metroTextBox1.CustomButton.Name = "";
		this.metroTextBox1.CustomButton.Size = new global::System.Drawing.Size(21, 21);
		this.metroTextBox1.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
		this.metroTextBox1.CustomButton.TabIndex = 1;
		this.metroTextBox1.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
		this.metroTextBox1.CustomButton.UseSelectable = true;
		this.metroTextBox1.CustomButton.Visible = false;
		this.metroTextBox1.Lines = new string[] { "F97SF2AQFFGD" };
		this.metroTextBox1.Location = new global::System.Drawing.Point(111, 132);
		this.metroTextBox1.MaxLength = 32767;
		this.metroTextBox1.Name = "metroTextBox1";
		this.metroTextBox1.PasswordChar = '\0';
		this.metroTextBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
		this.metroTextBox1.SelectedText = "";
		this.metroTextBox1.SelectionLength = 0;
		this.metroTextBox1.SelectionStart = 0;
		this.metroTextBox1.ShortcutsEnabled = true;
		this.metroTextBox1.Size = new global::System.Drawing.Size(121, 23);
		this.metroTextBox1.TabIndex = 20;
		this.metroTextBox1.Text = "F97SF2AQFFGD";
		this.metroTextBox1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.metroTextBox1.UseSelectable = true;
		this.metroTextBox1.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
		this.metroTextBox1.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
		this.btn_Reboot.Location = new global::System.Drawing.Point(97, 164);
		this.btn_Reboot.Name = "btn_Reboot";
		this.btn_Reboot.Size = new global::System.Drawing.Size(82, 23);
		this.btn_Reboot.TabIndex = 19;
		this.btn_Reboot.Text = "REBOOT";
		this.btn_Reboot.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_Reboot.UseSelectable = true;
		this.btn_Reboot.Click += new global::System.EventHandler(this.btn_Reboot_Click);
		this.metroButton1.Location = new global::System.Drawing.Point(238, 132);
		this.metroButton1.Name = "metroButton1";
		this.metroButton1.Size = new global::System.Drawing.Size(75, 23);
		this.metroButton1.TabIndex = 18;
		this.metroButton1.Text = "Write SN";
		this.metroButton1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.metroButton1.UseSelectable = true;
		this.metroButton1.Click += new global::System.EventHandler(this.metroButton1_Click);
		this.btn_connect.Location = new global::System.Drawing.Point(203, 70);
		this.btn_connect.Name = "btn_connect";
		this.btn_connect.Size = new global::System.Drawing.Size(113, 23);
		this.btn_connect.TabIndex = 17;
		this.btn_connect.Text = "OPEN SERIAL";
		this.btn_connect.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_connect.UseSelectable = true;
		this.btn_connect.Click += new global::System.EventHandler(this.btn_connect_Click);
		this.metroLabel1.AutoSize = true;
		this.metroLabel1.Location = new global::System.Drawing.Point(12, 101);
		this.metroLabel1.Name = "metroLabel1";
		this.metroLabel1.Size = new global::System.Drawing.Size(79, 19);
		this.metroLabel1.TabIndex = 16;
		this.metroLabel1.Text = "COM PORT";
		this.metroLabel1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.cBoxPORT.FormattingEnabled = true;
		this.cBoxPORT.Location = new global::System.Drawing.Point(111, 103);
		this.cBoxPORT.Name = "cBoxPORT";
		this.cBoxPORT.Size = new global::System.Drawing.Size(121, 21);
		this.cBoxPORT.TabIndex = 15;
		this.metroLabel3.AutoSize = true;
		this.metroLabel3.FontSize = global::MetroFramework.MetroLabelSize.Small;
		this.metroLabel3.Location = new global::System.Drawing.Point(92, 203);
		this.metroLabel3.Name = "metroLabel3";
		this.metroLabel3.Size = new global::System.Drawing.Size(140, 15);
		this.metroLabel3.TabIndex = 26;
		this.metroLabel3.Text = "iPhone 7 - X without DCSD";
		this.metroLabel3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.metroLabel3.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.metroButton2.Location = new global::System.Drawing.Point(185, 164);
		this.metroButton2.Name = "metroButton2";
		this.metroButton2.Size = new global::System.Drawing.Size(128, 23);
		this.metroButton2.TabIndex = 27;
		this.metroButton2.Text = "CHANGE REG PA/A";
		this.metroButton2.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.metroButton2.UseSelectable = true;
		this.metroButton2.Click += new global::System.EventHandler(this.metroButton2_Click);
		this.backgroundWorker_0.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_0_DoWork);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(328, 229);
		base.Controls.Add(this.metroButton2);
		base.Controls.Add(this.metroLabel3);
		base.Controls.Add(this.metroButton5);
		base.Controls.Add(this.metroButton4);
		base.Controls.Add(this.metroButton3);
		base.Controls.Add(this.metroLabel2);
		base.Controls.Add(this.metroTextBox1);
		base.Controls.Add(this.btn_Reboot);
		base.Controls.Add(this.metroButton1);
		base.Controls.Add(this.btn_connect);
		base.Controls.Add(this.metroLabel1);
		base.Controls.Add(this.cBoxPORT);
		base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FRM_Purple";
		base.Resizable = false;
		base.ShowIcon = false;
		this.Text = "iBoy Purple (A10-A11)";
		base.TextAlign = global::MetroFramework.Forms.MetroFormTextAlign.Center;
		this.method_2(global::MetroFramework.MetroThemeStyle.Dark);
		base.Load += new global::System.EventHandler(this.FRM_Purple_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000040 RID: 64
	private global::System.ComponentModel.IContainer icontainer_0 = null;

	// Token: 0x04000041 RID: 65
	private global::System.IO.Ports.SerialPort serialPort_0;

	// Token: 0x04000042 RID: 66
	private global::MetroFramework.Controls.MetroButton metroButton5;

	// Token: 0x04000043 RID: 67
	private global::MetroFramework.Controls.MetroButton metroButton4;

	// Token: 0x04000044 RID: 68
	private global::MetroFramework.Controls.MetroButton metroButton3;

	// Token: 0x04000045 RID: 69
	private global::MetroFramework.Controls.MetroLabel metroLabel2;

	// Token: 0x04000046 RID: 70
	private global::MetroFramework.Controls.MetroTextBox metroTextBox1;

	// Token: 0x04000047 RID: 71
	private global::MetroFramework.Controls.MetroButton btn_Reboot;

	// Token: 0x04000048 RID: 72
	private global::MetroFramework.Controls.MetroButton metroButton1;

	// Token: 0x04000049 RID: 73
	private global::MetroFramework.Controls.MetroButton btn_connect;

	// Token: 0x0400004A RID: 74
	private global::MetroFramework.Controls.MetroLabel metroLabel1;

	// Token: 0x0400004B RID: 75
	private global::System.Windows.Forms.ComboBox cBoxPORT;

	// Token: 0x0400004C RID: 76
	private global::MetroFramework.Controls.MetroLabel metroLabel3;

	// Token: 0x0400004D RID: 77
	private global::MetroFramework.Controls.MetroButton metroButton2;

	// Token: 0x0400004E RID: 78
	private global::System.ComponentModel.BackgroundWorker backgroundWorker_0;
}
