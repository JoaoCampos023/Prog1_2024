namespace TrabalhoFinal.Models
{
    public class Pedido
    {
        public List<Prato> Pratos { get; private set;}
        public List<int> Quantidades { get; private set; }
        public Customer Customer { get; private set; }

        public Pedido (Customer customer)
        {
            Pratos = new List<Prato>();
            Quantidades = new List<int>();
            Customer = customer;
        }

        public void AdicionarPrato (Prato prato, int quantidade)
        {
            Pratos.Add(prato);
            Quantidades.Add(quantidade);
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            for (int i = 0; i < Pratos.Count; i++)
            {
                total += Pratos[i].Preco * Quantidades[i];
            }
            return total;
        }

        public override string ToString()
        {
            string detalhes = $"Pedido de {Customer}:\n";
            for (int i = 0; i < Pratos.Count; i++)
            {

                detalhes += $"{Pratos[i].Nome} x{Quantidades[i]}: {Pratos[i].Preco * Quantidades[i]:C}\n";
            }
            Console.WriteLine("\n");
            detalhes += $"Total: {CalcularTotal():C}";
            return detalhes;
        }
    }
}