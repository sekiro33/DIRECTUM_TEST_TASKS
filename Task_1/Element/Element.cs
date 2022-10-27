using FormGenerator.JsonObject;

namespace FormGenerator.Element
{
    abstract class Element : IElement
    {
        public Element(Item item)
        {
            Initialize(item);
        }

        abstract public string GenerateTag();

        abstract public void Initialize(Item item);
    }
}
