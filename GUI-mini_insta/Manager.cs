using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_mini_insta
{
    internal class Manager : Command
    {

        public void Execute(User s)
        {
            if (s.suspended == false)
            {
                MessageBox.Show("You suspended this user");
                s.suspended = true;
            }
            else
            {
                MessageBox.Show("You unsuspended this user");
                s.suspended = false;
            }
        }

        public Dictionary<string,List<string>> issues = new Dictionary<string, List<string>>();
    }
}
