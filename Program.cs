
//1.criar menu bebidas
//2.solicitar que o cliente escolha a bebida
//3.perguntar se deseja que acrescente gelo
//4.caso se "sim" informar na tela que a bebida tera gelo
//5.caso "nao" informar que a bebida sera sem gelo


Console.WriteLine(@$"
  -----------------------------------------
|            Menu Bebidas                  |
| '1' Para Agua                            |
| '2' Para Coca Cola                       |
| '3' Para Sprite Limao                    |                 
| '4' Para Fanta Alaranja                  |
| '5' Para Cerveja                         |
  ----------------------------------------
");

Console.WriteLine($"-Por favor escolha a bebida desejada: ");
Console.WriteLine($" Digite o numero correspondente a bebida, apos escolher digite enter: ");


// recebe a bebida escolhida

string escolhaBebida = (Console.ReadLine());


// gostaria de gelo?
string resposta = (Console.ReadLine().ToLower());




//processamento

switch(escolhaBebida)
{

case "1":

Console.WriteLine($"bebida escolhia: Agua");
Console.WriteLine($"Gostaria de acrescentar gelo a bebida? s/n:");

if(resposta =="s")

{

Console.WriteLine($"Sera acrescentado gelo a sua bebida!");



 
}

else {

Console.WriteLine($"nao sera acrescentado gelo a sua bebida");



}

break;




case "2":

Console.WriteLine($"bebida escolhia: Coca Cola");
Console.WriteLine($"Gostaria de acrescentar gelo a bebida?s/n:");

if(resposta=="s")

{

Console.WriteLine($"Sera acrescentado gelo a sua bebida!");



 
}

else {

Console.WriteLine($"nao sera acrescentado gelo a sua bebida");



}


break;

case "3":

Console.WriteLine($"bebida escolhia: Sprite Limao");
Console.WriteLine($"Gostaria de acrescentar gelo a bebida? s/n:");

if(resposta=="s")

{

Console.WriteLine($"Sera acrescentado gelo a sua bebida!");



 
}

else {

Console.WriteLine($"nao sera acrescentado gelo a sua bebida");



}


break;


case "4":

Console.WriteLine($"bebida escolhia: Sprite Fanta Laranja");
Console.WriteLine($"Gostaria de acrescentar gelo a bebida? s/n:");






break;

case "5":

Console.WriteLine($"bebida escolhia: Sprite Cerveja");
Console.WriteLine($"Gostaria de acrescentar gelo a bebida? s/n:");

break;


default:
Console.WriteLine($"Digite uma opcao valida!");




break;


}











//saidas


