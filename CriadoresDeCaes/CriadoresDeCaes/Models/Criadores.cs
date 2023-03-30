namespace CriadoresDeCaes.Models
{
    /// <summary>
    /// desrição dos criadores dos animais
    /// </summary>
    public class Criadores {
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
    }
}
