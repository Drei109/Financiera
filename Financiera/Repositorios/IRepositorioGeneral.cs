using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Repositorios
{
    public interface IRepositorioGeneral<T>
    {
        #region Métodos
        IList<T> Listar(Expression<Func<T, bool>> ao_llaves = null);
        T Buscar(params object[] ao_parametros);
        void Insertar(T ao_objeto);
        void GuardarCambios();
        #endregion
    }
}
