# 🧩 Padrão de Projeto: Mediator

O padrão **Mediator** é um padrão comportamental que promove o **baixo acoplamento** entre objetos ao encapsular a lógica de comunicação em um objeto central chamado de **mediador**.

---

## 📌 Objetivo

Evitar a comunicação direta entre objetos e centralizar a lógica de interação em um único ponto, facilitando a manutenção e a escalabilidade do sistema.

---

## 🏗️ Estrutura

O padrão Mediator envolve os seguintes componentes:

- **IMediator (Interface):** Define a interface para comunicação entre os componentes.
- **ConcreteMediator:** Implementa a lógica de comunicação entre os componentes.
- **Componentes (Colleagues):** Objetos que desejam se comunicar entre si, mas fazem isso apenas através do mediador.
