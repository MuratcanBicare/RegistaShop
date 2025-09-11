namespace RegistaShop.Catalog.Dtos.ContactDtos
{
	public record GetByIdContactDto(
		string ContactId,
		string NameSurname,
		string Email,
		string Subject,
		string Message,
		bool IsRead,
		DateTime SendDate);

}
