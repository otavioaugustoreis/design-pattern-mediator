// See https://aka.ms/new-console-template for more information



using design_pattern_mediator;
using System.Reflection.Metadata;

FacebookGroupMediator facebookGroupMediator = new FacebookGroupMediator();


UsuarioEntity p1 = new UsuarioCadastrado(facebookGroupMediator, 1, "Otavio");
UsuarioEntity p2 = new UsuarioCadastrado(facebookGroupMediator, 2, "Artur");
UsuarioEntity p3 = new UsuarioCadastrado(facebookGroupMediator, 3, "Joao");
UsuarioEntity p4 = new UsuarioCadastrado(facebookGroupMediator, 4, "Bruna");

facebookGroupMediator.RegistrarUsuario(p1);
facebookGroupMediator.RegistrarUsuario(p2);
facebookGroupMediator.RegistrarUsuario(p3);
facebookGroupMediator.RegistrarUsuario(p4);


p1.Enviar("Olá Artur, eu sou o Otavio");
p2.Enviar("Olá Joao, eu sou o Artur");
p3.Enviar("Olá Bruna eu sou o Joao");
p4.Enviar("Oi gente, eu sou a Bruna");