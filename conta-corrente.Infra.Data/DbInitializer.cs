using ContaCorrente.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContaCorrente.Infra.Data
{
    public class DbInitializer
    {
        public static void Initialize(ContaCorrenteContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Pessoa.Any())
            {
                return;   // DB has been seeded
            }

            var pessoas = new Pessoa[]
            {
                new Pessoa{Nome="Luiz",Sobrenome="Silva",DataNascimento=DateTime.Parse("1994-16-08"), CPF="123456789", Sexo=Sexo.Masculino, RG="123456789"}
            };

            foreach (Pessoa s in pessoas)
            {
                context.Pessoa.Add(s);
            }
            context.SaveChanges();

            var agencias = new Agencia[]
            {
                new Agencia{Endereco="Rua XPTO", Nome="Coutinho Fernandes", Numero=123}
            };
            foreach (Agencia c in agencias)
            {
                context.Agencia.Add(c);
            }
            context.SaveChanges();

            var contas = new Conta[]
            {
                new Conta{NumeroConta=123, Saldo=10.000 }
            };
            foreach (Conta e in contas)
            {
                context.Conta.Add(e);
            }
            context.SaveChanges();
        }
    }
}
