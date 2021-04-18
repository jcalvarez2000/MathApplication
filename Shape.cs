using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MathApplication
{
    [DataContract]
    public abstract class Shape 
    {
        [DataMember]
        public abstract string Name { get; }
        [DataMember]
        public abstract float Perimeter { get; }
        [DataMember]
        public abstract float Area { get; }

        public abstract string serialize();
    }
}
