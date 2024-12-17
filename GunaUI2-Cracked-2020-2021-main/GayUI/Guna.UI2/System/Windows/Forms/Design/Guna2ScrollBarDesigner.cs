using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000029 RID: 41
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2ScrollBarDesigner : ControlDesigner
	{
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400003C RID: 60
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
