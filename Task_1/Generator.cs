using FormGenerator.Element;
using FormGenerator.JsonObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGenerator
{
    class Generator
    {
        public static string GenerateForm(RootObject root)
        {
            Form form = new Form(root.Form.Name, root.Form.PostMessage);

            ElementFactory factory = new ElementFactory();

            foreach (var item in root.Form.Items)
                form.AddElement(factory.CreateElement(item.Type, item));

            return GenerateFormCode(form);
        }

        private static string GenerateFormCode(Form form)
        {
            StringBuilder formCode = new StringBuilder();
            formCode.AppendLine($"<form name=\"{form.name}\" postmessage=\"{form.postmessage}\">");
            for (int i = 0; i < form.GetElementsLength(); i++)
            {
                if(form.GetElement(i) != null)
                    formCode.AppendLine(form.GetElement(i).GenerateTag());
            }
            formCode.AppendLine("</form>");
            return formCode.ToString();
        }
    }
}
