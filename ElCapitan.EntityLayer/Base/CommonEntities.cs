using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCapitan.EntityLayer.Base
{
    public class CommonEntities
    {
        public int CreatorId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int UpdaterId { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public int DeleterId { get; set; }
        public DateTime? DeletedAt { get; set; }



    }
}
