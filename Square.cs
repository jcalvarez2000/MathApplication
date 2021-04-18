using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace MathApplication
{
    [DataContract]
    public class Square : Rectangle
    {
        public Square(float side) : base(side, side)
        {
        }

        [DataMember]
        public override string Name { get { return "square"; } }

        public override string serialize()
        {
            return JsonSerializer.Serialize<Square>(this);
        }

    }
}
