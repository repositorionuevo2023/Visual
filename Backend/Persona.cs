namespace Backend
{
    public class Persona
    {
        public string CUI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dirreccion { get; set; }

        public Persona(string cUI, string nombre, string apellidos, string dirreccion)
        {
            CUI = cUI;
            Nombre = nombre;
            Apellidos = apellidos;
            Dirreccion = dirreccion;
        }
    }
}