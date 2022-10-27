using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormGenerator.JsonObject;

namespace FormGenerator.Element
{
    class Button : IElement
    {
        string _class;
        string text;

        public Button(Item item)
        {
            Initialize(item);
        }

        public string GenerateTag()
        {
            return $"<button class=\"{_class}\">{text}</button>";
        }

        public void Initialize(Item item)
        {
            _class = item.Class;
            text = item.Text;
        }
    }
}
