using SportsShop.Domain.Models.Stores;

namespace SportsShop.Domain.Interfaces
{
	public interface IOfficeRepository
	{
		Office GetOffice();
		void UpdateOffice(Office office);
	}
}