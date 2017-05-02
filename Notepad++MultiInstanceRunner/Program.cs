namespace Notepad__MultiInstanceRunner
{
    internal class Program
    {
        private static void Main(string[] args)
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
