namespace MVCRestaurant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu List")]
    public partial class Menu_List
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemId { get; set; }

        [Display(Name = "Price")]
        public int ItemPrice { get; set; }

        [Required]
        [Display(Name = "Short Description")]
        [StringLength(100)]
        public string ShortDescription { get; set; }

        [Required]
        [Display(Name = "In brief")]
        [StringLength(450)]
        public string LongDescription { get; set; }

        [Required]
        [Display(Name = "Tiny look")]
        [StringLength(50)]
        public string IconImage { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(20)]
        public string ItemName { get; set; }
    }
}
