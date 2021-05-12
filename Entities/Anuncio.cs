using System;

namespace Entities
{
    public class Anuncio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cliente { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public float InvestimentoDia { get; set; }

        //Construtor sem nenhuma implementação para criar objetos temporários do tipo anúncio
        public Anuncio() { }
        
        //Construtor com as propriedades da classe Anúncio que recebem os dados do usuário para a validação e inserção no banco de dados
        public Anuncio(string p_Nome, string p_Cliente, DateTime p_DataInicio, DateTime p_DataTermino, float p_InvestimentoDia)
        {
            Nome = p_Nome;
            Cliente = p_Cliente;
            DataInicio = p_DataInicio;
            DataTermino = p_DataTermino;
            InvestimentoDia = p_InvestimentoDia;
        }
    }
}
