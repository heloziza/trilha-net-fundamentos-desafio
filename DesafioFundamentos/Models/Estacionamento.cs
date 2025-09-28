namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // Bônus: verificação se realmente foi digitado algo
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToUpper();
            
            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Placa inválida! Você precisa inserir algo.");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo com placa {placa} estacionado com sucesso!");
            }
        }

        public void RemoverVeiculo()
        {
            // Implementado: Pedir para o usuário digitar a placa e armazenar na variável placa
            // Bônus: verificação se há veículos estacionados para poder remover
            // Bônus: verificação se realmente foi digitado algo

            if (veiculos.Any())
            {
                Console.WriteLine("Digite a placa do veículo para remover:");
                string placa = Console.ReadLine().ToUpper();

                if (string.IsNullOrWhiteSpace(placa))
                {
                    Console.WriteLine("Placa inválida! Você precisa inserir algo.");
                }
                else
                {
                    // Verifica se o veículo existe
                    if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                    {
                        // Implementado: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
                        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                        int horas = Convert.ToInt32(Console.ReadLine());

                        // Implementado: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável
                        decimal valorTotal = precoInicial + precoPorHora * horas;

                        // Implementado: Remover a placa digitada da lista de veículos
                        veiculos.Remove(placa);

                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    }
                    else
                    {
                        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                    }
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Implementado: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (string placaEstacionada in veiculos)
                {
                    Console.WriteLine(placaEstacionada);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
