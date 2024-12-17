using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000039 RID: 57
	public class Guna2MouseStateHandler : Component
	{
		// Token: 0x06000319 RID: 793 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2MouseStateHandler()
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2MouseStateHandler(IContainer container)
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600031D RID: 797 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600031E RID: 798 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler HoverState
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600031F RID: 799 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000320 RID: 800 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler PressedState
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000321 RID: 801 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000322 RID: 802 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler IdleState
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00003810 File Offset: 0x00001A10
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00002134 File Offset: 0x00000334
		private MouseState MouseState_0
		{
			get
			{
				return MouseState.HOVER;
			}
			set
			{
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00002136 File Offset: 0x00000336
		[Browsable(false)]
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002134 File Offset: 0x00000334
		public void Add(Control control)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002134 File Offset: 0x00000334
		public void Remove(Control control)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002134 File Offset: 0x00000334
		public void Clear()
		{
		}

		// Token: 0x040000B1 RID: 177
		private IContainer icontainer_0;

		// Token: 0x040000B5 RID: 181
		private List<Guna2MouseStateHandler.Class3> list_0;

		// Token: 0x040000B6 RID: 182
		private MouseState mouseState_0;

		// Token: 0x0200003A RID: 58
		private class Class3
		{
			// Token: 0x17000148 RID: 328
			// (get) Token: 0x06000329 RID: 809 RVA: 0x00002131 File Offset: 0x00000331
			// (set) Token: 0x0600032A RID: 810 RVA: 0x00002134 File Offset: 0x00000334
			public Guna2MouseStateHandler Guna2MouseStateHandler_0
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x0600032B RID: 811 RVA: 0x00003810 File Offset: 0x00001A10
			// (set) Token: 0x0600032C RID: 812 RVA: 0x00002134 File Offset: 0x00000334
			public MouseState MouseState_0
			{
				get
				{
					return MouseState.HOVER;
				}
				set
				{
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x0600032D RID: 813 RVA: 0x00002131 File Offset: 0x00000331
			// (set) Token: 0x0600032E RID: 814 RVA: 0x00002134 File Offset: 0x00000334
			public Control Control_0
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			// Token: 0x0600032F RID: 815 RVA: 0x00002134 File Offset: 0x00000334
			private void method_0(object sender, MouseEventArgs e)
			{
			}

			// Token: 0x06000330 RID: 816 RVA: 0x00002134 File Offset: 0x00000334
			private void method_1(object sender, EventArgs e)
			{
			}

			// Token: 0x06000331 RID: 817 RVA: 0x00002134 File Offset: 0x00000334
			private void method_2(object sender, EventArgs e)
			{
			}

			// Token: 0x06000332 RID: 818 RVA: 0x00002134 File Offset: 0x00000334
			private void method_3(object sender, MouseEventArgs e)
			{
			}

			// Token: 0x06000333 RID: 819 RVA: 0x00002134 File Offset: 0x00000334
			private void method_4(int count, int countOUT)
			{
			}

			// Token: 0x06000334 RID: 820 RVA: 0x00002134 File Offset: 0x00000334
			private void method_5()
			{
			}

			// Token: 0x040000B7 RID: 183
			private bool bool_0;

			// Token: 0x040000B8 RID: 184
			[CompilerGenerated]
			private Guna2MouseStateHandler guna2MouseStateHandler_0;

			// Token: 0x040000B9 RID: 185
			private MouseState mouseState_0;

			// Token: 0x040000BA RID: 186
			private Control control_0;

			// Token: 0x0200003B RID: 59
			// (Invoke) Token: 0x06000337 RID: 823
			private delegate void Delegate1(int count, int countOUT);
		}
	}
}
