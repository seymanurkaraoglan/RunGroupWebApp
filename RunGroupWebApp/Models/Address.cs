using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.Models
{
    //model içinde oluşturulan sınıflar veri tabanındaki nesneleri oluşturur. Bu nesnelerin dbdeki karşılığı tablolardır.
    public class Address 
    {
        [Key] //primary key
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
