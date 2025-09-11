namespace RegistaShop.Catalog.Dtos.ContactDtos
{
	public record CreateContactDto(
		string NameSurname,
		string Email,
		string Subject,
		string Message,
		bool IsRead,
		DateTime SendDate);

}
