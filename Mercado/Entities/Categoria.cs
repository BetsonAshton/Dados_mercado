using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mercado.Entities
{
    public class Categoria
    {

        private Guid _id;
        private string _descricao;

        #region
        public Guid Id
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("Informe o id da categoria.");

                _id = value;
            }
            get => _id;
        }

        public string Descricao
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor informe uma descrição");

                var regex = new Regex("^[A-Za-zÁ-Üá-ü]{6,150}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Informe uma descrição válida");
                _descricao = value;
            }
            get => _descricao;
        }
    }
}
   #endregion  


