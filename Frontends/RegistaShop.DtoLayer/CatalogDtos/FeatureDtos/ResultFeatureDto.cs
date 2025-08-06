using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.FeatureDtos
{
	public record ResultFeatureDto(
		string FeatureId,
		string Title,
		string Icon);
}
