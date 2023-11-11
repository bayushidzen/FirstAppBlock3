using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3
{
    public class FamilyMember
    {
        public FamilyMember Mother { get; set; }
        public FamilyMember Father { get; set; }
        public string Name { get; set; }
        public Gender Sex { get; set; }

        void Info(int indent = 0)
        {
            Console.WriteLine($"{new String('-', indent)}Имя {this.Name}");
        }
        public virtual void Print(int indent = 0)
        {
            Info(indent);
        }
    }
}
