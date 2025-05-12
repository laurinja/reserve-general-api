# Sistema de Reservas de Salas de Estudo

Este é um projeto de console em C# desenvolvido como trabalho prático da disciplina de Programação Orientada a Objetos. O sistema permite configurar regras e registrar reservas de salas de estudo dentro de limites definidos.

## Objetivo

Aplicar conceitos de Programação Orientada a Objetos (POO), como:
- Abstração
- Encapsulamento
- Validação de dados
- Separação de responsabilidades

## Funcionalidades

- Definição de configuração com:
  - Data mínima e máxima para reservas
  - Hora mínima e máxima para reservas
- Registro de reservas com:
  - Data, hora, descrição da sala e capacidade
- Validação de dados conforme as configurações
- Exibição de mensagens de sucesso ou erro
- Impressão formatada da reserva registrada

## Autores
- Victor Luiz de Oliveira Paes
- Laura Kauana Bareto
- Guilherme Campos Feuser

## Estrutura do Projeto
/Modelos
├── ConfiguracaoReserva.cs
└── Reserva.cs
Program.cs


## Arquivos

- **ConfiguracaoReserva.cs**: Armazena os parâmetros de data e hora mínima/máxima e realiza validações.
- **Reserva.cs**: Registra a reserva com validação da configuração e restrições de capacidade.
- **Program.cs**: Interface de console para interação com o usuário.

## Funcionalidades

- Configuração de data e hora mínima/máxima permitidas para reserva
- Registro de reserva com:
  - Data e hora
  - Descrição da sala
  - Capacidade da sala (entre 1 e 39)
- Validação automática dos dados
- Exibição de mensagens de sucesso ou erro

Exemplo de Uso

=== CONFIGURAÇÃO DE RESERVAS ===
Informe a data mínima permitida (dd/mm/yyyy): 01/05/2025
Informe a data máxima permitida (dd/mm/yyyy): 31/05/2025
Informe a hora mínima permitida (hh:mm): 08:00
Informe a hora máxima permitida (hh:mm): 22:00

=== DADOS DA RESERVA ===
Descrição da sala: Laboratório 2
Data da reserva (dd/mm/yyyy): 15/05/2025
Hora da reserva (hh:mm): 14:30
Capacidade da sala: 25

Reserva registrada com sucesso!
Sala: Laboratório 2 | Data: 15/05/2025 | Hora: 14:30:00 | Capacidade: 25 alunos

