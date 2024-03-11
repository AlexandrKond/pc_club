using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

public class User
{
    [Key]
    public int id { get; set; }
    public string? login { get; set; }
    public string? password { get; set; }
    public string? type_user { get; set; }
    public static User? currentUser { get; set; }
}
public class Table
{
    [Key]
    public int? id_table { get; set; }
    public string? type_hall { get; set; }
    public string? keyboard { get; set; }
    public string? mouse { get; set; }
    public string? headphones { get; set;}
    public int? price { get; set; }
    public static Table? currentTable { get; set; }
}

public class Reservation
{
    [Key]
    public int id_reservation { get; set; }
    public string? name { get; set; }
    public string? telephone { get; set; }
    public int? arend_time { get; set; }
    public string? type_hall { get; set; }
    public string? date { get; set; }
    public int? peoples { get; set; }
    public string? time { get; set; }
    public static Reservation? currentReservation { get; set; }
}


