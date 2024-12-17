using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000076 RID: 118
	[ToolboxItem(true)]
	[Description("A vertical ProgressBar Control")]
	[ToolboxBitmap(typeof(ProgressBar))]
	[DebuggerStepThrough]
	public class Guna2VProgressBar : Guna2ProgressBar
	{
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x00002131 File Offset: 0x00000331
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
