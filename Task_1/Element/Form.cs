using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGenerator.Element
{
    class Form
    {
        public string name { get; set; }
        public string postmessage { get; set; }
        List<IElement> elements;

        public Form(string Name, string PostMessage)
        {
            name = Name;
            postmessage = PostMessage;
            elements = new List<IElement>();
        }

        public void AddElement(IElement element)
        {
            elements.Add(element);
        }

        public IElement GetElement(int index)
        {
            return elements[index];
        }

        public int GetElementsLength()
        {
            return elements.Count;
        }
    }
}
