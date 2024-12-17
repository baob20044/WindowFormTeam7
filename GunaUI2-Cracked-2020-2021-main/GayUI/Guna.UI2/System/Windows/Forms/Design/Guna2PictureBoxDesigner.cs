using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000019 RID: 25
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2PictureBoxDesigner : ControlDesigner
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000024 RID: 36
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
