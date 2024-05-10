namespace SistemaVenta.API.Utilidad
{
    public class Response<T>
    {
        public bool stauts { get; set; }
        public T value { get; set; }
        public string msg { get; set; }
    }
}
