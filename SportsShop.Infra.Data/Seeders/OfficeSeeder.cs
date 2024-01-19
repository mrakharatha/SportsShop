using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsShop.Domain.Models.Permissions;
using SportsShop.Domain.Models.Stores;
using System;

namespace SportsShop.Infra.Data.Seeders
{
	public class OfficeSeeder : IEntityTypeConfiguration<Office>
	{
		public void Configure(EntityTypeBuilder<Office> builder)
		{

			builder.HasData(new Office
			{
				Id = 1,
				Name = "فروشگاه ورزشی نقش اسکیت",
				Address = "یزد،صفائیه،میدان اطلسی",
				Email = "hosseion4016@gmail.com",
				NormalDayWorkingTitle = "شنبه تا چهارشنبه",
				NormalDayWorkingHours = "11 صبح تا 7 عصر",
				HolidayWorkingTitle = "پنج شنبه",
				HolidayWorkingHours = "11 صبح تا 5 عصر",
				PhoneNumber = "09138573151",
				UserId = 1,
				SiteName = "فروشگاه ورزشی",
				CreateDate = new DateTime(2023, 12, 20, 19, 17, 32, 968, DateTimeKind.Local).AddTicks(1379)
			});
		}
	}
}