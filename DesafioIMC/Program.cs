using System;

namespace DesafioIMC
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a calculadora de IMC!");
            Console.WriteLine("********************************");
            Console.WriteLine("Digite seu nome completo");
            String nome = Console.ReadLine();

            Console.WriteLine("Digite seu sexo: ");
            String sexo = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            // Digite a altura com "," Ex: 1,65
            Console.WriteLine("Digite sua altura: ");
            String altura = Console.ReadLine();
            double alturaConvert = validaDadosAltura(altura);
            //Digite o peso com "," Ex:64,5
            Console.WriteLine("Digite sua peso: ");
            string peso = Console.ReadLine();
            double pesoConvert = validaDadosPeso(peso);

            // Cálculo IMC
            double IMC = pesoConvert/(alturaConvert*alturaConvert);
            double IMCArrendondado = Math.Round(IMC, 1);


            //Valida altura 

            double validaDadosAltura (string valor)
            {
                string valorRetorno = null;
                if (!(valor.Contains(".") || valor.Contains(","))) 
                {    
                   Console.WriteLine("Altura informada errada digite com ponto ou vírgula. Exemplo: 1,00 ou 1.00 ");
                   Environment.Exit(1);
                }else if (valor.Contains(".")){
                   valorRetorno = valor.Replace(".", ",");
                }else{
                    valorRetorno = valor;
                }
                return double.Parse(valorRetorno);
                }

            //Valida Peso
            double validaDadosPeso(string valor)
            {
                string valorRetorno = null;
                if (!(valor.Contains(".") || valor.Contains(",")))
                {
                    Console.WriteLine("Peso informado errado digite com ponto ou vírgula. Exemplo: 64,00 ou 64.00 ");
                    Environment.Exit(1);
                }
                else if (valor.Contains("."))
                {
                    valorRetorno = valor.Replace(".", ",");
                }
                else
                {
                    valorRetorno = valor;
                }
                return double.Parse(valorRetorno);
            }
            Console.WriteLine();
            Console.WriteLine();


            String risco;

            //Validação IMC
            if (IMCArrendondado < 20.0) {
                risco = "Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.";
            } else if (IMCArrendondado >= 20 && IMCArrendondado <= 24) {
                risco = "Seu peso está ideal para suas referências.";
            } else if (IMCArrendondado >= 25 && IMCArrendondado <= 29) {
                risco = "Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.";
            } else if (IMCArrendondado >= 30 && IMCArrendondado <= 35) {
                risco = "Quem tem obesidade vai estar mais exposto a doenças graves e aorisco de mortalidade.";
            } else {
                risco = "O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas.";
            }

            String categoria;

            //Validação Idade
            if (idade < 12) {
                categoria = "Infantil";
            } else if (idade >= 12 && idade <= 20) {
                categoria = "Juvenil";
            } else if (idade >= 21 && idade <= 65) {
                categoria = "Adulto"; }
            else {
                categoria = "Idoso";
            }

            String recomendacao;

            // Valida Recomendação
            if (IMCArrendondado < 20) {
                recomendacao = "Inclua carboidratos simples em sua dieta, além de proteínas indispensáveis para ganho de massa magra. Procure um profissional.";
            } else if (IMCArrendondado >= 20 && IMCArrendondado <= 24) {
                recomendacao = "Mantenha uma dieta saudável e faça seus exames periódicos. ";
            } else if (IMCArrendondado >= 25 && IMCArrendondado <= 29) {
                recomendacao = "Adote um tratamento baseado em dieta balanceada, exercício físico e medicação. A ajuda de um profissional pode ser interessante ";
            } else if (IMCArrendondado >= 30 && IMCArrendondado <= 35) {
                recomendacao = "Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista(endócrino).";
            } else {
                recomendacao = "Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médicoespecialista(endócrino). ";
            }



            // Diagnóstico 
            Console.WriteLine("DIAGNÓSTICO PRÉVIO ");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Categoria: " + categoria);
            Console.WriteLine();
            Console.WriteLine("IMC Desejável: entre 20 e 24 ");
            Console.WriteLine("Resultado IMC:" + IMCArrendondado);
            Console.WriteLine("Riscos: " + risco);
            Console.WriteLine("Recomendação inicial: " + recomendacao);

        }
    }
}

