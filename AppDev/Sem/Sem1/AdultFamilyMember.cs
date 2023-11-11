using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3
{
    public class AdultFamilyMember : FamilyMember
    {
        public FamilyMember[] Children { get; set; }
        public override void Print(int indent = 0)
        {
            base.Print(indent);

            foreach (var child in Children)
                child.Print(indent * 2);
        }
    }
}
