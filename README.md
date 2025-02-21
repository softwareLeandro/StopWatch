# StopWatch - Cronômetro Simples

## Descrição
StopWatch é um projeto simples desenvolvido em C# para fins de estudo. Ele implementa um cronômetro funcional que permite ao usuário definir um tempo em segundos ou minutos para contagem regressiva.

## Funcionalidades
- O usuário pode inserir o tempo no formato de segundos (`s`) ou minutos (`m`).
- O programa faz uma contagem progressiva até atingir o tempo definido.
- Mensagens indicam o início e o fim da contagem.
- O programa permite que o usuário volte ao menu para definir um novo tempo.

## Como Usar
1. Compile e execute o programa.
2. No menu principal, insira o tempo desejado para a contagem:
   - Exemplo: `10s` para 10 segundos.
   - Exemplo: `1m` para 1 minuto.
3. O cronômetro exibirá uma contagem progressiva até atingir o tempo definido.
4. Após a conclusão da contagem, o usuário retorna ao menu principal.
5. Para sair, digite `0`.

## Estrutura do Código
- `Menu()`: Exibe o menu principal e recebe a entrada do usuário.
- `PreStart(int time)`: Exibe uma contagem regressiva "Ready, Set, Go" antes de iniciar o cronômetro.
- `Start(int time)`: Inicia a contagem do tempo e exibe a contagem progressiva.

## Tecnologias Utilizadas
- Linguagem: C#
- Biblioteca: `System.Threading` para controle do tempo (Thread.Sleep).

## Como Executar
1. Instale o .NET SDK se ainda não o tiver.
2. Compile o código usando o comando:
   ```sh
   csc Program.cs
   ```
3. Execute o programa com:
   ```sh
   ./Program
   ```

## Autor
Projeto desenvolvido para fins de estudo em C#.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# StopWatch - Simple Stopwatch

## Description
StopWatch is a simple project developed in C# for learning purposes. It implements a functional stopwatch that allows the user to set a countdown in seconds or minutes.

## Features
- The user can enter the time in seconds (`s`) or minutes (`m`).
- The program counts up until the defined time is reached.
- Messages indicate the start and end of the countdown.
- The program allows the user to return to the menu to set a new time.

## How to Use
1. Compile and run the program.
2. In the main menu, enter the desired countdown time:
   - Example: `10s` for 10 seconds.
   - Example: `1m` for 1 minute.
3. The stopwatch will display a progressive count until the defined time is reached.
4. After the countdown is complete, the user returns to the main menu.
5. To exit, enter `0`.

## Code Structure
- `Menu()`: Displays the main menu and receives user input.
- `PreStart(int time)`: Shows a "Ready, Set, Go" countdown before starting the stopwatch.
- `Start(int time)`: Starts the time count and displays the progressive count.

## Technologies Used
- Language: C#
- Library: `System.Threading` for time control (Thread.Sleep).

## How to Run
1. Install the .NET SDK if you haven't already.
2. Compile the code using the command:
   ```sh
   csc Program.cs
   ```
3. Run the program with:
   ```sh
   ./Program
   ```

## Author
Project developed for learning purposes in C#.

