namespace HospitalCRUD;

public class UI
{
    public void Print()
    {
        UserService users = new UserService();
        bool chek = true;
        while (chek)
        {
            Console.WriteLine("1 -> Create");
            Console.WriteLine("2 -> GetById");
            Console.WriteLine("3 -> Update");
            Console.WriteLine("4 -> Delete");
            Console.WriteLine("5 -> GetAll");
            Console.WriteLine("6 -> Exit");
            int num = int.Parse(Console.ReadLine());
            if (num > 0 && num < 7)
            {
                switch (num)
                {
                    case 1:
                        User user = new User();
                        Console.WriteLine("Enter Id");
                        user.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter FirstName");
                        user.Name = Console.ReadLine();
                        Console.WriteLine("Enter LastName");
                        user.LastName = Console.ReadLine();
                        Console.WriteLine("Enter Phone");
                        user.PhoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter DateOfBirth");
                        user.DateOFBirth = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Gender");
                        user.Gender = (GenderType)(int.Parse(Console.ReadLine()));
                        users.Create(user);
                        break;
                    case 2:
                        Console.WriteLine("Enter Id");
                        users.GetById(long.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Enter Id");
                        users.Update(long.Parse(Console.ReadLine()));
                        break;
                    default:
                        Console.WriteLine("Noto'gri son kiritildi");
                        break;

                }

            }
        }
    }
}
