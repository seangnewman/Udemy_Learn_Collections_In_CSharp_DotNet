using System;

namespace Creating_Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class DisplayOrderAttribute : Attribute
    {
        public int Position { get; private set; }

         
        public DisplayOrderAttribute(int position)
        {
            Position = position;
        }
    }
  
}