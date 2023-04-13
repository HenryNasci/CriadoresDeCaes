using System.Collections.Generic;

namespace CriadoresDeCaes.Models
{
    /// <summary>
    /// Descrição das Raças dos animais
    /// </summary>
    public class Racas {

        public Racas() { 
            ListaAnimais = new HashSet<Animais>();
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome da raça de um animal
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Lista dos animais que são de uma raça
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }
    }
}
