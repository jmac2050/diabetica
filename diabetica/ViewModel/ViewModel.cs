using System;
using System.Collections.Generic;

namespace GettingStarted
{
	public class ViewModel
	{
		public ViewModel ()
		{
			OrderInfoRepository order = new OrderInfoRepository ();
			ordersInfo = order.GetOrderDetails (200);
		}

		#region ItemsSource

		private List<OrderInfo> ordersInfo;

		public List<OrderInfo> OrdersInfo {
			get { return ordersInfo; }
			set { this.ordersInfo = value; }
		}

		#endregion
	}
}

