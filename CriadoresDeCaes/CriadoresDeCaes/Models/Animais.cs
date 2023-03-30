using System;

namespace CriadoresDeCaes.Models
{
    /// <summary>
    /// Descrição dos animais
    /// </summary>
    public class Animais {
        public int Id { get; set; }
        /// <summary>
        /// Nome do animal
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Data de nascimento do animal
        /// </summary>
        public DateTime DataNascimento { get; set; }
        /// <summary>
        /// Data de compra do animal
        /// </summary>
        public DateTime DataCompra { get; set; }
        /// <summary>
        /// Sexo do animal
        /// F - Femea
        /// M - Macho
        /// </summary>
        public char Sexo { get; set; }
        /// <summary>
        /// Numero de registo no LOP
        /// </summary>
        public string NumLOP { get; set; }
    }
}
