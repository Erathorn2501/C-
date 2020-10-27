using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ClasseTest
    {
        char[] text;

        public ClasseTest(char[] text)
        {
            this.text = text;
        }

        public void changeLetter ()
        {
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i]) {
                    case 'a':
                        text[i] = 'd';
                        break;
                    case 'b':
                        text[i] = 'e';
                        break;
                    case 'c':
                        text[i] = 'f';
                        break;
                    case 'd':
                        text[i] = 'g';
                        break;
                    case 'e':
                        text[i] = 'h';
                        break;
                    case 'f':
                        text[i] = 'i';
                        break;
                    case 'g':
                        text[i] = 'j';
                        break;
                    case 'h':
                        text[i] = 'k';
                        break;
                    case 'i':
                        text[i] = 'l';
                        break;
                    case 'j':
                        text[i] = 'm';
                        break;
                    case 'k':
                        text[i] = 'n';
                        break;
                    case 'l':
                        text[i] = 'o';
                        break;
                    case 'm':
                        text[i] = 'p';
                        break;
                    case 'n':
                        text[i] = 'q';
                        break;
                    case 'o':
                        text[i] = 'r';
                        break;
                    case 'p':
                        text[i] = 's';
                        break;
                    case 'q':
                        text[i] = 't';
                        break;
                    case 'r':
                        text[i] = 'u';
                        break;
                    case 's':
                        text[i] = 'v';
                        break;
                    case 't':
                        text[i] = 'w';
                        break;
                    case 'u':
                        text[i] = 'x';
                        break;
                    case 'v':
                        text[i] = 'y';
                        break;
                    case 'w':
                        text[i] = 'z';
                        break;
                    case 'x':
                        text[i] = 'a';
                        break;
                    case 'y':
                        text[i] = 'b';
                        break;
                    case 'z':
                        text[i] = 'c';
                        break;
                }
            }
        }

        public override string ToString()
        {
            string tamp = "";

            for (int i = 0; i < text.Length; i++)
            {
                tamp += text[i];
            }

                return tamp;
        }
    }
}
