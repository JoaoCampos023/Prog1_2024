
namespace TrabalhoFinal.Models
{
    public class Endereco
    {
        public string? Rua { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? CEP { get; set; }
        public Customer? Customer { get; set; }

        public Endereco(string? rua, string? numero, string? bairro, string? cidade, string? estado, string? cep)
        {
            Rua = rua!;
            Numero = numero!;
            Bairro = bairro!;
            Cidade = cidade!;
            Estado = estado!;
            CEP = cep!;
        }

        public override string ToString()
        {
            return $"Rua: {Rua}, Numero: {Numero} - Bairro: {Bairro}, Cidade: {Cidade} - Estado: {Estado}, CEP: {CEP}";
        }

        
    }
}