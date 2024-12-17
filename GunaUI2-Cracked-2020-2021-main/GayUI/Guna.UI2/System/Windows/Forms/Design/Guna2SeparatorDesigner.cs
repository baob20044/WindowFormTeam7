using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200000D RID: 13
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2SeparatorDesigner : ControlDesigner
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000012 RID: 18
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
