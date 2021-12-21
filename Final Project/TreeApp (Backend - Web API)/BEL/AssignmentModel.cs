using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class AssignmentModel
    {
        public Nullable<int> a_id { get; set; }
        public Nullable<int> amount { get; set; }
        public string deadline { get; set; }
        public Nullable<int> tree_number { get; set; }
        public string time { get; set; }
        public string status { get; set; }
        public int ass_id { get; set; }
        public int a_number { get; set; }
    }
}
