using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000010 RID: 16
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Class6
{
	// Token: 0x0600004C RID: 76 RVA: 0x000053E8 File Offset: 0x000035E8
	internal Class6()
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600004D RID: 77 RVA: 0x000074A0 File Offset: 0x000056A0
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class6.resourceManager_0 == null)
			{
				ResourceManager resourceManager = new ResourceManager("/n\")fDp1Q'#WW'aD>Q%$TH$n\\+", typeof(Class6).Assembly);
				Class6.resourceManager_0 = resourceManager;
			}
			return Class6.resourceManager_0;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600004E RID: 78 RVA: 0x000074E0 File Offset: 0x000056E0
	// (set) Token: 0x0600004F RID: 79 RVA: 0x000074F4 File Offset: 0x000056F4
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return Class6.cultureInfo_0;
		}
		set
		{
			Class6.cultureInfo_0 = value;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000050 RID: 80 RVA: 0x00007508 File Offset: 0x00005708
	internal static byte[] Byte_0
	{
		get
		{
			object @object = Class6.ResourceManager_0.GetObject("gaster", Class6.cultureInfo_0);
			return (byte[])@object;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000051 RID: 81 RVA: 0x00007534 File Offset: 0x00005734
	internal static byte[] Byte_1
	{
		get
		{
			object @object = Class6.ResourceManager_0.GetObject("libcrypto_1_1_x64", Class6.cultureInfo_0);
			return (byte[])@object;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000052 RID: 82 RVA: 0x00007560 File Offset: 0x00005760
	internal static byte[] Byte_2
	{
		get
		{
			object @object = Class6.ResourceManager_0.GetObject("libssl_1_1_x64", Class6.cultureInfo_0);
			return (byte[])@object;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000053 RID: 83 RVA: 0x0000758C File Offset: 0x0000578C
	internal static byte[] Byte_3
	{
		get
		{
			object @object = Class6.ResourceManager_0.GetObject("libusb_1_0", Class6.cultureInfo_0);
			return (byte[])@object;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000054 RID: 84 RVA: 0x000075B8 File Offset: 0x000057B8
	internal static byte[] Byte_4
	{
		get
		{
			object @object = Class6.ResourceManager_0.GetObject("openssl", Class6.cultureInfo_0);
			return (byte[])@object;
		}
	}

	// Token: 0x04000036 RID: 54
	private static ResourceManager resourceManager_0;

	// Token: 0x04000037 RID: 55
	private static CultureInfo cultureInfo_0;
}
