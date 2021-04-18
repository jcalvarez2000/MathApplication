using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace MathApplication
{
    [DataContract]
    public class Triangle : Shape
    {
        public Triangle(float sideA, float sideB, float sideC, float height, float triangleBase)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            this.Height = height;
            this.TriangleBase = triangleBase;
        }
        [DataMember]
        public float SideA { get; set; }
        [DataMember]
        public float SideB { get; set; }
        [DataMember]
        public float SideC { get; set; }
        [DataMember]
        public float Height { get; set; }
        [DataMember]
        public float TriangleBase { get; set; }

        [DataMember]
        public override float Perimeter
        {
            get { return (this.SideA + this.SideB + this.SideC); }
        }

        [DataMember]
        public override float Area
        {
            get { return ((this.Height * this.TriangleBase) / 2.0f); }
        }        

        public override string Name 
        {
            get 
            {
                if ((this.SideA == this.SideB) && (this.SideB == this.SideC))
                    return "equilateral";
                else if ((this.SideA == this.SideB) || (this.SideB == this.SideC) || (this.SideA == this.SideC))
                    return "isosceles";                
                return "scalene";
            }
        }

        public override string serialize()
        {
            return JsonSerializer.Serialize<Triangle>(this);
        }
        
        

    }
}
