using System;
using pwdgenlib;

namespace pwdgencore
{
    

    class Program
    {
        static void Main(string[] args)
        {
            pwdgenModes mode = 0;
            int len = 9;
            foreach (var arg in args)
            {
                switch (arg)
                {
                    case "/R":
                        mode |= pwdgenModes.UpperRussian; break;
                    case "/r":
                        mode |= pwdgenModes.LowerRussian; break;
                    case "/E":
                        mode |= pwdgenModes.UpperEnglish; break;
                    case "/e":
                        mode |= pwdgenModes.LowerEnglish; break;
                    case "/n":
                        mode |= pwdgenModes.Numbers; break;
                    case "/c":
                        mode |= pwdgenModes.Chars; break;
                    default:
                        if ('/' == arg[0] && int.TryParse(arg.Substring(1), out var j))
                            len = j;
                        break;
                }
            }
            Console.WriteLine(new pwdgen(mode).Generate(len));
        }
    }
}
