using PortafolioWeb.Models;

namespace PortafolioWeb.Services
{

    public interface IProjectsRepository
    {
        List<PortafolioDTO> obtenerPortafolio();
    }

    public class ProjectsRepository : IProjectsRepository
    {
        public List<PortafolioDTO> obtenerPortafolio() 
        {

            return new List<PortafolioDTO> { new PortafolioDTO

                {
                    titulo = "Tek Experts",
                    descripcion = "Technical Support Engineer Lvl2",
                    imagenURL = "/img/tek-experts.png",
                    link = "https://www.tek-experts.com/"
                }
            };
        }
    }
}
