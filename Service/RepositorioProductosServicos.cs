using MundialApiPet.Modelo.AdministracionUsuario.ModeloRespuesta;
using MundialApiPet.Modelo.AdministracionUsuario;
using MundialApiPet.Modelo.Respuesta;
using MundialApiPet.Modelo;
using System;
using MundialApiPet.Modelo.ProductosServicios.ModeloRespuesta;
using System.Collections.Generic;
using MundialApiPet.Modelo.Inventario;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace MundialApiPet.Service
{
    public class RepositorioProductosServicos
    {

        private readonly Context db;

        public RepositorioProductosServicos(Context context)
        {
            db = context;
        }
        public List<RProductoServicio> ConsultarProductoServicoio(string tipoProducto)
        {
            try
            {
                List<RProductoServicio> listaRProductoServicio = new List<RProductoServicio>();

                listaRProductoServicio = (from articulo in db.ArticulosInventarios
                                          join tipo in db.TiposArticulosInventarios on articulo.IdTipoArticulo equals tipo.IdTipoArticulo
                                          join tipomarca in db.TiposMarcasInventarios on articulo.IdTipoMarca equals tipomarca.IdTipoMarca
                                          join imagen in db.DocumentosAdjuntosArticulos on articulo.IdArticulo equals imagen.IdArticulo
                                          where tipo.Nombre == tipoProducto
                                          select new RProductoServicio 
                                          {
                                              CantidadDisponible = articulo.CantidadDisponible,
                                              Descripcion = "",
                                              IdProdcuto = articulo.IdArticulo,
                                              ImagenArchivo = imagen.Archivo,
                                              Nombre = tipomarca.Nombre,
                                              TipoProducto = tipo.Nombre,
                                              Precio = (int)articulo.Precio

                                          }).ToList();


                return listaRProductoServicio;
            }
            catch (Exception ex)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);

            }
        }
    }
}
