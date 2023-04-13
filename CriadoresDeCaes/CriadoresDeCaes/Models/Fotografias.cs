using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

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

        //******************************************************

        /// <summary>
        /// FK para indentificar o Animal a quem a Fotografia pertence
        /// </summary>
        [ForeignKey(nameof(Animal))] // <=> [ForeignKey("Animal")]
        public int AnimalFK { get; set; }
        public Animais Animal { get; set; }
        /*
         * o uso de [anotadores] permite alterar o comportamento dos 'objetos' do nosso programa:
         *  - atributos
         *  - funções (metodos)
         *  - classes
         */


    }
}
