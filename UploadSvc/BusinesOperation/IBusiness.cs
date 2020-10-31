using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoneyWell.Flight.Stream.Core.Entities;

namespace UploadSvc.BusinesOperation
{

    /// <summary>
    /// Interface of Upload Media
    /// </summary>
   public interface IBusiness
    {
        bool UploadMediaStream(Flight flight);

        bool IfAvailable(Guid guid);

    }
}
