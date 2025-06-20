using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Cargo.DtoLayer.Dtos.CargoCustomerDtos
{
	public record CreateCargoCustomerDto(
		string Name,
		string Surname,
		string Email,
		string Phone,
		string District,
		string City,
		string Address);

}
