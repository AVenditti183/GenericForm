using System;
using System.Collections.Generic;
using System.Text;

namespace GenericForm.Model
{
    public class Field
    {
        public Field(string label,string nameProperty, TypeField typeField, string cssClass)
        {
            Label = label;
            NameProperty = nameProperty;
            TypeField = typeField;
            this.cssClass = cssClass;
        }
        public string Label { get; set; }
        public string NameProperty { get; set; }
        public TypeField TypeField{ get; set; }
        public string cssClass { get; set; }
        
    }

    public enum TypeField
    {
        text,
        number,
        date 
    }
}
