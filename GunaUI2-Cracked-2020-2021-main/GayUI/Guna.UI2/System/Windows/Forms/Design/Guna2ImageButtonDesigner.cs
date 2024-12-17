using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000013 RID: 19
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2ImageButtonDesigner : ControlDesigner
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400001B RID: 27
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
