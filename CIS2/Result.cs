using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CIS2
{
    [DataContract]
    public class Result
    {
        [DataMember(Name = "weight")]
        public double[] weight { get; set; }

        [DataMember(Name = "l_max")]
        public double l_max { get; set; }

        [DataMember(Name = "cosistecy idex")]
        public double consistency_index { get; set; }

        [DataMember(Name = "radom cosistecy idex")]
        public double random_consistency_index { get; set; }

        [DataMember(Name = "cosistecy ratio")]
        public double consistency_ratio { get; set; }

        public static string GetJ(string js)
        {
            string json = string.Empty;
            json = "{\"" + js.Substring(js.IndexOf("weight"));
            json = json.Substring(0, json.IndexOf("\",\""));
            json = json.Replace("\n", "");
            json = json.Replace("\\", "");
            json = json.Replace("n", "");
            return json;
        }

        public Result(int n)
        {
            weight = new double[n];
        }
    }
}
