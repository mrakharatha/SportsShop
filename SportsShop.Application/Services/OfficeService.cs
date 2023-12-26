using System;
using Microsoft.AspNetCore.Http;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Stores;

namespace SportsShop.Application.Services
{
	public class OfficeService: IOfficeService
	{
		private readonly IOfficeRepository _officeRepository;

		public OfficeService(IOfficeRepository officeRepository)
		{
			_officeRepository = officeRepository;
		}

		public Office GetOffice()
		{
			return _officeRepository.GetOffice();
		}

		public void UpdateOffice(Office office)
		{
			office.UpdateDate=DateTime.Now;
			_officeRepository.UpdateOffice(office);
		}

		public void UpdateOffice(Office office, IFormFile logo, IFormFile image)
		{
			if (logo != null)
				office.Logo = logo.Upload("Logo",office.Logo);

            if (image != null)
                office.Image = image.Upload("Image", office.Image);

			UpdateOffice(office);
        }
	}
}