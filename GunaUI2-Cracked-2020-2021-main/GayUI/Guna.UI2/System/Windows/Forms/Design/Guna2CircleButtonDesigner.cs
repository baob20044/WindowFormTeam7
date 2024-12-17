using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000005 RID: 5
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2CircleButtonDesigner : ControlDesigner
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000006 RID: 6
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
