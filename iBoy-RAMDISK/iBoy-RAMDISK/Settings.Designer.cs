using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace iBoy_Ramdisk.Properties
{
	// Token: 0x0200002A RID: 42
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00011ECC File Offset: 0x000100CC
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x040000C7 RID: 199
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
