using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormGenerator.JsonObject;

namespace FormGenerator.Element
{
    class SomeElement : Element
    {
        public SomeElement(Item item) : base(item)
        {
        }

        public override string GenerateTag()
        {
            throw new NotImplementedException();
        }

        public override void Initialize(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
