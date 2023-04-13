using System.Collections.Generic;

namespace CriadoresDeCaes.Models
{
    /// <summary>
    /// desrição dos criadores dos animais
    /// </summary>
    public class Criadores {

        public Criadores() { 
            ListaAnimais = new HashSet<Animais>();
            ListaRacas = new HashSet<Racas>();
        }
        public int Id { get; set; }
        /// <summary>
        /// Nome do Criador
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Nome Comercial do criador
        /// </summary>
        public string NomeCriador { get; set; }
        /// <summary>
        /// Morada do criador
        /// </summary>
        public string Morada { get; set; }
        /// <summary>
        /// Codigo postal do criador
        /// </summary>
        public string CodPostal { get; set; }
        /// <summary>
        /// Número de telemóvel do criador
        /// </summary>
        public string Telemovel { get; set; }
        /// <summary>
        /// Endereço de email do criador
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// FK para a lista de cães, propriedade do criador
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }
        /// <summary>
        /// Lista das Raças de um determinado Criador
        /// </summary>
        public ICollection<Racas> ListaRacas { get; set; }
    }
}
