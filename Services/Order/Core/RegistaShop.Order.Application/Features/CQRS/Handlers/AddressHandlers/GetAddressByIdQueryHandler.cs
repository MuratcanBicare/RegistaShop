using RegistaShop.Order.Application.Features.CQRS.Queries.AddressQueries;
using RegistaShop.Order.Application.Features.CQRS.Results.AddressResults;
using RegistaShop.Order.Application.Interfaces;
using RegistaShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
	public class GetAddressByIdQueryHandler
	{

		private readonly IRepository<Address> _reposiyory;

		public GetAddressByIdQueryHandler(IRepository<Address> reposiyory)
		{

			_reposiyory = reposiyory;
		
		}

		public async Task<GetAddressGetByIdQueryResult> Handle(GetAddressByIdQuery query)
		{
			var values = await _reposiyory.GetByIdAsync(query.Id);
			return new GetAddressGetByIdQueryResult
			{
				AddressId = values.AddressId,
				City = values.City,
				Detail = values.Detail,
				District = values.District,
				UserId = values.UserId
			};
		}
	}
}
