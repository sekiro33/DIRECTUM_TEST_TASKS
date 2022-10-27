using System.Text;
using FormGenerator.JsonObject;

namespace FormGenerator.Element
{
    class Text : IElement
    {
        string name;
        string placeholder;
        bool required;
        string value;
        Label label;
        bool disabled;
        string _class;
        ValidationRule validationRules;

        public Text(Item item)
        {
            Initialize(item);
        }

        public string GenerateTag()
        {
            StringBuilder text = new StringBuilder();
            text.Append("<input type=\"text\" ");
            text.Append($"class=\"{_class}\" ");
            text.Append($"value=\"{value}\" ");
            text.Append($"name=\"{name}\" ");

            text.Append($"data-validationRule=\"{validationRules.Type}\" ");

            if (placeholder != null)
                text.Append($"placeholder=\"{placeholder}\"");

            if (required)
                text.Append("required ");

            if (disabled)
                text.Append("disabled ");

            text.Append("/>");

            return label.GenerateTag() + "\n" + text.ToString();
        }

        public void Initialize(Item item)
        {
            name = item.Name;
            placeholder = item.PlaceHolder;
            required = item.Required;
            value = item.Value;
            label = new Label(item);
            disabled = item.Disabled;
            _class = item.Class;
            validationRules = item.ValidationRules;
        }
    }
}
