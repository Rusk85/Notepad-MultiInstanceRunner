using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad__MultiInstanceRunner
{
    using System.Diagnostics;

    class NotepadPlusPlus
    {
        private string _multiInstParameter = "-multiInst";
        private const string NotepadExe = "notepad++.exe";

        public void StartMultiInstance()
        {
            using (Process p = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = NotepadExe,
                    Arguments = _multiInstParameter
                }
            })
            {
                p.Start();
            }
        }





    }
}




//Process.Start(new ProcessStartInfo(Application.StartupPath + "\\Tool.exe")
//{
//Arguments = String.Format(@"""{0} {1}""", UserName, Password)
//}
//);