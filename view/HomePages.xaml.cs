using System.Collections.ObjectModel;
using e_commerceJoias.Models;

namespace e_commerceJoias.view;

public partial class HomePages : ContentPage
{
    public ObservableCollection<Produto> NewProducts { get; set; } = new();
    public ObservableCollection<Produto> ColectionProducts { get; set; } = new();

    public HomePages()
    {
        InitializeComponent();
        CarregarNewProducts();
        CarregarColectionProducts();
        BindingContext = this;
    }

    private void CarregarNewProducts()
    {
        var lista = new List<Produto>
        {
            new() { Nome = "Brincos",  Preco = "R$ 89,90",  Imagem = "image_0.png" },
            new() { Nome = "Anéis",    Preco = "R$ 129,90", Imagem = "image_1.png" },
            new() { Nome = "Cordões",  Preco = "R$ 199,90", Imagem = "image_2.png" },
            new() { Nome = "Colares",  Preco = "R$ 249,90", Imagem = "image_3.png" },
        };

        foreach (var produto in lista)
        {
            NewProducts.Add(produto);
        }
    }

    private void CarregarColectionProducts()
    {
        var lista = new List<Produto>
        {
            new() { Nome = "Semi Joias",   Preco = "R$ 79,90",  Imagem = "semi_joia.png" },
            new() { Nome = "Brinco Ouro",  Preco = "R$ 189,90", Imagem = "brinco_joia_b.png" },
            new() { Nome = "Cordão Joias", Preco = "R$ 299,90", Imagem = "cordao_joias.png" },
            new() { Nome = "Coleção 2026", Preco = "R$ 349,90", Imagem = "colecao_2026_a.png" },
        };

        foreach (var produto in lista)
        {
            ColectionProducts.Add(produto);
        }
    }
}
