using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Entities
{
    public abstract class BaseObject
    {
        [Key]
        public int ID { get; set; }

        public DateTime Create { get; set; }

        public DateTime Update { get; set; }

        public DateTime DeleteDate { get; set; }

    }
}
