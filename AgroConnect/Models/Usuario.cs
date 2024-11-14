using System;

namespace AgroConnect.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public string Numero { get; set; }

        public string Cep { get; set; }

        public string Senha { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now; // Inicializa com a data atual

        // Você pode adicionar métodos ou propriedades adicionais conforme necessário
    }
}
