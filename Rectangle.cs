using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace MathApplication
{
    [DataContract]
    public class Rectangle : Shape
    {
        public Rectangle(float width, float length)
        {
            this.Width = width;
            this.Length = length;
        }

        [DataMember]
        public override string Name { get { return "rectangle"; } }

        [DataMember]
        public float Width { get; set; }
        [DataMember]
        public float Length { get; set; }
        [DataMember]
        public override float Perimeter
        {
            get { return ((Width + Length) * 2); }
        }

        [DataMember]
        public override float Area
        {
            get { return (Width * Length); }
        }

        public override string serialize()
        {
            return JsonSerializer.Serialize<Rectangle>(this);
        }

    }
}
