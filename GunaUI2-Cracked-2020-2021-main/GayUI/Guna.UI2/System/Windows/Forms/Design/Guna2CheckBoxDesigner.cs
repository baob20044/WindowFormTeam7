using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200001F RID: 31
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2CheckBoxDesigner : ControlDesigner
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400002D RID: 45
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
