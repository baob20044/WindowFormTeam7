using System;
using System.ComponentModel;
using System.Security.Permissions;
using System.Windows.Forms;

namespace ns2
{
	// Token: 0x020000C4 RID: 196
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	internal class Class10 : NativeWindow
	{
		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x00002134 File Offset: 0x00000334
		public bool Boolean_0
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0000231F File Offset: 0x0000051F
		public Class10(Form parent, bool allowResizing)
		{
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00002134 File Offset: 0x00000334
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		protected override void WndProc(ref Message m)
		{
		}

		// Token: 0x040004B5 RID: 1205
		private bool bool_0;

		// Token: 0x040004B6 RID: 1206
		private Form form_0;
	}
}
