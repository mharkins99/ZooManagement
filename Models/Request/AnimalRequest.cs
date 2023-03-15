using System.ComponentModel.DataAnnotations;

namespace ZooManagement.Models.Request
{
    public class AnimalRequest
    {
        [Required]
        [StringLength(30)]
        public string Species { get; set;}

        [Required]
        [StringLength(30)]
        public string Classification { get; set;}

        [Required]
        [StringLength(30)]
        public string Name { get; set;}

        [Required]
        [StringLength(30)]
        public string Sex { get; set;}

        [Required]
        public DateTime DOB { get; set;}

        [Required]
        public DateTime AcquisitionDate { get; set;}
    }
}