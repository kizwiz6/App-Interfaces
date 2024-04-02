namespace App_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            tdl.Display();
            tdl.Reset();
            tdl.Display();

            PasswordManager pm = new PasswordManager("iluvpie", true);
            pm.Display();
            pm.Reset();
            pm.Display();
        }
    }
}
