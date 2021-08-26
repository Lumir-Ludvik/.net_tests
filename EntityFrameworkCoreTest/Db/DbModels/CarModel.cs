
namespace EntityFrameworkCoreTest.Db.DbModels
{
    public class CarModel : BaseModel
    {
        public string? Name { get; set; }
        public int? Weight { get; set; } // tons
        public PersonModel? Owner { get; set; }
    }
}