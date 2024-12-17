using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;

namespace ns2
{
	// Token: 0x020000C5 RID: 197
	[ToolboxItem(false)]
	[DesignerCategory("code")]
	internal class Class11 : NumericUpDown
	{
		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool Boolean_0
		{
			get
			{
				return false;
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x060010DA RID: 4314 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060010DB RID: 4315 RVA: 0x00002134 File Offset: 0x00000334
		public event Class11.FocusChangedEventHandler Event_0
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

		// Token: 0x060010DC RID: 4316 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnFocusChanged(bool e)
		{
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnGotFocus(EventArgs e)
		{
		}

		// Token: 0x040004B7 RID: 1207
		[CompilerGenerated]
		private Class11.FocusChangedEventHandler FocusChanged;

		// Token: 0x040004B8 RID: 1208
		private bool bool_0;

		// Token: 0x040004B9 RID: 1209
		internal MouseState mouseState_0;

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x060010E5 RID: 4325
		public delegate void FocusChangedEventHandler(bool e);
	}
}
