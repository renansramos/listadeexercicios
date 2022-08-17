// 1. Fazer um programa que leia três valores com ponto flutuante: A, B e C. Em seguida, calcule e mostre:

// Console.WriteLine("Digite o primeiro número: ");
// double a = double.Parse(Console.ReadLine());


// Console.WriteLine("Digite o primeiro número: ");
// double b = double.Parse(Console.ReadLine());


// Console.WriteLine("Digite o primeiro número: ");
// double c = double.Parse(Console.ReadLine());

// a) a área do triângulo retângulo que tem A por base e C por altura. Fórmula: área = (base * altura) / 2
// double area = (a * c) / 2;
// Console.WriteLine($"A área do triangulo é: {area}");

// b) a área do círculo de raio C. Fórmula: área = pi * raio²
// double areaCirculo = 3.14 * (c*c);
// Console.WriteLine($"A área do circulo é: {areaCirculo}");

// c) a área do trapézio que tem A e B por bases e C por altura. Fórmula: área = ((base1 + base2) * altura) / 2
// double areaTrapezio = ((a + b) * c) / 2;
// Console.WriteLine($"A área do Trapézio é: {areaTrapezio}");

// d) a área do quadrado que tem lado B. Fórmula: área = base²
// double areaQuadrado = b * b;
// Console.WriteLine($"A área do Quadrado é: {areaQuadrado}");

// e) a área do retângulo que tem lados A e B. Fórmula: área = base * altura
// double areaTriangulo = a * b;
// Console.WriteLine($"A área do Retangulo é: {areaTriangulo}");




// 2. Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "São Múltiplos" ou "Não são
// Multiplos", indicando se os valores lidos são múltiplos entre si.

// Console.WriteLine("Digite um número inteiro: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite outro número inteiro: ");
// int b = int.Parse(Console.ReadLine());

// if ((a / b) != 0){
//     Console.WriteLine("São Múltiplos");
// } else {
//     Console.WriteLine("Não São Múltiplos");
// }



// 3. A estimativa de três pontos (PERT) é uma técnica utilizada para calcular a duração de uma atividade baseada em
// três valores:
// • A estimativa mais otimista;
// • A estimativa mais pessimista; e
// • A estimativa mais provável.
// Para se calcular o tempo esperado para uma atividade, utiliza-se a seguinte fórmula:
//              [Otimista + Pessimista + (4 x Mais Provável)] / 6

// Crie um programa que leia a estimativa (em horas) otimista, a pessimista e a mais provável e exiba na tela o tempo
// esperado, conforme a fórmula acima. Ex.:
// Otimista: 10
// Pessimista: 30
// Provavel: 15
// PERT = 16.66

// Console.WriteLine("Digite a estimativa OTIMISTA em horas: ");
// double otimista = double.Parse(Console.ReadLine());
// Console.WriteLine("Digite a estimativa PESSIMISTA em horas: ");
// double pessimista = double.Parse(Console.ReadLine());
// Console.WriteLine("Digite a estimativa PROVAVEL em horas: ");
// double provavel = double.Parse(Console.ReadLine());

// double pert = ((otimista) + (pessimista) + (4 * provavel) ) / 6;
// Console.WriteLine($"Otimista: {otimista}");
// Console.WriteLine($"Pessimista {pessimista}");
// Console.WriteLine($"Provável: {provavel}");
// Console.WriteLine($"PERT = {pert}");

// 4. Escreva um programa que leia a nota de um aluno e imprima sua situação com base nas seguintes condições:
// a) Caso a nota seja >= 7: “Aprovado”
// b) Caso a nota seja < 7 e >= 4: “Em recuperação”
// c) Caso a nota seja < 4: “Reprovado”

    // Console.WriteLine("Digite a nota: ");
    // double nota = double.Parse(Console.ReadLine());

    // if (nota >=7){
    //     Console.WriteLine("Aprovado");
    // } else if (nota < 7 & nota >= 4){
    //     Console.WriteLine("Em recuperação");
    // } else {
    //     Console.WriteLine("Reprovado");
    // }

// 5. Escreva um programa, utilizando a estrutura de decisão switch/case, que receba do usuário um número inteiro de 1
// a 3 e imprima a mensagem na tela com base na resposta:
// 1 -> “Bom dia”
// 2 -> “Boa tarde”
// 3 -> “Boa noite”

//  Console.WriteLine("Digite um número: ");
// int numero = int.Parse(Console.ReadLine());

// switch (numero) {
//     case 1:
//     Console.WriteLine("Bom dia :)");    
//     break;

//     case 2:
//     Console.WriteLine("Boa tarde :)"); 
//     break;

//     case 3:
//     Console.WriteLine("Boa noite :)"); 
//     break;
// }

// 6. Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
// Lembrando que, por definição, fatorial de 0 é 1.



//   int numero;            
//   Console.WriteLine("Entre com o número que será fatorado:");            
//   numero = int.Parse(Console.ReadLine());           
//   int fatorial;            
//   fatorial = numero;            

//   for (int i = numero - 1; i > 1; i--)               
//   {                
//     fatorial *= i;            
//   }        

//   Console.WriteLine("Valor total do fatorial:" + fatorial);            
   
// 7. Escreva um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
// começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor. Ex.:
// Entrada: 2
// Saída:
// 1 1 1
// 2 4 8

// System.Console.Write("Digite um número inteiro positivo: ");
// int num = int.Parse(Console.ReadLine());

// for (int i = 0; i < num; i++)
// {
//     System.Console.WriteLine($"{i+1}, {Math.Pow(i+1, 2)}, {Math.Pow(i+1, 3)}");
// }

 



// 8. Escreva um programa que simule a urna eletrônica. A tela a ser apresentada deverá ser da seguinte forma:
// As opções são:
// 1. Candidato Chaves
// 2. Candidata Chiquinha
// 3. Candidato Quico
// 4. Nulo/Branco
// 5. Encerrar a votação
// Entre com o seu voto:
// O programa deverá ler os votos dos eleitores e, quando for entrado o número 5, apresentar as seguintes
// informações:
// a) O número de votos de cada candidato;
// b) A porcentagem de votos nulos;
// c) A porcentagem de votos brancos;
// d) O candidato vencedor.

// Console.WriteLine("Urna Eletronica");
// Console.WriteLine("1. Candidato Chaves");
// Console.WriteLine("2. Candidata Chiquinha");
// Console.WriteLine("3. Candidato Quico");
// Console.WriteLine("4. Nulo/Branco");
// Console.WriteLine("5. Encerrar a votação");

// Console.WriteLine("Entre com seu voto: ");
// int numero = int.Parse(Console.ReadLine());

// int totalChaves = 0;
// int totalChiquinha = 0;
// int totalQuico = 0;
// int totalNulo = 0;



// while (numero < 6){

//     Console.WriteLine("Digite um número: ");
//     int numero2 = int.Parse(Console.ReadLine());
    
//     Console.WriteLine("Urna Eletronica");
//     Console.WriteLine("1. Candidato Chaves");
//     Console.WriteLine("2. Candidata Chiquinha");
//     Console.WriteLine("3. Candidato Quico");
//     Console.WriteLine("4. Nulo/Branco");
//     Console.WriteLine("5. Encerrar a votação");

//     if (numero2 == 1 ){
//         totalChaves = totalChaves + 1;   
//     } else if (numero2 == 2){
//         totalChiquinha = totalChiquinha + 1;   
//     } else if (numero2 == 3){
//         totalQuico = totalQuico + 1;  
//     } else if (numero2 == 4){
//         totalNulo = totalNulo + 1;  
//     } else if (numero2 == 5){
//         break;
//     }

// }

// double porcentagem =  ((double)totalNulo/(totalChiquinha + totalChaves + totalQuico +totalNulo)) * 100;
        
//         Console.WriteLine($"Número de votos Chaves: {totalChaves}");
//         Console.WriteLine($"Número de votos Chiquinha: {totalChiquinha}");
//         Console.WriteLine($"Número de votos Quico: {totalQuico}");
//         Console.WriteLine($"Número de votos Nulo/Branco: {totalNulo}");
//         Console.WriteLine($"Porcentagem de votos em Branco e Nulos: {porcentagem:F2}%");

//         if (totalChiquinha > totalQuico & totalChiquinha > totalChaves){
//             Console.WriteLine($"Chiquinha Ganhou");
//         }else if (totalQuico > totalChiquinha & totalQuico > totalChaves){
//             Console.WriteLine($"Quico Ganhou"); 
//         } else if (totalChaves > totalChiquinha & totalChaves > totalQuico){
//             Console.WriteLine($"Chaves Ganhou"); 
//         } else{
//             Console.WriteLine($"Não Houve Vencedor");
//         }



      










      
