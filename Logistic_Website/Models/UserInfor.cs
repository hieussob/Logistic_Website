namespace Logistic_Website.Models;

public class UserInfor
{
    public string Name { get; set; }
    public string Decreption { get; set; }
    public string Image { get; set; }
}

public class RateUserInfor : UserInfor
{
    public string Comment { get; set; }
    public int Rate { get; set; }
}
