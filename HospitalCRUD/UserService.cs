namespace HospitalCRUD;

public class UserService
{
    List<User> users = new List<User>();
    public bool Create(User user)
    {
        var existUser=users.FirstOrDefault(u=> u.Id == user.Id);
        if(existUser ==null)
        {
            users.Add(user);
            return true;
        }
        return false;
        
    }

    public User GetById (long id)
    {
        var user=users.FirstOrDefault(x=>x.Id == id);
        if(user != null)
        {
            return user;
        }
        return null;

    }
    public void Update(long  id)
    {
        var user=new User();
        var existUser=users.FirstOrDefault(user=>user.Id == id);
        if(existUser == null)
        {
            Console.WriteLine("Bunday user yo'q");
            
        }
        else
        {
            users.Remove(existUser);
            
           
            user.Id = id;
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
            users.Add (user);
            Console.WriteLine("Qo'shildi");
        }    
        
        

        
    }

    public bool Delete(long id)
    {
        var user=users.FirstOrDefault(x=>x.Id == id);
        if(user is null)
        {
            return false ;
        }
         users.Remove(user);
         return true;
    }
    public void GetAll()
    {
        foreach(var item in users)
        {
            Console.Write($"Id : {item.Id}\nName: {item.Name}\nLastName: {item.LastName}\n" +
                $"PhoneNumber: {item.PhoneNumber}\nDateOfBirth: {item.DateOFBirth.ToString("yyyy-MM-dd")}\n" +
                $"Gender: {item.Gender}");
        }
    }
}
