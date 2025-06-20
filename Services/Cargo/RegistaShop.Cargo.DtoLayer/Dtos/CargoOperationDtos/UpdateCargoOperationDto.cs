using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Cargo.DtoLayer.Dtos.CargoOperationDtos
{

	public record UpdateCargoOperationDto(
		int CargoOperationId,
		string Barcode,
		string Description,
		DateTime OperationDate);

}
