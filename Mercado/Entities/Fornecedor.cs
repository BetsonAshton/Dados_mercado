using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mercado.Entities
{
    public class Fornecedor
    {
        private Guid _idFornecedor;
        private string? _nome;
        private string? _cnpj;


        public Guid IdFornecedor
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("Por favor informe um id válido.");

                _idFornecedor = value;
            }
            get => _idFornecedor;
        }

        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor, informe o Nome do fornecedor");

                var regex = new Regex("^[A-Za-zÁ-Üá-ü\\s]{6,150}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor informe um nome válido");

                _nome = value;
            }
            get => _nome;
        }

        public string Cnpj
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Digite o CNPJ do fornecedor.");

                var regex = new Regex("^[0-9]{14}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor digite um CNPJ válido.");
                _cnpj = value;
            }

            get => _cnpj;
        }

    }
}
