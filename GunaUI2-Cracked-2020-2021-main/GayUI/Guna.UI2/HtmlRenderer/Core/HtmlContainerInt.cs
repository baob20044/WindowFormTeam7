using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.HtmlRenderer.Adapters.Entities;
using Guna.UI2.HtmlRenderer.Core.Entities;
using ns7;
using ns8;
using ns9;

namespace Guna.UI2.HtmlRenderer.Core
{
	// Token: 0x02000110 RID: 272
	public sealed class HtmlContainerInt : IDisposable
	{
		// Token: 0x06001286 RID: 4742 RVA: 0x00002167 File Offset: 0x00000367
		public HtmlContainerInt(RAdapter adapter)
		{
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x00002131 File Offset: 0x00000331
		internal RAdapter RAdapter_0
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x00002131 File Offset: 0x00000331
		internal Class26 Class26_0
		{
			get
			{
				return null;
			}
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06001289 RID: 4745 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600128A RID: 4746 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler LoadComplete
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

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x0600128B RID: 4747 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600128C RID: 4748 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlLinkClickedEventArgs> LinkClicked
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

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x0600128D RID: 4749 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600128E RID: 4750 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlRefreshEventArgs> Refresh
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

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x0600128F RID: 4751 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001290 RID: 4752 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlScrollEventArgs> ScrollChange
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

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06001291 RID: 4753 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001292 RID: 4754 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlRenderErrorEventArgs> RenderError
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

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06001293 RID: 4755 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001294 RID: 4756 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlStylesheetLoadEventArgs> StylesheetLoad
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

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06001295 RID: 4757 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001296 RID: 4758 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlImageLoadEventArgs> ImageLoad
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

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x00002131 File Offset: 0x00000331
		public CssData CssData
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x00002134 File Offset: 0x00000334
		public bool AvoidGeometryAntialias
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600129B RID: 4763 RVA: 0x00002134 File Offset: 0x00000334
		public bool AvoidAsyncImagesLoading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x00002134 File Offset: 0x00000334
		public bool AvoidImagesLateLoading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x00002134 File Offset: 0x00000334
		public bool IsSelectionEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x00002134 File Offset: 0x00000334
		public bool IsContextMenuEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00003BE4 File Offset: 0x00001DE4
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x00002134 File Offset: 0x00000334
		public RPoint ScrollOffset
		{
			get
			{
				return default(RPoint);
			}
			set
			{
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00003BE4 File Offset: 0x00001DE4
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x00002134 File Offset: 0x00000334
		public RPoint Location
		{
			get
			{
				return default(RPoint);
			}
			set
			{
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x00003BFC File Offset: 0x00001DFC
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x00002134 File Offset: 0x00000334
		public RSize MaxSize
		{
			get
			{
				return default(RSize);
			}
			set
			{
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00003BFC File Offset: 0x00001DFC
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x00002134 File Offset: 0x00000334
		public RSize ActualSize
		{
			get
			{
				return default(RSize);
			}
			set
			{
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x00003BFC File Offset: 0x00001DFC
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x00002134 File Offset: 0x00000334
		public RSize PageSize
		{
			[CompilerGenerated]
			get
			{
				return default(RSize);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060012AD RID: 4781 RVA: 0x00002134 File Offset: 0x00000334
		public int MarginTop
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x00002134 File Offset: 0x00000334
		public int MarginBottom
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060012B1 RID: 4785 RVA: 0x00002134 File Offset: 0x00000334
		public int MarginLeft
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x00002134 File Offset: 0x00000334
		public int MarginRight
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00002134 File Offset: 0x00000334
		public void SetMargins(int value)
		{
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x00002131 File Offset: 0x00000331
		public string SelectedText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00002131 File Offset: 0x00000331
		public string SelectedHtml
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00002131 File Offset: 0x00000331
		internal Class41 Class41_0
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x00003C2C File Offset: 0x00001E2C
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x00002134 File Offset: 0x00000334
		internal RColor RColor_0
		{
			get
			{
				return default(RColor);
			}
			set
			{
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x00003C2C File Offset: 0x00001E2C
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x00002134 File Offset: 0x00000334
		internal RColor RColor_1
		{
			get
			{
				return default(RColor);
			}
			set
			{
			}
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00002134 File Offset: 0x00000334
		public void SetHtml(string htmlSource, CssData baseCssData = null)
		{
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00002134 File Offset: 0x00000334
		public void Clear()
		{
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00002134 File Offset: 0x00000334
		public void ClearSelection()
		{
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00002131 File Offset: 0x00000331
		public string GetHtml(HtmlGenerationStyle styleGen = HtmlGenerationStyle.Inline)
		{
			return null;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00002131 File Offset: 0x00000331
		public string GetAttributeAt(RPoint location, string attribute)
		{
			return null;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00002131 File Offset: 0x00000331
		public List<LinkElementData<RRect>> GetLinks()
		{
			return null;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00002131 File Offset: 0x00000331
		public string GetLinkAt(RPoint location)
		{
			return null;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00003CEC File Offset: 0x00001EEC
		public RRect? GetElementRectangle(string elementId)
		{
			return null;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00002134 File Offset: 0x00000334
		public void PerformLayout(RGraphics g)
		{
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00002134 File Offset: 0x00000334
		public void PerformPaint(RGraphics g)
		{
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00002134 File Offset: 0x00000334
		public void HandleMouseDown(RControl parent, RPoint location)
		{
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x00002134 File Offset: 0x00000334
		public void HandleMouseUp(RControl parent, RPoint location, RMouseEvent e)
		{
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00002134 File Offset: 0x00000334
		public void HandleMouseDoubleClick(RControl parent, RPoint location)
		{
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00002134 File Offset: 0x00000334
		public void HandleMouseMove(RControl parent, RPoint location)
		{
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00002134 File Offset: 0x00000334
		public void HandleMouseLeave(RControl parent)
		{
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00002134 File Offset: 0x00000334
		public void HandleKeyDown(RControl parent, RKeyEvent e)
		{
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_0(HtmlStylesheetLoadEventArgs args)
		{
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_1(HtmlImageLoadEventArgs args)
		{
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00002134 File Offset: 0x00000334
		public void RequestRefresh(bool layout)
		{
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_2(HtmlRenderErrorType type, string message, Exception exception = null)
		{
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_3(RControl parent, RPoint location, Class41 link)
		{
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_4(Class41 box, CssBlock block)
		{
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00002131 File Offset: 0x00000331
		internal Class35 method_5()
		{
			return null;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00002134 File Offset: 0x00000334
		public void Dispose()
		{
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00003BE4 File Offset: 0x00001DE4
		private RPoint method_6(RPoint location)
		{
			return default(RPoint);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00002136 File Offset: 0x00000336
		private bool method_7(RPoint location)
		{
			return false;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8(bool all)
		{
		}

		// Token: 0x040006F8 RID: 1784
		private readonly RAdapter radapter_0;

		// Token: 0x040006F9 RID: 1785
		private readonly Class26 class26_0;

		// Token: 0x040006FA RID: 1786
		private Class41 class41_0;

		// Token: 0x040006FB RID: 1787
		private List<Class53> list_0;

		// Token: 0x040006FC RID: 1788
		private Class38 class38_0;

		// Token: 0x040006FD RID: 1789
		private Class35 class35_0;

		// Token: 0x040006FE RID: 1790
		private RColor rcolor_0;

		// Token: 0x040006FF RID: 1791
		private RColor rcolor_1;

		// Token: 0x04000700 RID: 1792
		private CssData cssData_0;

		// Token: 0x04000701 RID: 1793
		private bool bool_0;

		// Token: 0x04000702 RID: 1794
		private bool bool_1;

		// Token: 0x04000703 RID: 1795
		private bool bool_2;

		// Token: 0x04000704 RID: 1796
		private bool bool_3;

		// Token: 0x04000705 RID: 1797
		private bool bool_4;

		// Token: 0x04000706 RID: 1798
		private bool bool_5;

		// Token: 0x04000707 RID: 1799
		private RPoint rpoint_0;

		// Token: 0x04000708 RID: 1800
		private RSize rsize_0;

		// Token: 0x04000709 RID: 1801
		private RPoint rpoint_1;

		// Token: 0x0400070A RID: 1802
		private RSize rsize_1;

		// Token: 0x0400070B RID: 1803
		private int int_0;

		// Token: 0x0400070C RID: 1804
		private int int_1;

		// Token: 0x0400070D RID: 1805
		private int int_2;

		// Token: 0x0400070E RID: 1806
		private int int_3;

		// Token: 0x04000716 RID: 1814
		[CompilerGenerated]
		private RSize rsize_2;
	}
}
