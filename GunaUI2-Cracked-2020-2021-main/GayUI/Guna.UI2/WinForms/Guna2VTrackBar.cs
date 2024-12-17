using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200007F RID: 127
	[Description("A vertical TrackBar Control")]
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(TrackBar))]
	[DebuggerStepThrough]
	public class Guna2VTrackBar : Guna2TrackBar
	{
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00002131 File Offset: 0x00000331
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
