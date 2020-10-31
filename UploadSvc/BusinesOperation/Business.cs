using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HoneyWell.Flight.Stream.Core;

namespace UploadSvc.BusinesOperation
{

    /// <summary>
    /// This class will do the business operation of uploading the media in database
    /// </summary>
    public class Business : IBusiness
    {

        /// <summary>
        /// This method will check if media is available in flight database or not
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public bool IfAvailable(Guid guid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Based on the check from IfAvailable Method It will upload/insert the media in databse
        /// </summary>
        /// <param name="flight"></param>
        /// <returns></returns>
        public bool UploadMediaStream(Flight flight)
        {
            try
            {
                foreach (var item in flight.FlightMedias)
                {
                    FileStream fs = File.Open(item.ToString(), FileMode.Open);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(item.bytes);
                    bw.Close();
                }
                return true;
            }
            catch (Exception)
            {
                //logger to log the exceptions
                return false;
            }
        }
    }
}
