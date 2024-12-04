using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Common;

namespace YoutubeApi.Domain.Entities
{
    // Category sınıfı, bir kategori nesnesini temsil ediyor.
    // EntityBase sınıfından miras alıyor ve IEntityBase arayüzünü implemente ediyor.
   
    public class Category : EntityBase , IEntityBase
    {
        // Parametresiz bir kurucu metot. Gerekirse boş bir kategori oluşturmak için kullanılabilir.
        
        public Category() { }

        // Parametreli bir kurucu metot. Yeni bir kategori oluştururken ParentId, Name ve Priorty değerlerini set eder.
        
        public Category(int parentId, string name, int priorty) 
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;
        }
        
        //Get okuma yapar(Özellikten değer okur), set yazma yapar(Özelliğe değer yazar).
        
        public required int ParentId { get; set; }  //(required: bu özellik mutlaka doldurulmalı.)
        public required string Name { get; set; }
        public required int Priorty { get; set; }

        //ICollection : birden fazla öğeyi (nesneyi) bir arada tutmak için kullanılır, çünkü bir kategorinin birden çok detayı olacak.
        public ICollection<Detail> Details { get; set; } //Burda bire çok(one-to-many) ilişki yapıldı. 

        //Products ve Category çoka çok ilişkilidir.
        public ICollection<Product> Products { get; set; } 


    }
}
