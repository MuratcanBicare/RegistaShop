using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.FeatureSliderDtos
{

	public record ResultFeatureSliderDto(
		string FeatureSliderId,
		string Title,
		string Description,
		string ImageUrl,
		bool Status);

}
