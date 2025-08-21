using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace RegistaShop.Catalog.Entities
{
	public class ProductImage
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string ProductImageId { get; set; }
		
		[BsonElement("ProductImages")]
		public List<string> ProductImageList { get; set; } = new List<string>();

		public string ProductId { get; set; }
		
		[BsonIgnore]
		public Product Product { get; set; }


	}
}
