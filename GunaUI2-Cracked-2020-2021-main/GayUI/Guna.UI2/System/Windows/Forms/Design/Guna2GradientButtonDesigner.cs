using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000007 RID: 7
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2GradientButtonDesigner : ControlDesigner
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000009 RID: 9
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
