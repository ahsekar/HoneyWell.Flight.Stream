using DownloadApiChetan.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DownloadApiChetan.Repository
{
    public interface IFileRepository
    {
        void Initialize(string filePath);
        void UploadToBucket(Stream fileData);
    }
}
