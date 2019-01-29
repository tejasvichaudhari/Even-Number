using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3
{
    public interface IView
    {
        String LabelNumber { get; set; }
        String TextforEvenNumbers { get; set; }
        String TextBoxNumberEven { get; set; }

        String LabelNumberFor7Div { get; set; }
        String TextNumberfor7Div { get; set; }
        String TextNumbersDivBy7 { get; set; }
    }
}
