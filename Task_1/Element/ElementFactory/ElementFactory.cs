using FormGenerator.JsonObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGenerator.Element
{
    class ElementFactory : IElementFactory
    {
        public IElement CreateElement(string type, Item item)
        {
            switch (type) {
                case "filler":
                    return new Filler(item);

                case "text":
                    return new Text(item);

                case "textarea":
                    return new TextArea(item);

                case "select":
                    return new Select(item);

                case "checkbox":
                    return new CheckBox(item);

                case "button":
                    return new Button(item);

                case "radio":
                    return new Radio(item);
            }
            return null;
        }
    }
}
