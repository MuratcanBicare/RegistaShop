using RegistaShop.DtoLayer.CatalogDtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.ProductDtos
{
	public record ResultProductWithCategoryDto(
		string ProductId,
		string ProductName,
		decimal ProductPrice,
		string ProductImageUrl,
		string ProductDescription,
		string CategoryId,
		ResultCategoryDto Category);

}

