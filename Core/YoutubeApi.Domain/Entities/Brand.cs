using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Common;

namespace YoutubeApi.Domain.Entities
{
    //Burada istersem IEntityBase'i yazmayadabilirim. Çünkü zaten dolaylı olarak EntityBase ile IEntityBase'i de kalıtıyorum.
    public class Brand : EntityBase , IEntityBase 
    {
        public Brand() { }

        public Brand(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}
