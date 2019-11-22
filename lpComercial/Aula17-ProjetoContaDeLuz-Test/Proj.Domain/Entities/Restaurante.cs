using System.Collections.Generic;

namespace Proj.Domain.Entities
{
    public class Restaurante : Entity
    {
        public Restaurante() { }
        public Restaurante(int id, string nome, string endereco, int num, string cidade, string estado, List<ContaRestaurante> contasRestaurantes)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.num = num;
            this.cidade = cidade;
            this.estado = estado;
            this.contasRestaurantes = contasRestaurantes;
        }

        public string nome { get; set; }
        public string endereco { get; set; }
        public int num { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public ICollection<ContaRestaurante> contasRestaurantes { get; set; }
    }
}