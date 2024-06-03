

// 1 - Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!
// 2 - Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.

//Console.WriteLine("Digite seu nome: ");
//string name = Console.ReadLine();
//Console.WriteLine("Digite seu sobrenome: ");
//string surname = Console.ReadLine();

//PrintPhrase(name);
//PrintFullName(name, surname);

//static void PrintPhrase(string name)
//{
//    Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
//}

//static void PrintFullName(string name, string surname)
//{
//    Console.WriteLine($"{name} {surname}");
//}


// 3 - Crie um programa com 2 valores do tipo double já declarados que retorne:

//Console.WriteLine("Digite o primeiro valor: ");
//string value01 = Console.ReadLine();
//double value01Double = Convert.ToDouble(value01);

//Console.WriteLine("Digite o segundo valor: ");
//string value02 = Console.ReadLine();
//double value02Double = Convert.ToDouble(value02);

//Sum(value01Double, value02Double);

//static void Sum(double value01, double value02)
//{
//    double result = value01 + value02;
//    Console.WriteLine($"O resultado da soma é: {result}");
//}

//Subtraction(value01Double, value02Double);
//static void Subtraction(double value01, double value02)
//{
//    double result = value01 - value02;
//    Console.WriteLine($"O resultado da subtração é: {result}");
//}


//Multiplication(value01Double, value02Double);

//static void Multiplication(double value01, double value02)
//{
//    double result = value01 * value02;
//    Console.WriteLine($"O resultado da multiplicação é: {result}");
//}

//Division(value01Double, value02Double);

//static void Division(double value01, double value02)
//{
//    double result = value01 / value02;
//    Console.WriteLine($"O resultado da divisão é: {result}");
//}

//Average(value01Double, value02Double);

//static void Average(double value01, double value02)
//{
//    double result = (value01 + value02) / 2;
//    Console.WriteLine($"O resultado da média é: {result}");
//}

// 4 - Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
//Console.WriteLine("Digite uma palavra ou frase: ");
//string words = Console.ReadLine();

//Console.WriteLine($"A palavra ou frase digitada tem {words.Length} caracteres.");

// 5 - Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:

//Console.WriteLine("Digite a placa do veículo: ");
//string plate = Console.ReadLine();

//CheckPlate(plate);

//static void CheckPlate(string plate)
//{

//        if (plate.Length == 8 && char.IsLetter(plate[0]) && char.IsLetter(plate[1]) && char.IsLetter(plate[2]))
//        {            
//            if (plate[3] == '-')
//            {         
//                if (char.IsDigit(plate[4]) && char.IsDigit(plate[5]) && char.IsDigit(plate[6]) && char.IsDigit(plate[7]))
//                {
//                    Console.WriteLine("Placa válida!");
//                }
//                else
//                {
//                    Console.WriteLine("Placa inválida!");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Placa inválida!");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Placa inválida!");
//        }    
//}

// 6 - 1. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
//    -Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
//    - Apenas a data no formato "01/03/2024".
//    - Apenas a hora no formato de 24 horas.
//    - A data com o mês por extenso.

Console.WriteLine("Digite 1 para exibir a data atual no formato completo.");
Console.WriteLine("Digite 2 para exibir apenas a data no formato '01/03/2024'.");
Console.WriteLine("Digite 3 para exibir apenas a hora no formato de 24 horas.");
Console.WriteLine("Digite 4 para exibir a data com o mês por extenso.");

string option = Console.ReadLine();

switch (option)
{
    case "1":
        FullDate();
        break;
    case "2":
        OnlyDate();
        break;
    case "3":
        OnlyHour();
        break;
    case "4":
        DateWithMonth();
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}

static void FullDate()
{
    DateTime date = DateTime.Now;
    Console.WriteLine(date.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
}

static void OnlyDate()
{
    DateTime date = DateTime.Now;
    Console.WriteLine(date.ToString("dd/MM/yyyy"));
}

static void OnlyHour()
{
    DateTime date = DateTime.Now;
    Console.WriteLine(date.ToString("HH:mm:ss"));
}

static void DateWithMonth()
{
    DateTime date = DateTime.Now;
    Console.WriteLine(date.ToString("dd MMMM yyyy"));
}