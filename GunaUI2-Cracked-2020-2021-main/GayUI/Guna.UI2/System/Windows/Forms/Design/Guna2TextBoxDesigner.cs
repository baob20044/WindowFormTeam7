using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200000F RID: 15
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2TextBoxDesigner : ControlDesigner
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000015 RID: 21
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
