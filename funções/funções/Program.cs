
//static void SaudacaoSimples()
//{
//Console.WriteLine("Bem vindo ao SENAI");
//}
//int i = 0;
//while (i < 3)
//
//SaudacaoSimples();
//i++;

//Função de parâmetro sem retorno.
//static void ExibirMensagem(string nome, string tarefa)
//{
    //Console.WriteLine($" Meu noem é: {nome} e desenvolvo {tarefa}");
//}

//Essa função necessita dos parâmetros nome e tarefa do tipo string.
//ExibirMensagem("Micael", "Programas");

//static void SomarNumeros(double n1, double n2)
//{
    //double resultado = n1 + n2;

    //Console.WriteLine(resultado.ToString());
//}

//SomarNumeros(35, 5 + 17.5);

static double CalcIMC(double peso, double altura) 
{
    double IMC = peso / Math.Pow(altura, 2);

    return IMC;
}

double ResultadoIMC = CalcIMC(88, 1.8);

SituacaoIMC(ResultadoIMC);
static void SituacaoIMC(double IMC)
{
    if (IMC < 19.1)
    {
        Console.WriteLine("Abaixo do peso");
    }
    else if (IMC > 19.1 && IMC < 25.3)
    {
        Console.WriteLine("Peso ideal");
    }
    else if(IMC >= 25.3 && IMC <= 32.2)
    {
        Console.WriteLine("Sobrepeso");
    }
    else
    {
        Console.WriteLine("Obeso");
    }
}
CalcIMC(88, 1.8);