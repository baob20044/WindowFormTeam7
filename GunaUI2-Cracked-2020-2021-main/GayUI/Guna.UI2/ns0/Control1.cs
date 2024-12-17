using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200007C RID: 124
	[ToolboxBitmap(typeof(Button))]
	[DebuggerStepThrough]
	[ToolboxItem(true)]
	[Description("A vertical Slider control")]
	internal class Control1 : Control0
	{
		// Token: 0x170003BA RID: 954
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00002131 File Offset: 0x00000331
		protected override CreateParams CreateParams
		{
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				return null;
			}
		}
	}
}
