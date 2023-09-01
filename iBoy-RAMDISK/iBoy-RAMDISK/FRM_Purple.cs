using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

// Token: 0x02000016 RID: 22
public partial class FRM_Purple : MetroForm
{
	// Token: 0x06000073 RID: 115 RVA: 0x000084EC File Offset: 0x000066EC
	public FRM_Purple()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000074 RID: 116 RVA: 0x0000850C File Offset: 0x0000670C
	private void metroButton3_Click(object sender, EventArgs e)
	{
		this.string_0 = "boot_purple";
		this.backgroundWorker_0.RunWorkerAsync();
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00008530 File Offset: 0x00006730
	private void FRM_Purple_Load(object sender, EventArgs e)
	{
		string[] portNames = SerialPort.GetPortNames();
		ComboBox.ObjectCollection items = this.cBoxPORT.Items;
		object[] array = portNames;
		items.AddRange(array);
		this.metroButton1.Enabled = false;
		this.btn_Reboot.Enabled = false;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00008570 File Offset: 0x00006770
	private void btn_connect_Click(object sender, EventArgs e)
	{
		if (this.serialPort_0.IsOpen)
		{
			this.method_0();
		}
		else
		{
			try
			{
				this.serialPort_0.PortName = this.cBoxPORT.Text;
				this.serialPort_0.BaudRate = 115200;
				this.serialPort_0.DataBits = 8;
				this.serialPort_0.Open();
				this.btn_connect.Text = "CLOSE PORT";
				this.metroButton1.Enabled = true;
				this.btn_Reboot.Enabled = true;
				this.metroButton4.Enabled = false;
				this.cBoxPORT.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}

	// Token: 0x06000077 RID: 119 RVA: 0x0000863C File Offset: 0x0000683C
	public void method_0()
	{
		this.serialPort_0.Close();
		this.btn_connect.Text = "OPEN PORT";
		this.metroButton4.Enabled = true;
		this.cBoxPORT.Enabled = true;
		this.metroButton1.Enabled = false;
		this.btn_Reboot.Enabled = false;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00008694 File Offset: 0x00006894
	private void metroButton4_Click(object sender, EventArgs e)
	{
		string[] portNames = SerialPort.GetPortNames();
		this.cBoxPORT.Items.Clear();
		ComboBox.ObjectCollection items = this.cBoxPORT.Items;
		object[] array = portNames;
		items.AddRange(array);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x000086CC File Offset: 0x000068CC
	private void btn_Reboot_Click(object sender, EventArgs e)
	{
		if (this.serialPort_0.IsOpen)
		{
			try
			{
				this.serialPort_0.WriteLine("reset");
				this.method_0();
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
		}
		MessageBox.Show("No COM-PORT Open", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0000873C File Offset: 0x0000693C
	private void metroButton1_Click(object sender, EventArgs e)
	{
		if (this.serialPort_0.IsOpen)
		{
			try
			{
				this.serialPort_0.WriteLine("Syscfg add SrNm " + this.metroTextBox1.Text);
				MessageBox.Show("Successfull Change Serial to " + this.metroTextBox1.Text, "Success !!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.serialPort_0.WriteLine("reset");
				this.method_0();
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
		}
		MessageBox.Show("No COM-PORT Open \nPlease open port first!!", "Error No SerialPort Open!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x000087EC File Offset: 0x000069EC
	private void metroButton5_Click(object sender, EventArgs e)
	{
		if (this.serialPort_0.IsOpen)
		{
			try
			{
				this.serialPort_0.WriteLine("Syscfg print SrNm");
				string text = this.serialPort_0.ReadExisting();
				MessageBox.Show("Successfull Change Serial to " + text, "Success !!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
		}
		MessageBox.Show("No COM-PORT Open \nPlease open port first!!", "Error No SerialPort Open!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00008878 File Offset: 0x00006A78
	private void metroButton2_Click(object sender, EventArgs e)
	{
		if (this.serialPort_0.IsOpen)
		{
			try
			{
				this.serialPort_0.WriteLine("Syscfg add Regn PA/A");
				this.serialPort_0.ReadExisting();
				MessageBox.Show("Successfull Change Serial to PA/A", "Success !!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
		}
		MessageBox.Show("No COM-PORT Open \nPlease open port first!!", "Error No SerialPort Open!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00008900 File Offset: 0x00006B00
	private void method_1(object sender, DoWorkEventArgs e)
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00008910 File Offset: 0x00006B10
	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		Class25 @class = new Class25();
		if (!@class.method_0(this.string_0, Class19.string_2))
		{
			FRM_Purple.Class10 class2 = new FRM_Purple.Class10();
			class2.string_0 = "";
			if (this.string_0 == "boot_purple")
			{
				class2.string_0 = "Bypass Hello iOS 15";
			}
			base.Invoke(new MethodInvoker(class2.method_0));
		}
		else if (this.string_0 == "boot_purple")
		{
			Class17 class3 = new Class17();
			class3.method_0();
		}
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0000899C File Offset: 0x00006B9C
	protected virtual void MetroFramework.Forms.MetroForm.Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00009364 File Offset: 0x00007564
	void method_2(MetroThemeStyle metroThemeStyle_0)
	{
		base.Theme = metroThemeStyle_0;
	}

	// Token: 0x0400003E RID: 62
	private string string_0;

	// Token: 0x0400003F RID: 63
	public string string_1;

	// Token: 0x02000017 RID: 23
	[CompilerGenerated]
	private sealed class Class10
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00009378 File Offset: 0x00007578
		internal void method_0()
		{
			MessageBox.Show("ECID : " + Class19.string_2 + " is Not Authorized !\nPlease Register ECID as " + this.string_0, "NOT REGISTERED", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0400004F RID: 79
		public string string_0;
	}
}
