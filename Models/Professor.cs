using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyPOO.Models
{
    public sealed class Professor : Pessoa // SEALED é uma instancia final de uma herança, então não pode ser herdada
                                            // por outra classe 
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos, sou professor e ganho {Salario}");
        }
    }
}

























// {
//     // public class Professor : Pessoa
//     // {
//     //     public Professor( )
//     //     {
            
//     //     }
//     //     public Professor (string nome) : base (nome)
//     //     {
            
//     //     }
//     //     public decimal Salario { get; set; }

//     //     public override void Apresentar()
//     //     {
//     //         Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos, sou professor e ganho {Salario}");
//     //     }
//     // }
// }