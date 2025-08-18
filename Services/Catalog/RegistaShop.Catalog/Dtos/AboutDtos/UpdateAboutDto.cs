namespace RegistaShop.Catalog.Dtos.AboutDtos
{
	public record UpdateAboutDto(
		string AboutId,
		string Description,
		string Address,
		string Email,
		string Phone);

}
