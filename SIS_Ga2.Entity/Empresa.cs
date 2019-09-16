
namespace SIS_Ga2.Entity
{
    public class Empresa
    {

        public int idempresa { get; set; }
        public string nombre { get; set; }
        public string usuarioempresa { get; set; }
        public string cdempresa { get; set; }
        public string cddivision { get; set; }
        public int estado { get; set; }

        public T Clone<T>() where T : Empresa
        {
            return (T)this.MemberwiseClone();
        }
    }
}
