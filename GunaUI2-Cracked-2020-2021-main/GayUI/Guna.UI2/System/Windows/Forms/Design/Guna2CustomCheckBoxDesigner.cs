using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200001D RID: 29
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2CustomCheckBoxDesigner : ControlDesigner
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400002A RID: 42
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
