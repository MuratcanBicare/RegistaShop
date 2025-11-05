using RegistaShop.DtoLayer.CatalogDtos.ContactDtos;

namespace RegistaShop.WebUI.Services.CatalogServices.ContactServices
{
	public interface IContactService
	{
		Task<List<ResultContactDto>> GetAllContactAsync();
		Task CreateContactAsync(CreateContactDto createContactDto);
		Task UpdateContactAsync(UpdateContactDto updateContactDto);
		Task DeleteContactAsync(string id);
		Task<GetByIdContactDto> GetByIdContactAsync(string id);
	}
}
