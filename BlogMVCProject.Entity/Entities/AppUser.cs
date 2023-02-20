using BlogMVCProject.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogMVCProject.Entity.Entities
{
	public class AppUser : IdentityUser<Guid>, IEntityBase
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public Guid ImageId { get; set; } = Guid.Parse("ead96304-6214-4519-a4a3-6c4d4ca0e6ad");
		public Image Image { get; set; }

		public ICollection<Article> Articles { get; set; }
	}
}
