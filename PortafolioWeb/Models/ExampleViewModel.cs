using System.Reflection.Metadata.Ecma335;

namespace PortafolioWeb.Models
{
    public class ExampleViewModel
    {
        public Guid xSingleton { get; set; }
        public Guid xScoped { get; set; }
        public Guid xTransient { get; set; }
    }
}
