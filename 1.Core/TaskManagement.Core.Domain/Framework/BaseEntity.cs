﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Core.Domain.Framework
{
   public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}
