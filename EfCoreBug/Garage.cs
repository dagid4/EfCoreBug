using System.Collections.Generic;

namespace EfCoreBug
{
    public class Garage
    {
        public int Id { get; set; }

        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
