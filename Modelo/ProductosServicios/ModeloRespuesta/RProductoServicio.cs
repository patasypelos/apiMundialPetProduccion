namespace MundialApiPet.Modelo.ProductosServicios.ModeloRespuesta
{
    public class RProductoServicio
    {
        public int IdProdcuto { get; set; }
        public string TipoProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImagenArchivo { get; set; }
        public int Precio { get; set; }
        public int? CantidadDisponible { get; set; }
    }
}
