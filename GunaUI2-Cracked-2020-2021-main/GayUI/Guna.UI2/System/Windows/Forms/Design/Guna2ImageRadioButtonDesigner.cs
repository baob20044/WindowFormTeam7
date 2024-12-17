using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000015 RID: 21
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2ImageRadioButtonDesigner : ControlDesigner
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400001E RID: 30
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
