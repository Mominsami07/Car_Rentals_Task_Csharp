using CarRent.Attribuites;
using System;
using System.ComponentModel.DataAnnotations;

namespace CarRent.Models
{
    public class Rentals : BaseEntity
    {
        [DateTimeIsValid(ErrorMessage = "This time isn't valid, should be in the present.")]
        public DateTime RentData { get; set; }

        [CompareDateTime("RentData", ErrorMessage ="ReturnDate shoulb be higher than Rent Date")]
        public DateTime ReturnDate { get; set; }

        [MaxLength(int.MaxValue)]
        public string Comment { get; set; }

        public bool IsReturned { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }


    }
}
