using System.Diagnostics;

namespace Notepad__MultiInstanceRunner
{
    internal class NotepadPlusPlus
    {
        private readonly string _multiInstParameter = "-multiInst";
        private const string NotepadExe = "notepad++.exe";

        public void StartMultiInstance()
        {
            using (var p = new Process
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




