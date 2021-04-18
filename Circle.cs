using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace MathApplication
{
    [DataContract]
    public class Circle : Shape
    {
        public Circle(float radius)
        {
            this.Radius = radius;
        }

        public static float PI = 3.14F;

        [DataMember]
        public override string Name { get { return "circle"; } }

        [DataMember]
        public float Radius { get; set; }
        [DataMember]
        public override float Perimeter 
        {
            get { return (2 * PI * Radius); }            
        }
        [DataMember]
        public override float Area
        {
            get { return (PI * Radius * Radius); }            
        }

        public override string serialize()
        {
            return JsonSerializer.Serialize<Circle>(this);
        }


    }
}
