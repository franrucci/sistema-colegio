using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraMaterias
    {
        private Context context;
        private static ControladoraMaterias instancia;

        public static ControladoraMaterias Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraMaterias();
                }
                return instancia;
            }
        }

        ControladoraMaterias()
        {
            context = new Context();
        }

        public ReadOnlyCollection<Materia> ListarMateriasDeGrado(int gradoId)
        {
            try
            {
                var materias = context.Materias
                .Where(m => m.GradoId == gradoId)
                .ToList();

                return materias.AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}