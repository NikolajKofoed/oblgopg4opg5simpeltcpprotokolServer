using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oblgopg4opg5simpeltcpprotokol
{
    public class Data
    {
        public string Method { get; set; }
        public int[] Numbers { get; set; }

        public Data(string method, int[] numbers)
        {
            Method = method;
            Numbers = numbers;
        }

        public Data()
        {
        }

        public override string ToString()
        {
            string nums = "";

            foreach (var num in Numbers)
            {
                nums = nums + " " + num + ",";
            }

            return $"Method: {Method} - Numbers: {nums}";
        }
    }
}
