using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEntity
{
    public class NewsModel
    {
        public int N_id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Date { get; set; }
        public int A_id { get; set; }

        public virtual AdminModel Admin { get; set; }
    }
}
