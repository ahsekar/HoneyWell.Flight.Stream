using DownloadApiChetan.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DownloadApiChetan.Repository
{
    public interface IFileRepository
    {
        S3DownloadResponse Download(string filePath);
    }
}
