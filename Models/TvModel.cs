using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class TvModel
    {
        [Display(Name = "Tv Series ID")]
        [Range (1, 999999, ErrorMessage = "You need to enter a valid employeeId")]
        public int TvSeriesID { get; set; }

        [Display(Name = "Title of series")]
        [Required(ErrorMessage = "you need to give us a name")]
        public string Title { get; set; }

        [Display(Name = "Channel origin")]
        [Required(ErrorMessage = "you need to give us a channel name")]
        public string ChannelOrigin { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "you need to give us a genre")]
    
        public string Genre { get; set; }

        [Display(Name = "Rating")]
        [Required(ErrorMessage = "you need to give us a rating out of 10")]
        [Range(1, 10, ErrorMessage = "You need to enter a rating")]
        public int Rating { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "you need to enter the price you paid")]
        //[Range(1, 100, ErrorMessage = "You need to enter a number")]
        public decimal Price { get; set; }


    }
}