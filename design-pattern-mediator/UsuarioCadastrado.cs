using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_mediator
{
    public class UsuarioCadastrado : UsuarioEntity
    {


        public UsuarioCadastrado(FacebookGroupMediator mediator, int id, string nome) : base(mediator, id, nome)
        {
        }

        public override void Enviar(string message)
        {
            Console.WriteLine($"\n{Nome} : enviada <= {message} ");
            Mediator.EnviarMensagem(message, this);

        }

        public override void Receber(string message)
        {
            Console.WriteLine($"{Nome} : recebida <= {message}");
        }
    }
}
