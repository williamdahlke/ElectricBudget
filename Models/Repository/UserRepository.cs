using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBudget.Models.Repository
{
    [Table("Usuario")]
    public class UserRepository
    {
        [Key]
        [Column("cd_id")]
        public int Id { get; set; }

        [Column("ds_nome")]
        [Required]
        public string Name { get; set; }

        [Column("ds_email")]
        public string? Email { get; set; }

        [Column("ds_senha")]
        [Required]
        public string Password { get; set; }

        [Column("b_ativo")]
        [Required]
        public bool IsActive { get; set; }

        [Column("b_admin")]
        [Required]
        public bool IsAdmin { get; set; }

        public UserRepository()
        {
            IsActive = true;
            IsAdmin = false;
        }
    }
}
