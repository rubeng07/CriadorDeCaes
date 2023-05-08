﻿using System.ComponentModel.DataAnnotations;

namespace CriadorDeCaes.Models
{
    /// <summary>
    /// Dados dos criadores dos cães
    /// </summary>
    public class Criadores
    {
        public Criadores() { 
            ListaAnimais = new HashSet<Animais>();
            ListaRacas = new HashSet<Racas>();
        }

        /*
         * Anotadores
         * https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/data-annotations
         * https://www.entityframeworktutorial.net/code-first/dataannotation-in-code-first.aspx#google_vignette
         */

        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Criador
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        public string Nome { get; set; }

        /// <summary>
        /// Nome pelo qual o criador é conhecido no negócio de venda de cães
        /// </summary>
        [Display(Name = "Nome Comercial")]
        public string NomeComercial { get; set;  }

        /// <summary>
        /// Morada do criador
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        public string Morada { get; set; }

        /// <summary>
        /// Código Portal da morada do criador
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [Display(Name = "Código Postal")]
        public string CodPostal { get; set; }

        /// <summary>
        /// Telemóvel do criador
        /// </summary>
        [Display(Name = "Telemóvel")]
        public string Telemovel { get; set; }

        /// <summary>
        /// Email do criador
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [EmailAddress]
        public string Email { get; set; }

        // ************************************

        /// <summary>
        /// Lista dos animais propriedade do Criador
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }

        /// <summary>
        /// Lista das raças que o criador cria
        /// (concretização do relacionamento M-N)
        /// </summary>
        public ICollection<Racas> ListaRacas { get; set; }
    }
}
