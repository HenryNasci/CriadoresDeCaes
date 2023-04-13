using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CriadoresDeCaes.Models
{
    /// <summary>
    /// Descrição dos animais
    /// </summary>
    public class Animais {

        public Animais() { 
            ListaFotografias = new HashSet<Fotografias>();
        }

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

        //****************************************

        /// <summary>
        /// lista das fotografias associadas a um animal 
        /// </summary>
        public ICollection<Fotografias> ListaFotografias { get; set; }

        /// <summary>
        /// FK para a Raça do cão
        /// </summary>
        [ForeignKey(nameof(Raca))]
        public int RacaFK { get; set; }
        public Racas Raca { get; set; }

        /// <summary>
        /// FK para o Criador do cão
        /// </summary>
        [ForeignKey(nameof(Criador))]
        public int AnimalFK { get; set; }
        public Criadores Criador { get; set; } 
        
    }
}
