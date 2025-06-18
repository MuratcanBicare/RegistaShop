using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Cargo.DtoLayer.Dtos.CargoCompanyDtos
{
	public record UpdateCargoCompanyDto(
		int CargoCompanyId,
		string CargoCompanyName);
}
