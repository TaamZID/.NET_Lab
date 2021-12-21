using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class TaskModel
    {
        public int t_id { get; set; }
        public string prove_image { get; set; }
        public string quantity { get; set; }
        public string deadline { get; set; }
        public string tree_type { get; set; }
        public string status { get; set; }
        public Nullable<int> v_id { get; set; }
    }
}
