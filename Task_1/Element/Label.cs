using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormGenerator.JsonObject;

namespace FormGenerator.Element
{
    class Label : IElement
    {
        string text;

        public Label(Item item)
        {
            Initialize(item);
        }

        public Label(string text)
        {
            this.text = text;
        }

        public string GenerateTag()
        {
            return $"<label>{text}</label>";
        }

        public void Initialize(Item item)
        {
            text = item.Label;
        }
    }
}
