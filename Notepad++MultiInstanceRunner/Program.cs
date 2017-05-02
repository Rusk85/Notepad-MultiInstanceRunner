using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Notepad__MultiInstanceRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().StartNotepadMultiInst();
        }

        private void StartNotepadMultiInst()
        {
            var nppRunner = new NotepadPlusPlus();
            nppRunner.StartMultiInstance();
        }
    }
}
