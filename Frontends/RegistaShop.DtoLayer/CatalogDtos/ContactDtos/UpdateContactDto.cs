using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.ContactDtos
{
	public record UpdateContactDto(
		string ContactId,
		string NameSurname,
		string Email,
		string Subject,
		string Message,
		bool IsRead,
		DateTime SendDate);

}
