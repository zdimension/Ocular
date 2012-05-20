using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolBox;

[assembly: ToolBoxText("HTML DIV control")]
[assembly: ToolBoxCode("<div></div>")]
[assembly: ToolBoxImage("image.png")]

namespace ToolBoxItemTest
{
    [type: ToolBoxText("HTML DIV control")]
    [type: ToolBoxCode("<div></div>")]
    [type: ToolBoxImage("image.png")] 
    public class Div
    {

    }
}
