using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Nwcali.Response
{
    public class ParentCategoryInfo
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public string name { get; set; }
        public string type_url { get; set; }
        public List<ChildrenCategoryInfo> childrebList { get; set; }
    }
    public class ChildrenCategoryInfo
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public string name { get; set; }
        public string type_url { get; set; }
        public List<ChildrenCategoryInfo> childrebList { get; set; }
    }
    
}