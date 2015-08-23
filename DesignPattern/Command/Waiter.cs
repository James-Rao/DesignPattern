using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    class Waiter
    {
        List<Command> commands = new List<Command>();

        public void AddCommand(Command command)
        {
            commands.Add(command);
        }

        // delete

        // modify

        public void Notify()
        {
            foreach (var item in commands)
            {
                item.Execute();
            }
        }
    }
}
