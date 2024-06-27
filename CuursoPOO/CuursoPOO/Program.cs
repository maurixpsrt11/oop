using CuursoPOO;

//CarrinhoItem bola = new CarrinhoItem();

/*bola.Nome = "Bola";
bola.Quantidade = 1;
bola.Preco = 1.11M;*/

Item bola = Item.CriarBola();
bola.Quantidade = 5;
Cesta cesta = new Cesta();
cesta.Itens.Add(bola);

foreach (var item in cesta.Itens)
{
    Console.WriteLine($"{item.Nome}: {item.totalFormatado}");
}

Console.ReadLine();