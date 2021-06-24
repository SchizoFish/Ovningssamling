using System;

namespace Övningssamling
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonHandler person = new PersonHandler();

            try
            {                
                person.PrintPerson(person.CreatePerson(20, "Anna", "Andersson", 168, 65));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
