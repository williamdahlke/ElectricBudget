using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectricBudget.Models.Repository
{
    [Table("Material")]
    public class MaterialRepository
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("descricao")]
        [Required]
        public string Description { get; set; }

        [Column("cd_unidade")]
        [Required]
        public int Measure { get; set; }

        [Column("dt_criacao")]
        [Required]
        public DateTime CreationDate { get; set; }

        [Column("cd_ativo")]
        public bool IsActive { get; set; }

        public MaterialRepository()
        {
            CreationDate = DateTime.Now;
            Description = string.Empty;
        }
    }
}
