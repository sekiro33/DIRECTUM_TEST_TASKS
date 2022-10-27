using FormGenerator.JsonObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGenerator.Element
{
    class Radio : IElement
    {
        string name;
        string placeholder;
        bool required;
        string value;
        Label label;
        bool disabled;
        string _class;
        ValidationRule validationRules;
        RadioOption[] radioOptions;

        public Radio(Item item)
        {
            Initialize(item);
        }

        public string GenerateTag()
        {
            StringBuilder radio = new StringBuilder();
            foreach (var option in radioOptions)
            {
                Label label = new Label(option.Label);
                radio.AppendLine(label.GenerateTag());
                radio.Append($"<input type=\"radio\" ");
                radio.Append($"value=\"{option.Value}\" ");
                radio.Append($"class=\"{_class}\" ");
                radio.Append($"name=\"{name}\" ");

                radio.Append($"data-validationRule=\"{validationRules.Type}\" ");

                if (placeholder != null)
                    radio.Append($"placeholder=\"{placeholder}\"");

                if (option.Checked)
                    radio.Append("checked ");

                if (required)
                    radio.Append("required ");

                if (disabled)
                    radio.Append("disabled ");

                radio.AppendLine("/>");
            }

            return label.GenerateTag() + "\n" + radio.ToString();
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
            radioOptions = item.RadioOptions;
        }
    }
}
