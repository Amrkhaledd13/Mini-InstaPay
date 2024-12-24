using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_mini_insta
{
    internal interface Command
    {
            void Execute();
            void Undo();
       
    }
}
