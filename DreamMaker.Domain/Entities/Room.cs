﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamMaker.Domain.Entities
{
    public class Room
    {
        [Key]
        public long RoomId { get; set; }
         
        public string RoomName { get; set; }

        public int MaxMemberCount { get; set; }

        public string CreatorId { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual ICollection<ApplicationUser> Members { get; set; }
    }
}
