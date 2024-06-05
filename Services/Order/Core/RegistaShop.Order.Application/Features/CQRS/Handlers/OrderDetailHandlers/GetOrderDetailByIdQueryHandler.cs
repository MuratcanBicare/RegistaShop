using RegistaShop.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
using RegistaShop.Order.Application.Features.CQRS.Results.OrderDetailResults;
using RegistaShop.Order.Application.Interfaces;
using RegistaShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
	public class GetOrderDetailByIdQueryHandler
	{
		
		private readonly IRepository<OrderDetail> _repository;

		public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository)
		{
			_repository = repository;
		}

		public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery query)
		{

			var values = await _repository.GetByIdAsync(query.Id);
			return new GetOrderDetailByIdQueryResult
			{
				OrderDetailId = values.OrderDetailId,
				ProductId = values.ProductId,
				ProductName	= values.ProductName,
				ProductAmount = values.ProductAmount,
				OrderingId = values.OrderingId,
				ProductPrice = values.ProductPrice,
				ProductTotalPrice = values.ProductTotalPrice,
			};

		}
	}
}
