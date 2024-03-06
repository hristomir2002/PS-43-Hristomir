using Welcome.Others;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

internal class Program
{
    public static ActionOnError Log { get; private set; }

    private static void Main(string[] args)
    {
        try
        {
            var user = new User("John Smith", "password123", UserRolesEnum.STUDENT);

            var viewModel = new UserViewModel(user);

            var view = new UserView(viewModel);

            view.Display();

            view.DisplayError();
        }
        catch (Exception e)
        {
            ActionOnError log = new ActionOnError(Log);
            log(e.Message);
        }
        finally
        {
            Console.WriteLine("Executed in any case!");
        }
    }
}