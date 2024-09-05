using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Service
    {
        [Key]
        public int ServıceId { get; set; }
        public string ServıceIcon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
