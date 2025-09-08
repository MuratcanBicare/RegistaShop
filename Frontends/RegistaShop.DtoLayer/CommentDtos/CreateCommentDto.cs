using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CommentDtos
{
	public record CreateCommentDto(
		string NameSurname,
		string? ImageUrl,
		string Email,
		string CommentDetail,
		int Rating,
		DateTime CreatedDate,
		bool Status,
		string ProductId);

}