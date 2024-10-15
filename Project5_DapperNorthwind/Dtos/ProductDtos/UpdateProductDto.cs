namespace Project5_DapperNorthwind.Dtos.ProductDtos
{
	public class UpdateProductDto
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public decimal UnitPrice { get; set; }
		public int UnitsInStock { get; set; }
		public int CategoryId { get; set; }
	}
}
