using BlogMVCProject.Core.Entities;

namespace BlogMVCProject.Entity.Entities
{
	public class Category : EntityBase
	{
		public Category()
		{

		}
		public Category(string name, string createdBy)
		{
			Name = name;
			CreatedBy = createdBy;
		}
		public string Name { get; set; }
		public ICollection<Article> Articles { get; set; }

	}
}
