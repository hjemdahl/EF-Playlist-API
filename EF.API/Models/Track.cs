using System;
namespace EF.API.Models
{
    public class Track
    {
        //Properties
        public int TrackID { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Category { get; set; }
    }
}