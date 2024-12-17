using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000027 RID: 39
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2VScrollBarDesigner : ControlDesigner
	{
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000039 RID: 57
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
