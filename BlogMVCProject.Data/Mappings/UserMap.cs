﻿using BlogMVCProject.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogMVCProject.Data.Mappings
{
	public class UserMap : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.HasKey(u => u.Id);

			// Indexes for "normalized" username and email, to allow efficient lookups
			builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
			builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

			// Maps to the AspNetUsers table
			builder.ToTable("AspNetUsers");

			// A concurrency token for use with the optimistic concurrency checking
			builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

			// Limit the size of columns to use efficient database types
			builder.Property(u => u.UserName).HasMaxLength(256);
			builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
			builder.Property(u => u.Email).HasMaxLength(256);
			builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

			// The relationships between User and other entity types
			// Note that these relationships are configured with no navigation properties

			// Each User can have many UserClaims
			builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

			// Each User can have many UserLogins
			builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

			// Each User can have many UserTokens
			builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

			// Each User can have many entries in the UserRole join table
			builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

			var superadmin = new AppUser
			{
				Id = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C"),
				UserName = "superadmin@gmail.com",
				NormalizedUserName = "SUPERADMIN@GMAIL.COM",
				Email = "superadmin@gmail.com",
				NormalizedEmail = "SUPERADMIN@GMAIL.COM",
				PhoneNumber = "+905439999999",
				FirstName = "Burak",
				LastName = "Yünkül",
				PhoneNumberConfirmed = true,
				EmailConfirmed = true,
				SecurityStamp = Guid.NewGuid().ToString(),
				ImageId = Guid.Parse("73FE8145-8D11-4B16-8876-FADC450F686A")
			};
			superadmin.PasswordHash = CreatePasswordHash(superadmin, "123456");

			var admin = new AppUser
			{
				Id = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"),
				UserName = "admin@gmail.com",
				NormalizedUserName = "ADMIN@GMAIL.COM",
				Email = "admin@gmail.com",
				NormalizedEmail = "ADMIN@GMAIL.COM",
				PhoneNumber = "+905439999988",
				FirstName = "Admin",
				LastName = "User",
				PhoneNumberConfirmed = false,
				EmailConfirmed = false,
				SecurityStamp = Guid.NewGuid().ToString(),
				ImageId = Guid.Parse("BEAE4EB0-F3B2-47E1-964A-C313468DE883")
			};
			admin.PasswordHash = CreatePasswordHash(admin, "123456");

			builder.HasData(superadmin, admin);

		}
		private string CreatePasswordHash(AppUser user, string password)
		{
			var passwordHasher = new PasswordHasher<AppUser>();
			return passwordHasher.HashPassword(user, password);
		}
	}

}
