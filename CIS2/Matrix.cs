using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace CIS2
{
    [DataContract]
    public class Matrix
    {
        [DataMember]
        public List<double[]> matrix { get; set; }
        public Matrix()
        {
            matrix = new List<double[]>();
        }
    }
}
