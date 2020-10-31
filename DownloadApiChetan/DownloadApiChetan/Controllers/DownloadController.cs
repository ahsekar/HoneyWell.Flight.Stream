using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DownloadApiChetan.Modules;
using DownloadApiChetan.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Net.Http.Headers;

namespace DownloadApiChetan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        private readonly IFileRepository _fileRep;
        public DownloadController(IFileRepository fileRep)
        {
            this._fileRep = fileRep;
        }

        private async Task<FileUpload> UploadFile(string id, HttpRequest req)
        {
            var boundary = HeaderUtilities.RemoveQuotes(MediaTypeHeaderValue.Parse(req.ContentType).Boundary);
            var reader = new MultipartReader(boundary.Value, req.Body);
            MultipartSection section = await reader.ReadNextSectionAsync();
            string fileId = string.Empty;
            while (section != null)
            {
                ContentDispositionHeaderValue contentDisposition;
                var hasContentDispositionHeader = ContentDispositionHeaderValue.TryParse(section.ContentDisposition, out contentDisposition);
                if (string.IsNullOrEmpty(fileId) == false)
                {
                    break;
                }

                fileId = "Sample" + id;
                var filePath = "C/:Chetan";
                _fileRep.Initialize(filePath);
            }
            try
            {
                var encoding = GetEncoding(section);

                using (var streamReader = new BinaryReader(
                     section.Body,
                     encoding,
                     leaveOpen: true))
                {
                    while (true)
                    {
                        var bin = streamReader.ReadBytes(1024 * 1000 * 10);

                        if (bin.Length == 0)
                        {
                            break;
                        }

                        using (MemoryStream ms = new MemoryStream(bin))
                        {
                            _fileRep.UploadToBucket(ms);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            section = await reader.ReadNextSectionAsync();

            return new FileUpload() { FileId = fileId };
        }

        private static Encoding GetEncoding(MultipartSection section)
        {
            MediaTypeHeaderValue mediaType;
            var hasMediaTypeHeader = MediaTypeHeaderValue.TryParse(section.ContentType, out mediaType);
            // UTF-7 is insecure and should not be honored. UTF-8 will succeed in 
            // most cases.
            if (!hasMediaTypeHeader || mediaType.Encoding == null || Encoding.UTF7.Equals(mediaType.Encoding))
            {
                return Encoding.UTF8;
            }
            return mediaType.Encoding;
        }
       
    }
}