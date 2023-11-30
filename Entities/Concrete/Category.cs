using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract; 

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int BrandId { get; set; }
        public int ModelYear { get; set; }
    }
}
