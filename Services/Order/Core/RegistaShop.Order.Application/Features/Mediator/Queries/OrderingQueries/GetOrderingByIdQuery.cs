﻿using MediatR;
using RegistaShop.Order.Application.Features.Mediator.Results.OrderingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Order.Application.Features.Mediator.Queries.OrderingQueries
{
	public class GetOrderingByIdQuery : IRequest<GetOrderingByIdQueryResult>
	{

		public int Id { get; set; }

		public GetOrderingByIdQuery(int id)
		{
			Id = id;
		}
	}
}
