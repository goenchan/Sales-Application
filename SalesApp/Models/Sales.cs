﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Models
{
    class Sales : BaseModel
    {
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
