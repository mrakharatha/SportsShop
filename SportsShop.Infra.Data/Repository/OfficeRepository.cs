using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Stores;
using SportsShop.Infra.Data.Context;

namespace SportsShop.Infra.Data.Repository
{
	public class OfficeRepository: IOfficeRepository
	{ 
	private	readonly SportsShopDbContext _context;

		public OfficeRepository(SportsShopDbContext context)
		{
			_context = context;
		}

		public Office GetOffice()
		{
			return _context.Offices.Find(1);
		}

		public void UpdateOffice(Office office)
		{
			_context.Update(office);
			_context.SaveChanges();
		}
	}
}