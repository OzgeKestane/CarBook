namespace CarBook.Domain.Entities
{
    public class Brand
    {
        public int BranId { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
    }
}
