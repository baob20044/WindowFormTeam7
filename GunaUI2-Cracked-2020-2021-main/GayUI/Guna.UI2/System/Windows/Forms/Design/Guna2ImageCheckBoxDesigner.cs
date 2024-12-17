using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000017 RID: 23
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2ImageCheckBoxDesigner : ControlDesigner
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000021 RID: 33
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
