﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class LogInModel
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public Nullable<int> Type { get; set; }
    }
}
