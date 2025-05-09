using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_mediator
{
    public abstract class UsuarioEntity
    {
        public  FacebookGroupMediator Mediator { get; set; }
        public int Id { get; set; }
        public string  Nome { get; set; }

        protected UsuarioEntity(FacebookGroupMediator mediator, int id, string nome)
        {
            Mediator = mediator;
            Id = id;
            Nome = nome;
        }

        public abstract void Enviar(string message);
        public abstract void Receber(string message);
    }
}
