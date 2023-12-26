using Microsoft.AspNetCore.Http;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Stores;

namespace SportsShop.Application.Interfaces
{
	public interface IOfficeService
	{
		Office GetOffice();
		void UpdateOffice(Office office);
		void UpdateOffice(Office office,IFormFile logo,IFormFile image);
	}
}