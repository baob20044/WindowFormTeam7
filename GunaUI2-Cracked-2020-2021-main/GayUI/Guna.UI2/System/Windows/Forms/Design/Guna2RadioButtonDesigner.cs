using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000023 RID: 35
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2RadioButtonDesigner : ControlDesigner
	{
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000033 RID: 51
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
