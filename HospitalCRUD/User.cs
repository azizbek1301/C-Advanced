namespace HospitalCRUD;

public class User
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber {  get; set; }
    public DateTime DateOFBirth {  get; set; }
    public GenderType Gender { get; set; }
}
