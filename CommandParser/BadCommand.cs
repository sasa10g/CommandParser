using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    public class BadCommand
    {
        public Command command { get; set; }
        public String message { get; set; }

        public BadCommand(){
        }

        public BadCommand(Command command){
            this.command = command;
        }

        public BadCommand(Command command, String message){
            this.command = command;
            this.message = message;
        }

    }
}
