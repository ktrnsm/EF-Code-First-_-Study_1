using EF_Code_First___Study_1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First___Study_1.Models.Entities
{
    public abstract class BaseEntity
    {

        public int ID { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedTime { get; set; }
        public DataStatus Status { get; set; }


        public BaseEntity()
        {
            CreatedTime = DateTime.Now;
            Status = DataStatus.Inserted;
        }
    }
}
