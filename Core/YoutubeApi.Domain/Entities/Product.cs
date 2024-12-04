using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Common;

namespace YoutubeApi.Domain.Entities
{
    public class Product : EntityBase
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int BrandId  { get; set; }
        public required decimal Price { get; set; }
        public required decimal Discount { get; set; }
        
        public Brand Brand { get; set; }
       // public required string ImagePath { get; set; }
       //Bir ürünün birden fazla kategorisi olabilir. Bir kategorininde birden fazla ürünü olabilir. Bu yüzden Product ve Category sınıfında çoka çok bir ilişki kurmalıyız ki migretion oluşturduğumuzda db'de direkt çoka çok ilişki kurulsun.
       public ICollection<Category> Categories { get; set; }

    }
}
