using Microsoft.EntityFrameworkCore;
using MundialApiPet.Modelo;
using MundialApiPet.Modelo.Inversiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundialApiPet.Service
{
    public class RepositorioInversiones
    {
        private readonly Context _context;

        public RepositorioInversiones(Context context)
        {
            _context = context;
        }
        public List<Inversion> ConsultarListaInversion()
        {
            try
            {
                List<Inversion> lista = new List<Inversion>();
            
                       
                    lista = _context.Inversiones.OrderByDescending(inversion => inversion.IdInversionTienda).ToList();
                
            

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }

        public bool AddAgregarInversion(string fechaRegistro, string valor, string descripcion)
        {
            try
            {

                Inversion modeloInversion = new Inversion();

                modeloInversion.FechaRegistro = Convert.ToDateTime(fechaRegistro);
                modeloInversion.Valor = Convert.ToDecimal(valor);
                modeloInversion.Descripcion = descripcion;



                _context.Inversiones.Add(modeloInversion);
                _context.SaveChanges();

                return true;



            }
            catch (Exception ex)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);

            }
        }
    }
}
