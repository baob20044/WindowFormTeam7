using System;
using System.ComponentModel.Design;
using System.Security.Permissions;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000025 RID: 37
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public class Guna2TrackBarDesigner : ControlDesigner
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000036 RID: 54
		private DesignerActionListCollection designerActionListCollection_0;
	}
}
