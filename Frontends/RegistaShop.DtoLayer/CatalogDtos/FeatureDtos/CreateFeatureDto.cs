using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.FeatureDtos
{
	public record CreateFeatureDto(
		string Title,
		string Icon);
}
