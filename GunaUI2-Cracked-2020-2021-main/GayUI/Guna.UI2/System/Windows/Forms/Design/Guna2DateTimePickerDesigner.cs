using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200002D RID: 45
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2DateTimePickerDesigner : ControlDesigner
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000042 RID: 66
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
