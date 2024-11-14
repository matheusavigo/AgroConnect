using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AgroConnect.Models
{
    public class Cadastro
    {


        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }


        [Column("endereco")]
        public string Endereco { get; set; }


        [Column("numero")]
        public string Numero { get; set; }


        [Column("cep")]
        public string Cep { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        [Column("data_cadastro")]
        public DateTime DataCadastro { get; set; }

    }

 }

    

