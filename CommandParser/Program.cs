using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    public class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser();

            List<string> commandS = new List<string>();

            commandS.Add("lx20,r32,d1,u12");
            commandS.Add("22,r3,d11,u32");
            commandS.Add("l10,r22,14,u11");
            commandS.Add("x2z,r32,d1,u12");
            commandS.Add("l24,r35,dx11y,u16");
            commandS.Add("l20l,rr32,d1,uu12");
            commandS.Add("lx20,r32,d1,tu12");

            parser.parsering(commandS);

                
            //Console.WriteLine("Test");
            //Console.ReadLine();
        }
    }
}
