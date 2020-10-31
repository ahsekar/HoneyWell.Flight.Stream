using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadSvc.Models
{
    public class MediaFile
    {
        public int MediaFileId { get; set; }
        public string Type { get; set; }
        public long Size { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
    }
}
