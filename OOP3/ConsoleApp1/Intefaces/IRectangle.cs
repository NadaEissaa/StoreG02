using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Intefaces
{
    internal interface IRectangle : Ishape
    {

        double Length { get; set; }
        double Width { get; set; }
    }
}
