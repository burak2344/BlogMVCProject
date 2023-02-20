using BlogMVCProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogMVCProject.Data.Mappings
{
	public class ArticleMap : IEntityTypeConfiguration<Article>
	{
		public void Configure(EntityTypeBuilder<Article> builder)
		{
			builder.HasData(new Article
			{
				Id = Guid.NewGuid(),
				Title = "Asp.Net Core Deneme Makalesi",
				Content = "Asp.Net Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam id urna ut lorem semper consectetur. Vivamus lobortis sapien ac pretium maximus. Cras tristique odio vel felis gravida cursus. Suspendisse lectus quam, mattis vitae nunc at, auctor finibus mi. Vestibulum vel facilisis neque, eget vestibulum nulla. Proin quis enim quis augue ullamcorper rhoncus vel a augue. Maecenas tincidunt, dui condimentum congue faucibus, leo dolor ullamcorper nulla, ac suscipit tortor risus sed quam. Ut purus diam, tincidunt ac nulla a, placerat tempus orci.\r\n\r\n",
				ViewCount = 15,

				CategoryId = Guid.Parse("9BEEB106-AD10-4C59-882A-068A8D7945B5"),
				ImageId = Guid.Parse("73FE8145-8D11-4B16-8876-FADC450F686A"),
				CreatedBy = "Admin Test",
				CreatedDate = DateTime.Now,
				IsDeleted = false,
				UserId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C")
			},
			new Article
			{
				Id = Guid.NewGuid(),
				Title = "Visual Studio Core Deneme Makalesi",
				Content = "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam id urna ut lorem semper consectetur. Vivamus lobortis sapien ac pretium maximus. Cras tristique odio vel felis gravida cursus. Suspendisse lectus quam, mattis vitae nunc at, auctor finibus mi. Vestibulum vel facilisis neque, eget vestibulum nulla. Proin quis enim quis augue ullamcorper rhoncus vel a augue. Maecenas tincidunt, dui condimentum congue faucibus, leo dolor ullamcorper nulla, ac suscipit tortor risus sed quam. Ut purus diam, tincidunt ac nulla a, placerat tempus orci.\r\n\r\n",
				ViewCount = 15,
				CategoryId = Guid.Parse("1DD6C3CE-A418-46A2-AB28-83158703C851"),
				ImageId = Guid.Parse("BEAE4EB0-F3B2-47E1-964A-C313468DE883"),
				CreatedBy = "Admin Test",
				CreatedDate = DateTime.Now,
				IsDeleted = false,
				 UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")

			});
		}
	}
}
