using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_mediator
{
    public interface IFacebookMediator
    {
        void RegistrarUsuario(UsuarioEntity usuarioEntity);
        void EnviarMensagem(string mensagem,UsuarioEntity usuarioEntity);
    }
}
