namespace PortafolioWeb.Services
{
    public class TestSingleton
    {

        public TestSingleton()
        {
                obtenerGuid = Guid.NewGuid();
        }

        public Guid obtenerGuid { get; private set; }

    } // Genera un String aleatorio

    public class TestScoped
    {

        public TestScoped()
        {
            obtenerGuid = Guid.NewGuid();
        }

        public Guid obtenerGuid { get; private set; }

    }

    public class TestTransient
    {

        public TestTransient()
        {
            obtenerGuid = Guid.NewGuid();
        }

        public Guid obtenerGuid { get; private set; }

    }
}
