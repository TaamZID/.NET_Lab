﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class AssignedtasksModel
    {
        public int ass_id { get; set; }
        public Nullable<int> u_id { get; set; }
        public Nullable<int> t_id { get; set; }
        public string status { get; set; } 
    }
}
