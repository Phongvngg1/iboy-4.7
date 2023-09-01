// Token: 0x02000018 RID: 24
public partial class FRM_iBoy : global::MetroFramework.Forms.MetroForm
{
	// Token: 0x060000B6 RID: 182 RVA: 0x0000B240 File Offset: 0x00009440
	private void InitializeComponent()
	{
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FRM_iBoy));
		this.groupBox1 = new global::System.Windows.Forms.GroupBox();
		this.metroButton3 = new global::MetroFramework.Controls.MetroButton();
		this.metroButton2 = new global::MetroFramework.Controls.MetroButton();
		this.btn_driver = new global::MetroFramework.Controls.MetroButton();
		this.copyBox = new global::System.Windows.Forms.PictureBox();
		this.txt_RegStatus = new global::System.Windows.Forms.Label();
		this.label4 = new global::System.Windows.Forms.Label();
		this.txt_mode = new global::System.Windows.Forms.Label();
		this.label7 = new global::System.Windows.Forms.Label();
		this.lbl_pwned = new global::System.Windows.Forms.Label();
		this.txt_Type = new global::System.Windows.Forms.Label();
		this.label6 = new global::System.Windows.Forms.Label();
		this.label9 = new global::System.Windows.Forms.Label();
		this.txt_ECID = new global::System.Windows.Forms.Label();
		this.label3 = new global::System.Windows.Forms.Label();
		this.txt_model = new global::System.Windows.Forms.Label();
		this.label1 = new global::System.Windows.Forms.Label();
		this.progressBar1 = new global::MetroFramework.Controls.MetroProgressBar();
		this.groupBox5 = new global::System.Windows.Forms.GroupBox();
		this.btn_readHello = new global::MetroFramework.Controls.MetroButton();
		this.btn_get_activation = new global::MetroFramework.Controls.MetroButton();
		this.btn_act_hello = new global::MetroFramework.Controls.MetroButton();
		this.btn_changeSN = new global::MetroFramework.Controls.MetroButton();
		this.groupBox3 = new global::System.Windows.Forms.GroupBox();
		this.metroButton1 = new global::MetroFramework.Controls.MetroButton();
		this.btn_register = new global::MetroFramework.Controls.MetroButton();
		this.btn_backup = new global::MetroFramework.Controls.MetroButton();
		this.btn_activate = new global::MetroFramework.Controls.MetroButton();
		this.groupBox2 = new global::System.Windows.Forms.GroupBox();
		this.cBox = new global::MetroFramework.Controls.MetroCheckBox();
		this.btn_checkdev = new global::MetroFramework.Controls.MetroButton();
		this.btn_boot1 = new global::MetroFramework.Controls.MetroButton();
		this.btn_eraser = new global::MetroFramework.Controls.MetroButton();
		this.btn_checkSSH = new global::MetroFramework.Controls.MetroButton();
		this.txt_info = new global::System.Windows.Forms.Label();
		this.backgroundWorker_2 = new global::System.ComponentModel.BackgroundWorker();
		this.groupBox1.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.copyBox).BeginInit();
		this.groupBox5.SuspendLayout();
		this.groupBox3.SuspendLayout();
		this.groupBox2.SuspendLayout();
		base.SuspendLayout();
		this.groupBox1.Controls.Add(this.metroButton3);
		this.groupBox1.Controls.Add(this.metroButton2);
		this.groupBox1.Controls.Add(this.btn_driver);
		this.groupBox1.Controls.Add(this.copyBox);
		this.groupBox1.Controls.Add(this.txt_RegStatus);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.txt_mode);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.lbl_pwned);
		this.groupBox1.Controls.Add(this.txt_Type);
		this.groupBox1.Controls.Add(this.label6);
		this.groupBox1.Controls.Add(this.label9);
		this.groupBox1.Controls.Add(this.txt_ECID);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.txt_model);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.groupBox1.Font = new global::System.Drawing.Font("Tahoma", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.groupBox1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
		this.groupBox1.Location = new global::System.Drawing.Point(10, 63);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new global::System.Drawing.Size(457, 123);
		this.groupBox1.TabIndex = 2;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "iDevice Info";
		this.metroButton3.ForeColor = global::System.Drawing.SystemColors.ControlText;
		this.metroButton3.Location = new global::System.Drawing.Point(367, 53);
		this.metroButton3.Name = "metroButton3";
		this.metroButton3.Size = new global::System.Drawing.Size(80, 26);
		this.metroButton3.TabIndex = 27;
		this.metroButton3.Text = "Test No SN";
		this.metroButton3.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.metroButton3.UseSelectable = true;
		this.metroButton3.Visible = false;
		this.metroButton3.Click += new global::System.EventHandler(this.metroButton3_Click);
		this.metroButton2.ForeColor = global::System.Drawing.SystemColors.ControlText;
		this.metroButton2.Location = new global::System.Drawing.Point(371, 14);
		this.metroButton2.Name = "metroButton2";
		this.metroButton2.Size = new global::System.Drawing.Size(80, 26);
		this.metroButton2.TabIndex = 26;
		this.metroButton2.Text = "Encrypt";
		this.metroButton2.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.metroButton2.UseSelectable = true;
		this.metroButton2.Visible = false;
		this.metroButton2.Click += new global::System.EventHandler(this.metroButton2_Click);
		this.btn_driver.ForeColor = global::System.Drawing.SystemColors.ControlText;
		this.btn_driver.Location = new global::System.Drawing.Point(383, 88);
		this.btn_driver.Name = "btn_driver";
		this.btn_driver.Size = new global::System.Drawing.Size(58, 26);
		this.btn_driver.TabIndex = 15;
		this.btn_driver.Text = "DRIVER";
		this.btn_driver.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_driver.UseSelectable = true;
		this.btn_driver.Visible = false;
		this.btn_driver.Click += new global::System.EventHandler(this.btn_driver_Click);
		this.copyBox.BackColor = global::System.Drawing.Color.Transparent;
		this.copyBox.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("copyBox.BackgroundImage");
		this.copyBox.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
		this.copyBox.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.copyBox.Location = new global::System.Drawing.Point(208, 59);
		this.copyBox.Name = "copyBox";
		this.copyBox.Size = new global::System.Drawing.Size(18, 20);
		this.copyBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.copyBox.TabIndex = 25;
		this.copyBox.TabStop = false;
		this.copyBox.Click += new global::System.EventHandler(this.copyBox_Click);
		this.txt_RegStatus.AutoSize = true;
		this.txt_RegStatus.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txt_RegStatus.ForeColor = global::System.Drawing.Color.Red;
		this.txt_RegStatus.Location = new global::System.Drawing.Point(78, 88);
		this.txt_RegStatus.Name = "txt_RegStatus";
		this.txt_RegStatus.Size = new global::System.Drawing.Size(88, 13);
		this.txt_RegStatus.TabIndex = 11;
		this.txt_RegStatus.Text = "No Registered";
		this.label4.AutoSize = true;
		this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label4.Location = new global::System.Drawing.Point(7, 88);
		this.label4.Name = "label4";
		this.label4.Size = new global::System.Drawing.Size(71, 13);
		this.label4.TabIndex = 10;
		this.label4.Text = "ECID Status :";
		this.txt_mode.AutoSize = true;
		this.txt_mode.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txt_mode.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
		this.txt_mode.Location = new global::System.Drawing.Point(277, 63);
		this.txt_mode.Name = "txt_mode";
		this.txt_mode.Size = new global::System.Drawing.Size(29, 13);
		this.txt_mode.TabIndex = 9;
		this.txt_mode.Text = "DFU";
		this.label7.AutoSize = true;
		this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label7.Location = new global::System.Drawing.Point(231, 63);
		this.label7.Name = "label7";
		this.label7.Size = new global::System.Drawing.Size(45, 13);
		this.label7.TabIndex = 8;
		this.label7.Text = "MODE :";
		this.lbl_pwned.AutoSize = true;
		this.lbl_pwned.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.lbl_pwned.ForeColor = global::System.Drawing.Color.Red;
		this.lbl_pwned.Location = new global::System.Drawing.Point(288, 88);
		this.lbl_pwned.Name = "lbl_pwned";
		this.lbl_pwned.Size = new global::System.Drawing.Size(12, 13);
		this.lbl_pwned.TabIndex = 7;
		this.lbl_pwned.Text = "-";
		this.txt_Type.AutoSize = true;
		this.txt_Type.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txt_Type.Location = new global::System.Drawing.Point(279, 36);
		this.txt_Type.Name = "txt_Type";
		this.txt_Type.Size = new global::System.Drawing.Size(10, 13);
		this.txt_Type.TabIndex = 5;
		this.txt_Type.Text = "-";
		this.label6.AutoSize = true;
		this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label6.Location = new global::System.Drawing.Point(231, 36);
		this.label6.Name = "label6";
		this.label6.Size = new global::System.Drawing.Size(40, 13);
		this.label6.TabIndex = 4;
		this.label6.Text = "Type  :";
		this.label9.AutoSize = true;
		this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label9.Location = new global::System.Drawing.Point(232, 88);
		this.label9.Name = "label9";
		this.label9.Size = new global::System.Drawing.Size(54, 13);
		this.label9.TabIndex = 6;
		this.label9.Text = "PWNED :";
		this.txt_ECID.AutoSize = true;
		this.txt_ECID.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txt_ECID.Location = new global::System.Drawing.Point(54, 63);
		this.txt_ECID.Name = "txt_ECID";
		this.txt_ECID.Size = new global::System.Drawing.Size(49, 13);
		this.txt_ECID.TabIndex = 3;
		this.txt_ECID.Text = "txt_ECID";
		this.label3.AutoSize = true;
		this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new global::System.Drawing.Point(7, 63);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(47, 13);
		this.label3.TabIndex = 2;
		this.label3.Text = "ECID    :";
		this.txt_model.AutoSize = true;
		this.txt_model.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txt_model.Location = new global::System.Drawing.Point(54, 36);
		this.txt_model.Name = "txt_model";
		this.txt_model.Size = new global::System.Drawing.Size(52, 13);
		this.txt_model.TabIndex = 1;
		this.txt_model.Text = "txt_model";
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new global::System.Drawing.Point(7, 36);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(45, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "Model  :";
		this.progressBar1.FontSize = global::MetroFramework.MetroProgressBarSize.Small;
		this.progressBar1.HideProgressText = false;
		this.progressBar1.Location = new global::System.Drawing.Point(10, 356);
		this.progressBar1.Name = "progressBar1";
		this.progressBar1.Size = new global::System.Drawing.Size(457, 13);
		this.progressBar1.TabIndex = 2;
		this.progressBar1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.progressBar1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.groupBox5.Controls.Add(this.btn_readHello);
		this.groupBox5.Controls.Add(this.btn_get_activation);
		this.groupBox5.Controls.Add(this.btn_act_hello);
		this.groupBox5.Controls.Add(this.btn_changeSN);
		this.groupBox5.Font = new global::System.Drawing.Font("Tahoma", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.groupBox5.ForeColor = global::System.Drawing.SystemColors.ControlLight;
		this.groupBox5.Location = new global::System.Drawing.Point(319, 192);
		this.groupBox5.Name = "groupBox5";
		this.groupBox5.Size = new global::System.Drawing.Size(147, 138);
		this.groupBox5.TabIndex = 12;
		this.groupBox5.TabStop = false;
		this.groupBox5.Text = "Hello";
		this.btn_readHello.ForeColor = global::System.Drawing.SystemColors.ControlText;
		this.btn_readHello.Location = new global::System.Drawing.Point(8, 20);
		this.btn_readHello.Name = "btn_readHello";
		this.btn_readHello.Size = new global::System.Drawing.Size(130, 23);
		this.btn_readHello.TabIndex = 4;
		this.btn_readHello.Text = "Read Hello Mode";
		this.btn_readHello.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_readHello.UseSelectable = true;
		this.btn_readHello.Click += new global::System.EventHandler(this.btn_readHello_Click);
		this.btn_get_activation.ForeColor = global::System.Drawing.SystemColors.ControlText;
		this.btn_get_activation.Location = new global::System.Drawing.Point(8, 49);
		this.btn_get_activation.Name = "btn_get_activation";
		this.btn_get_activation.Size = new global::System.Drawing.Size(130, 23);
		this.btn_get_activation.TabIndex = 5;
		this.btn_get_activation.Text = "Generate Activation";
		this.btn_get_activation.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_get_activation.UseSelectable = true;
		this.btn_get_activation.Click += new global::System.EventHandler(this.btn_get_activation_Click);
		this.btn_act_hello.ForeColor = global::System.Drawing.SystemColors.ControlText;
		this.btn_act_hello.Location = new global::System.Drawing.Point(8, 78);
		this.btn_act_hello.Name = "btn_act_hello";
		this.btn_act_hello.Size = new global::System.Drawing.Size(130, 23);
		this.btn_act_hello.TabIndex = 6;
		this.btn_act_hello.Text = "Activate Hello";
		this.btn_act_hello.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_act_hello.UseSelectable = true;
		this.btn_act_hello.Click += new global::System.EventHandler(this.btn_act_hello_Click);
		this.btn_changeSN.ForeColor = global::System.Drawing.SystemColors.ControlText;
		this.btn_changeSN.Location = new global::System.Drawing.Point(8, 107);
		this.btn_changeSN.Name = "btn_changeSN";
		this.btn_changeSN.Size = new global::System.Drawing.Size(130, 23);
		this.btn_changeSN.TabIndex = 7;
		this.btn_changeSN.Text = "Change SN";
		this.btn_changeSN.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_changeSN.UseSelectable = true;
		this.btn_changeSN.Click += new global::System.EventHandler(this.btn_changeSN_Click);
		this.groupBox3.Controls.Add(this.metroButton1);
		this.groupBox3.Controls.Add(this.btn_register);
		this.groupBox3.Controls.Add(this.btn_backup);
		this.groupBox3.Controls.Add(this.btn_activate);
		this.groupBox3.Font = new global::System.Drawing.Font("Tahoma", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.groupBox3.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
		this.groupBox3.Location = new global::System.Drawing.Point(166, 192);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new global::System.Drawing.Size(147, 138);
		this.groupBox3.TabIndex = 11;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Passcode";
		this.metroButton1.Location = new global::System.Drawing.Point(9, 107);
		this.metroButton1.Name = "metroButton1";
		this.metroButton1.Size = new global::System.Drawing.Size(130, 23);
		this.metroButton1.TabIndex = 7;
		this.metroButton1.Text = "How To Use?";
		this.metroButton1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.metroButton1.UseSelectable = true;
		this.metroButton1.Click += new global::System.EventHandler(this.metroButton1_Click);
		this.btn_register.Location = new global::System.Drawing.Point(9, 78);
		this.btn_register.Name = "btn_register";
		this.btn_register.Size = new global::System.Drawing.Size(130, 23);
		this.btn_register.TabIndex = 6;
		this.btn_register.Text = "Register ECID";
		this.btn_register.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_register.UseSelectable = true;
		this.btn_register.Click += new global::System.EventHandler(this.btn_register_Click);
		this.btn_backup.ForeColor = global::System.Drawing.SystemColors.ControlText;
		this.btn_backup.Location = new global::System.Drawing.Point(9, 20);
		this.btn_backup.Name = "btn_backup";
		this.btn_backup.Size = new global::System.Drawing.Size(130, 23);
		this.btn_backup.TabIndex = 4;
		this.btn_backup.Text = "Backup Activation";
		this.btn_backup.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_backup.UseSelectable = true;
		this.btn_backup.Click += new global::System.EventHandler(this.btn_backup_Click);
		this.btn_activate.ForeColor = global::System.Drawing.SystemColors.ControlText;
		this.btn_activate.Location = new global::System.Drawing.Point(9, 49);
		this.btn_activate.Name = "btn_activate";
		this.btn_activate.Size = new global::System.Drawing.Size(130, 23);
		this.btn_activate.TabIndex = 5;
		this.btn_activate.Text = "Restore Activation";
		this.btn_activate.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_activate.UseSelectable = true;
		this.btn_activate.Click += new global::System.EventHandler(this.btn_activate_Click);
		this.groupBox2.Controls.Add(this.cBox);
		this.groupBox2.Controls.Add(this.btn_checkdev);
		this.groupBox2.Controls.Add(this.btn_boot1);
		this.groupBox2.Controls.Add(this.btn_eraser);
		this.groupBox2.Controls.Add(this.btn_checkSSH);
		this.groupBox2.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.groupBox2.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
		this.groupBox2.Location = new global::System.Drawing.Point(11, 192);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new global::System.Drawing.Size(149, 138);
		this.groupBox2.TabIndex = 10;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Ramdisk Menu";
		this.cBox.AutoSize = true;
		this.cBox.Location = new global::System.Drawing.Point(10, 55);
		this.cBox.Name = "cBox";
		this.cBox.Size = new global::System.Drawing.Size(53, 15);
		this.cBox.TabIndex = 14;
		this.cBox.Text = "iOS16";
		this.cBox.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.cBox.UseSelectable = true;
		this.btn_checkdev.ForeColor = global::System.Drawing.SystemColors.ControlText;
		this.btn_checkdev.Location = new global::System.Drawing.Point(9, 20);
		this.btn_checkdev.Name = "btn_checkdev";
		this.btn_checkdev.Size = new global::System.Drawing.Size(130, 23);
		this.btn_checkdev.TabIndex = 5;
		this.btn_checkdev.Text = "Check Device (DFU)";
		this.btn_checkdev.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_checkdev.UseSelectable = true;
		this.btn_checkdev.Click += new global::System.EventHandler(this.btn_checkdev_Click);
		this.btn_boot1.ForeColor = global::System.Drawing.SystemColors.ControlText;
		this.btn_boot1.Location = new global::System.Drawing.Point(72, 49);
		this.btn_boot1.Name = "btn_boot1";
		this.btn_boot1.Size = new global::System.Drawing.Size(67, 23);
		this.btn_boot1.TabIndex = 5;
		this.btn_boot1.Text = "BOOT RDSK";
		this.btn_boot1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_boot1.UseSelectable = true;
		this.btn_boot1.Click += new global::System.EventHandler(this.btn_boot1_Click);
		this.btn_eraser.ForeColor = global::System.Drawing.SystemColors.ControlText;
		this.btn_eraser.Location = new global::System.Drawing.Point(9, 78);
		this.btn_eraser.Name = "btn_eraser";
		this.btn_eraser.Size = new global::System.Drawing.Size(130, 23);
		this.btn_eraser.TabIndex = 6;
		this.btn_eraser.Text = "Eraser DFU";
		this.btn_eraser.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_eraser.UseSelectable = true;
		this.btn_eraser.Click += new global::System.EventHandler(this.btn_eraser_Click);
		this.btn_checkSSH.ForeColor = global::System.Drawing.SystemColors.ControlText;
		this.btn_checkSSH.Location = new global::System.Drawing.Point(9, 107);
		this.btn_checkSSH.Name = "btn_checkSSH";
		this.btn_checkSSH.Size = new global::System.Drawing.Size(130, 23);
		this.btn_checkSSH.TabIndex = 7;
		this.btn_checkSSH.Text = "Check SSH";
		this.btn_checkSSH.Theme = global::MetroFramework.MetroThemeStyle.Dark;
		this.btn_checkSSH.UseSelectable = true;
		this.btn_checkSSH.Click += new global::System.EventHandler(this.btn_checkSSH_Click);
		this.txt_info.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
		this.txt_info.Font = new global::System.Drawing.Font("Tahoma", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.txt_info.ForeColor = global::System.Drawing.SystemColors.HotTrack;
		this.txt_info.Location = new global::System.Drawing.Point(7, 333);
		this.txt_info.Name = "txt_info";
		this.txt_info.Size = new global::System.Drawing.Size(460, 21);
		this.txt_info.TabIndex = 13;
		this.txt_info.Text = "LOG TEXT";
		this.txt_info.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.backgroundWorker_2.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_2_DoWork);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(474, 379);
		base.Controls.Add(this.txt_info);
		base.Controls.Add(this.groupBox5);
		base.Controls.Add(this.groupBox3);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.progressBar1);
		base.Controls.Add(this.groupBox1);
		base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FRM_iBoy";
		base.Resizable = false;
		this.method_28(global::MetroFramework.MetroColorStyle.Red);
		this.Text = "iBoy Ramdisk - Windows";
		base.TextAlign = global::MetroFramework.Forms.MetroFormTextAlign.Center;
		this.method_29(global::MetroFramework.MetroThemeStyle.Dark);
		base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FRM_iBoy_FormClosing);
		base.Load += new global::System.EventHandler(this.FRM_iBoy_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.copyBox).EndInit();
		this.groupBox5.ResumeLayout(false);
		this.groupBox3.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x04000066 RID: 102
	private global::System.Windows.Forms.GroupBox groupBox1;

	// Token: 0x04000067 RID: 103
	private global::System.Windows.Forms.PictureBox copyBox;

	// Token: 0x04000068 RID: 104
	private global::System.Windows.Forms.Label txt_RegStatus;

	// Token: 0x04000069 RID: 105
	private global::System.Windows.Forms.Label label4;

	// Token: 0x0400006A RID: 106
	private global::System.Windows.Forms.Label txt_mode;

	// Token: 0x0400006B RID: 107
	private global::System.Windows.Forms.Label label7;

	// Token: 0x0400006C RID: 108
	private global::System.Windows.Forms.Label lbl_pwned;

	// Token: 0x0400006D RID: 109
	private global::System.Windows.Forms.Label txt_Type;

	// Token: 0x0400006E RID: 110
	private global::System.Windows.Forms.Label label6;

	// Token: 0x0400006F RID: 111
	private global::System.Windows.Forms.Label label9;

	// Token: 0x04000070 RID: 112
	private global::System.Windows.Forms.Label txt_ECID;

	// Token: 0x04000071 RID: 113
	private global::System.Windows.Forms.Label label3;

	// Token: 0x04000072 RID: 114
	private global::System.Windows.Forms.Label txt_model;

	// Token: 0x04000073 RID: 115
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000074 RID: 116
	private global::MetroFramework.Controls.MetroProgressBar progressBar1;

	// Token: 0x04000075 RID: 117
	private global::System.Windows.Forms.GroupBox groupBox5;

	// Token: 0x04000076 RID: 118
	private global::MetroFramework.Controls.MetroButton btn_readHello;

	// Token: 0x04000077 RID: 119
	private global::MetroFramework.Controls.MetroButton btn_get_activation;

	// Token: 0x04000078 RID: 120
	private global::MetroFramework.Controls.MetroButton btn_act_hello;

	// Token: 0x04000079 RID: 121
	private global::MetroFramework.Controls.MetroButton btn_changeSN;

	// Token: 0x0400007A RID: 122
	private global::System.Windows.Forms.GroupBox groupBox3;

	// Token: 0x0400007B RID: 123
	private global::MetroFramework.Controls.MetroButton metroButton1;

	// Token: 0x0400007C RID: 124
	private global::MetroFramework.Controls.MetroButton btn_register;

	// Token: 0x0400007D RID: 125
	private global::MetroFramework.Controls.MetroButton btn_backup;

	// Token: 0x0400007E RID: 126
	private global::MetroFramework.Controls.MetroButton btn_activate;

	// Token: 0x0400007F RID: 127
	private global::System.Windows.Forms.GroupBox groupBox2;

	// Token: 0x04000080 RID: 128
	private global::MetroFramework.Controls.MetroButton btn_checkdev;

	// Token: 0x04000081 RID: 129
	private global::MetroFramework.Controls.MetroButton btn_boot1;

	// Token: 0x04000082 RID: 130
	private global::MetroFramework.Controls.MetroButton btn_eraser;

	// Token: 0x04000083 RID: 131
	private global::MetroFramework.Controls.MetroButton btn_checkSSH;

	// Token: 0x04000084 RID: 132
	private global::System.Windows.Forms.Label txt_info;

	// Token: 0x04000085 RID: 133
	private global::MetroFramework.Controls.MetroCheckBox cBox;

	// Token: 0x04000086 RID: 134
	private global::MetroFramework.Controls.MetroButton btn_driver;

	// Token: 0x04000087 RID: 135
	private global::System.ComponentModel.BackgroundWorker backgroundWorker_2;

	// Token: 0x04000088 RID: 136
	private global::MetroFramework.Controls.MetroButton metroButton2;

	// Token: 0x04000089 RID: 137
	private global::MetroFramework.Controls.MetroButton metroButton3;
}
