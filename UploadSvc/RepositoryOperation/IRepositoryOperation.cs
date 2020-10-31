using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoneyWell.Flight.Stream.Core;

namespace UploadSvc.RepositoryOperation
{
    public interface IRepositoryOperation
    {

        Flight GetFlightDetails(Flight flightDetails);
        bool InsertStream(MediaFile mediaFile);
        bool UpdateStream(MediaFile mediaFile);
        bool GetMediaAvailability(Flight flightDetails);
    }
}
