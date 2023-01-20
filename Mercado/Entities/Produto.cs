using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mercado.Entities
{
    public class Produto
    {
        private Guid _id;
        private string? _nome;
        private decimal? _preco;
        private int _quantidade;
        private DateTime? _dataCompra;
        private Categoria _categoria;
        private Fornecedor _fornecedor;

        public Guid Id
        {

            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("Por favor, informe um ID válido.");

                _id = value;
            }

            get => _id;

        }

        public string Nome
        {

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor, informe o nome do funcionário.");

                var regex = new Regex("^[A-za-zá-üÁ-Ü\\s]{6,150}$");

                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor informe Nome válido.");

                _nome = value;
            }

            get => _nome;

        }

        public decimal? Preco
        {
            set
            {

                if (value <= 0)
                    throw new ArgumentException("O Preço do produto deve ser maior do que zero.");

                _preco = value;
            }
            get => _preco;

        }

        public int Quantidade
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("A quantidade do produto deve ser maior do que zero.");
                _quantidade = value;
            }
            get => _quantidade;

        }

        public DateTime? DataCompra
        {
            set
            {
                if (value == DateTime.MinValue)
                    throw new ArgumentException("Por favor, informe a data da compra.");
                _dataCompra = value;
            }
            get => _dataCompra;
        }

        public Categoria Categoria
        {
            set { _categoria = value; }
            get => _categoria;
        }

        public Fornecedor Fornecedor
        {
            set { _fornecedor = value; }
            get => _fornecedor;
        }
    }
}
