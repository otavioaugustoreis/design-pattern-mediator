using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_mediator
{
    public class FacebookGroupMediator : IFacebookMediator
    {

        public List<UsuarioEntity> usuarios { get; set; } = new();

        public void EnviarMensagem(string mensagem, UsuarioEntity usuarioEntity)
        {
            foreach (var usuario in usuarios)
            {
                if(usuario != usuarioEntity)
                {
                    usuario.Receber(mensagem);
                }
            }
        }

        public void RegistrarUsuario(UsuarioEntity usuarioEntity)
        {
            usuarios.Add(usuarioEntity);
        }
    }
}
