using System.Collections.Generic;

namespace Project4_EntityFrameworkCodeFirstMovie.DAL.Entities
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public List<Movie> Movies { get; set; }
	}
}