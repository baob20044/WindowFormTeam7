using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000043 RID: 67
	[ToolboxBitmap(typeof(Process))]
	[Description("Get several unique device IDs (UIDs) as string")]
	[DebuggerStepThrough]
	internal class Class4 : Component
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060003CE RID: 974 RVA: 0x000038D0 File Offset: 0x00001AD0
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Select the identifer type to retrieve its value. The ID will be returned in a string format")]
		[Category("Guna Component Features")]
		public Class4.DeviceIdentifierType DeviceIdentifierType_0
		{
			get
			{
				return Class4.DeviceIdentifierType.ProcessorID;
			}
			set
			{
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002136 File Offset: 0x00000336
		private bool method_1(string value)
		{
			return false;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender, RunWorkerCompletedEventArgs e)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4()
		{
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The GetID property retrieves the Unique Device Identifier and returns it in a format of a string")]
		[Category("Guna Component Features")]
		[Browsable(true)]
		public string String_0
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x040000DF RID: 223
		private Class4.DeviceIdentifierType deviceIdentifierType_0;

		// Token: 0x040000E0 RID: 224
		[CompilerGenerated]
		private string string_0;

		// Token: 0x02000044 RID: 68
		public enum DeviceIdentifierType
		{
			// Token: 0x040000E2 RID: 226
			ProcessorID,
			// Token: 0x040000E3 RID: 227
			BIOSVersion,
			// Token: 0x040000E4 RID: 228
			BIOSSerialNumber,
			// Token: 0x040000E5 RID: 229
			HardDriveCaption,
			// Token: 0x040000E6 RID: 230
			HardDriveFirmwareRevision,
			// Token: 0x040000E7 RID: 231
			HardDriveModel,
			// Token: 0x040000E8 RID: 232
			HardDriveSerialNumber,
			// Token: 0x040000E9 RID: 233
			HardDriveSignature,
			// Token: 0x040000EA RID: 234
			HardDriveSize,
			// Token: 0x040000EB RID: 235
			BaseBoardSerialNumber,
			// Token: 0x040000EC RID: 236
			UserAccountSID
		}
	}
}
