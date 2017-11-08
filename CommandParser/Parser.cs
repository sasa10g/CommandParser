using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    //Contains the parsing logic
    public class Parser
    {
        public String cmdString { get; set; }
        private int b, e = 0;

        public Parser(){
        }

        public void parsering(List<string> commandS){

            List<BadCommand> listBC = new List<BadCommand>();


            foreach (string cmdString in commandS){
                b += 1;

                string[] cmds = cmdString.Split(',');

                Console.WriteLine(b.ToString() + ". Set: ");

                string firstDir = (string)new String(cmds[0].Where(Char.IsLetter).ToArray());
                Command c1 = new Command(firstDir, disConvert(cmds[0]));
                validateDir(firstDir, cmds[0], listBC, c1);

                string secondDir = (string)new String(cmds[1].Where(Char.IsLetter).ToArray());
                Command c2 = new Command(secondDir, disConvert(cmds[1]));
                validateDir(secondDir, cmds[1], listBC, c2);

                string thirdDir = (string)new String(cmds[2].Where(Char.IsLetter).ToArray());
                Command c3 = new Command(thirdDir, disConvert(cmds[2]));
                validateDir(thirdDir, cmds[2], listBC, c3);

                string fourthDir = (string)new String(cmds[3].Where(Char.IsLetter).ToArray());
                Command c4 = new Command(fourthDir, disConvert(cmds[3]));
                validateDir(fourthDir, cmds[3], listBC, c4);
                Console.WriteLine("\n");

            }
            if (listBC.Count() != 0){
                Console.WriteLine("\n\nIncorrect commands sorted by sets: ");

                foreach (BadCommand badCommand in listBC){
                    e += 1;
                    Console.WriteLine(e + ". " + badCommand.command.error);
                }
            }
        }

        private int disConvert(string str){
            
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in str){
                if ((c >= '0' && c <= '9')){
                    stringBuilder.Append(c);
                }
            }

            int distance = Int32.Parse(stringBuilder.ToString());
            return distance;
        }

        private void validateDir(string direction, string dirDis, List<BadCommand> listBC, Command c){

            if ((direction.Equals("l")) || (direction.Equals("r")) || (direction.Equals("u")) || (direction.Equals("d"))){

                Console.WriteLine(c.ToString());
            }
            else{
                Console.WriteLine(" - Error! - ");
                Command error = new Command(dirDis);
                BadCommand badCommand = new BadCommand(error);
                listBC.Add(badCommand);
            }
        }
    }
}