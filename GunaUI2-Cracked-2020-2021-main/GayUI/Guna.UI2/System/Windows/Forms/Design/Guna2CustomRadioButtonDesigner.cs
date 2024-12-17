using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000021 RID: 33
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2CustomRadioButtonDesigner : ControlDesigner
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000030 RID: 48
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
