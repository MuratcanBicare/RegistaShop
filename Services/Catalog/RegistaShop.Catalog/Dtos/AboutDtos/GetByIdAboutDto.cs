namespace RegistaShop.Catalog.Dtos.AboutDtos
{
	public record GetByIdAboutDto(
		string AboutId,
		string Description,
		string Address,
		string Email,
		string Phone);

}
