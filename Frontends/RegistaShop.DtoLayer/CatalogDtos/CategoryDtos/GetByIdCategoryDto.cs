using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.CategoryDtos
{
	public record GetByIdCategoryDto(
		string CategoryID,
		string CategoryName,
		string ImageUrl);
}