using System.Collections.Generic;

namespace TourManagement.API.Dtos
{
    public class TourWithEstimatedProfitsAndShows : TourWithEstimateProfits
    {
        public ICollection<Show> Shows { get; set; }
              = new List<Show>();
    }
}
