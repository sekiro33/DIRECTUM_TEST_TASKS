using FormGenerator.JsonObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGenerator.Element
{
    class CheckBox : IElement
    {
        string name;
        string placeholder;
        bool required;
        Label label;
        bool disabled;
        string _class;
        bool _checked;
        ValidationRule validationRules;

        public CheckBox(Item item)
        {
            Initialize(item);
        }

        public string GenerateTag()
        {
            StringBuilder checkBox = new StringBuilder();
            checkBox.Append("<input type=\"checkbox\" ");
            checkBox.Append($"class=\"{_class}\" ");
            checkBox.Append($"name=\"{name}\" ");

            checkBox.Append($"data-validationRule=\"{validationRules.Type}\" ");

            if (placeholder != null)
                checkBox.Append($"placeholder=\"{placeholder}\"");

            if (required)
                checkBox.Append("required ");

            if (disabled)
                checkBox.Append("disabled ");

            if (_checked)
                checkBox.Append("checked ");

            checkBox.Append("/>");

            return label.GenerateTag() + "\n" + checkBox.ToString();
        }

        public void Initialize(Item item)
        {
            name = item.Name;
            placeholder = item.PlaceHolder;
            required = item.Required;
            label = new Label(item);
            disabled = item.Disabled;
            _class = item.Class;
            _checked = item.Checked;
            validationRules = item.ValidationRules;
        }
    }
}
