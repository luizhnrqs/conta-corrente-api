using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContaCorrente.Domain
{
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 IdPessoa { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public Sexo Sexo { get; set; }
        public String RG { get; set; }
        public String CPF { get; set; }
        public DateTime DataNascimento { get; set; }
    }

    public enum Sexo
    {
        Masculino, 
        Feminino
    }
}
