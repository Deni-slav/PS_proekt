using System;
using Welcome.Model;
using Welcome.ViewModel;
using Welcome.Others;
using Welcome.View;

class Program
{
    static void Main(string[] args)
    {
        var manager = new UserListManager();

        var user1 = new User { Names = "Иван Иванов", Password = "pass123", Role = UserRolesEnum.STUDENT, Age = 22 };
        var user2 = new User { Names = "Мария Георгиева", Password = "pass456", Role = UserRolesEnum.PROFESSOR, Age = 45 };
        var user3 = new User { Names = "Асен Петров", Password = "pass789", Role = UserRolesEnum.ADMIN, Age = 30 };

        manager.AddUser(user1);
        manager.AddUser(user2);
        manager.AddUser(user3);

        foreach (var user in manager.GetAllUsers())
        {
            var vm = new UserViewModel(user);
            var view = new UserView(vm);
            view.Display();
            Console.WriteLine($"Възраст: {vm.Age}\n");
        }

        Console.WriteLine($"Средна възраст на потребителите: {manager.GetAverageAge():F2}");

        Console.ReadKey();

         ActionOnError onError = Delegates.LogToConsole;

        var manager = new UserListManager();

        try
        {
            // Предизвикване на грешка при празен списък
            double avgAge = manager.GetAverageAge(); // ще върне 0, няма да хвърли грешка
            if (avgAge == 0)
                throw new Exception("Списъкът с потребители е празен. Няма как да изчислим средна възраст.");

            Console.WriteLine($"Средна възраст: {avgAge}");
        }
        catch (Exception ex)
        {
            onError(ex.Message);

              try
        {
            Console.WriteLine("Средна възраст: " + users.GetAverageAge());

            Console.Write("Въведете име: ");
            var name = Console.ReadLine();

            Console.Write("Въведете парола: ");
            var pass = Console.ReadLine();

            var user = users.GetUser(name, pass);

            if (user == null)
                throw new Exception("Потребителят не е намерен!");

            Console.WriteLine("Успешен вход:");
            Console.WriteLine(user.ToUserString());
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ГРЕШКА] {ex.Message}");
            Console.ResetColor();
        }

        Console.ReadKey();
    }
}
        }
    

    

