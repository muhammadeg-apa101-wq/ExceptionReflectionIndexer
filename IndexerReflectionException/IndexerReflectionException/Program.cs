using IndexerReflectionException.Models;
using System.Reflection;

namespace IndexerReflectionException
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region students
            //Students allStudents = new Students();


            //allStudents.students.Add(new Students { StudentId = 1, StudentName = "Baloglan", StudentSurname = "Baloglanov" });
            //allStudents.students.Add(new Students { StudentId = 2, StudentName = "John", StudentSurname = "Doe" });
            //allStudents.students.Add(new Students { StudentId = 3, StudentName = "Alice", StudentSurname = "Smith" });
            //allStudents.ShowAllStudentsInfo();
            #endregion

            #region Reflection
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //Console.WriteLine(assembly.GetTypes());
            #endregion

            #region Login
            string mail = Console.ReadLine();
            string password = Console.ReadLine();
            try
            {
                if (!mail.Contains('@') || password.Length < 8)
                {
                    throw new Exceptions.LoginException("Mailinizde xeta veya password serte uygun daxil etmemisiniz");


                }
                else
                {
                    Console.WriteLine($"Ugurla qeydiyyat oldunuz. Mail {mail} password: {password}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
}
