using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormGenerator.JsonObject;

namespace FormGenerator.Element
{
    class Filler : IElement
    {
        string message;

        public Filler(Item item)
        {
            Initialize(item);
        }

        public string GenerateTag()
        {
            return $"{message}";
        }

        public void Initialize(Item item)
        {
            message = item.Message;
        }
    }
}
