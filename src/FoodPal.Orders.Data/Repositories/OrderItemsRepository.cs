using FoodPal.Orders.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPal.Orders.Data.Repositories
{
	public class OrderItemsRepository : IOrderItemsRepository
	{
		private readonly OrdersContext _ordersContext;

		public OrderItemsRepository(OrdersContext ordersContext)
		{
			_ordersContext = ordersContext;
		}
	}
}
