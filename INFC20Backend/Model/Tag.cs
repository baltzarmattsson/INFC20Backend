using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infc20.Model
{
    public class Tag
    {
        public string TagId { get; set; }

        public Tag() { }
        public Tag(string tag)
        {
            this.TagId = tag;
        }
    }
}
