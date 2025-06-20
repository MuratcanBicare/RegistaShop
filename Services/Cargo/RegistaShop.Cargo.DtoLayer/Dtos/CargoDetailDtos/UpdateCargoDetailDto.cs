using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Cargo.DtoLayer.Dtos.CargoDetailDtos
{

	public record UpdateCargoDetailDto(
		 int CargoDetailId,
		 string SenderCustomer,
		 string ReceiverCustomer,
		 int Barcode,
		 int CargoCompanyId);

}
