using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Year { get; set; }

        // Nova propriedade para armazenar imagens adicionais
        public List<string> AdditionalImages { get; set; }

        // Construtor
        public Car()
        {
            AdditionalImages = new List<string>();
        }
    }
}
