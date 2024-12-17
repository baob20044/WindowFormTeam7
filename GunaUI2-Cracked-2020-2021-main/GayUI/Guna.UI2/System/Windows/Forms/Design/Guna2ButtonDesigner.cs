using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000003 RID: 3
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2ButtonDesigner : ControlDesigner
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000003 RID: 3
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
