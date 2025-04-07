// Programação orientada a objeto
class Program
{
    class Carro  // Isso é uma Classe
    {
        // Estes são os atributos do objeto Carro
        public string modelo;
        public int ano;
    }
    static void Main()
    {
        Carro meuCarro = new Carro(); // Objeto
        meuCarro.modelo = "Fusca"; // Atribuindo ao objeto
        meuCarro.ano = 1980;

        Console.WriteLine($"Modelo: {meuCarro.modelo}");
        Console.WriteLine($"Ano: {meuCarro.ano}");
    }
}


