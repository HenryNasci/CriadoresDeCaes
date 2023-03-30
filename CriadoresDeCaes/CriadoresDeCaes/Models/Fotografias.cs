using Microsoft.VisualBasic;
using System;

namespace CriadoresDeCaes.Models
{
    /// <summary>
    /// Fotografias associadas aos animais
    /// </summary>
    public class Fotografias {
        public int Id { get; set; }
        /// <summary>
        /// Nome do documento com a fotogradia do aniamal
        /// </summary>
        public string NomeFicheiro { get; set; }
        /// <summary>
        /// Data da fotografia tirada
        /// </summary>
        public DateTime Data { get; set; }
        /// <summary>
        /// Local onde a fotografia foi tirada
        /// </summary>
        public string Local { get; set; }
    }
}
