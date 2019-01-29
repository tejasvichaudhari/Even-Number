using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace WebApplication3
{
    public class Model : IModel
    {
        public List<String> setInfo(int number, int divBy)
        {
            List<String> l = new List<string>();
            int i;
            StringBuilder sb = new StringBuilder();

            for (i = 1; i <= Convert.ToInt32(number); i++)
            {
                if (i % divBy == 0)
                {
                    sb.Append(i);
                    sb.Append(",");
                }
            }

            l.Add(Convert.ToString(sb).Remove(Convert.ToString(sb).Length - 1, 1));
            return l;
        }

    }
}