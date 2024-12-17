using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000011 RID: 17
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2ComboBoxDesigner : ControlDesigner
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000018 RID: 24
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
