

using HospitalCRUD;


User user = new User();
user.Id = 1;
user.Name = "Ali";
user.LastName = "Valiyev";
user.DateOFBirth = new DateTime(2000, 12, 31);
user.PhoneNumber = "+998935624414";
user.Gender = GenderType.Male;
UserService users=new UserService();

users.Create(user);
users.GetAll();