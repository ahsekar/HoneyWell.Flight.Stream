using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyWell.Flight.Stream.Core
{
    public class MediaFile
    {
        public Guid MediaFileId { get; set; }
        public string Type { get; set; }
        public long Size { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public Byte[] bytes { get; set; }
    }
}
    public class MediaFile
    {
        public Guid MediaFileId { get; set; }
        public string Type { get; set; }
        public long Size { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public Flight Flight { get; set; }

    }
}




