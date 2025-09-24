using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.Catalog.Dtos.ContactDtos;
using RegistaShop.Catalog.Services.ContactServices;

namespace RegistaShop.Catalog.Controllers
{
	public class ContactsController : ApiBaseController
	{

		private readonly IContactService _contactService;

		public ContactsController(IContactService contactService)
		{
			_contactService = contactService;
		}

		[HttpGet]
		public async Task<IActionResult> ContactList()
		{

			var values = await _contactService.GetAllContactAsync();
			return Ok(values);

		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetContactById(string id)
		{

			var values = await _contactService.GetByIdContactAsync(id);
			return Ok(values);

		}

		[HttpPost]
		public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
		{

			await _contactService.CreateContactAsync(createContactDto);
			return Ok("Mesaj başarıyla eklendi.");

		}

		[HttpDelete]
		public async Task<IActionResult> DeleteContact(string id)
		{
			await _contactService.DeleteContactAsync(id);
			return Ok("Mesaj başarıyla silindi.");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto)
		{

			await _contactService.UpdateContactAsync(updateContactDto);
			return Ok("Mesaj başarıyla güncellendi.");

		}
	}
}
