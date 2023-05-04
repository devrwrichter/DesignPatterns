namespace Richter.DesignPatterns.Command.JB
{
    public class CommandPatternJB
    {
        public delegate void Invoker();
        public static Invoker Execute, Undo, Redo;
        public class CommandJB
        {
            public CommandJB(Receiver receiver)
            {
                Execute = receiver.Action;
                Undo = receiver.Reverse;
                Redo = receiver.Action;
            }
        }

        public class Receiver
        {
            string build, oldbuild;
            string s = "Some string ";

            public void Action()
            {
                oldbuild = build;
                build += s;
                Console.WriteLine($"Receiving is adding to {build}");
            }

            public void Reverse()
            {
                build = oldbuild;
                Console.WriteLine($"Receiving is reverting to {build}");
            }
        }
    }
}
