﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    //Contains the drone commands
    public class Command
    {
        public String direction { get; set; }
        public int distance { get; set; }
        public String error { get; set; }

        public Command(){
        }

        public Command(String direction, int distance){
            this.direction = direction;
            this.distance = distance;
        }

        public Command(string error){
            this.error = error;
        }

        public override String ToString(){

            //overwrite direction letter
            if (direction.Equals("l"))
                direction = "left";
            else if (direction.Equals("r"))
                direction = "right";
            else if (direction.Equals("u"))
                direction = "up";
            else if (direction.Equals("d"))
                direction = "down";

            return "Direction: " + direction + ", Distance: " + distance.ToString() + ".";
        }
    }
}
