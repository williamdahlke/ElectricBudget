using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectricBudget.Models.Repository
{
    [Table("Material")]
    public class MaterialRepository
    {
        [Key]
        [Column("cd_id")]
        public int Id { get; set; }

        [Column("ds_descricao")]
        [Required]
        public string Description { get; set; }

        [Column("cd_unidade")]
        [Required]
        public int Measure { get; set; }

        [Column("dt_criacao")]
        [Required]
        public DateTime CreationDate { get; set; }

        [Column("b_ativo")]
        public bool IsActive { get; set; }

        public MaterialRepository()
        {
            CreationDate = DateTime.Now;
            Description = string.Empty;
        }
    }
}
