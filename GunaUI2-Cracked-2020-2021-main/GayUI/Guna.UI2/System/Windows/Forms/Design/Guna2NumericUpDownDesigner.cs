using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200002B RID: 43
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2NumericUpDownDesigner : ControlDesigner
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400003F RID: 63
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
