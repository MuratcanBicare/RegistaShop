using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.AboutDtos
{
	public record CreateAboutDto(
		string Description,
		string Address,
		string Email,
		string Phone);

}
