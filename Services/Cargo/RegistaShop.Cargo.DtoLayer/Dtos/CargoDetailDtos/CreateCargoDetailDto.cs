using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Cargo.DtoLayer.Dtos.CargoDetailDtos
{
	public record CreateCargoDetailDto(
		 string SenderCustomer,
		 string ReceiverCustomer,
		 int Barcode,
		 int CargoCompanyId);
	
}
