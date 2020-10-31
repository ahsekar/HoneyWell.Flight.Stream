using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using DownloadApiChetan.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DownloadApiChetan.Repository
{
    public class FileRepository : IFileRepository
    {
        private const string accessKey = "XXXXXXX";
        private const string secretKey = "XXXXXXX";
        private Amazon.RegionEndpoint _s3Region;
        private string _s3BucketName;
        private IAmazonS3 _s3;
        private List<UploadPartResponse> _uploadResponses;
        private InitiateMultipartUploadResponse _initialResponse;
        /// <summary>
        /// Bind the S3Region and S3Bucket 
        /// </summary>
        /// <param name="s3Region"></param>
        /// <param name="s3BucketName"></param>
        public FileRepository(Amazon.RegionEndpoint s3Region, string s3BucketName)
        {
            _s3Region = s3Region;
            _s3BucketName = s3BucketName;
        }
        /// <summary>
        /// Initializing the request
        /// </summary>
        /// <param name="filePath"></param>
        public void Initialize(string filePath)
        {
            _s3 = new AmazonS3Client(accessKey, secretKey, RegionEndpoint.APSouth1);
            _uploadResponses = new List<UploadPartResponse>();
            var initiateRequest = new InitiateMultipartUploadRequest
            {
                BucketName = _s3BucketName,
                Key = filePath
            };

            _initialResponse = _s3.InitiateMultipartUploadAsync(initiateRequest).Result;

        }
        public void UploadToBucket(Stream fileData)
        {
            var uploadRequest = new UploadPartRequest
            {
                BucketName = _s3BucketName,
                Key = _initialResponse.Key,
                UploadId = _initialResponse.UploadId,
                InputStream = fileData,
                PartNumber = 1,
                PartSize = fileData.Length,
            };

            var uploadResponse = _s3.UploadPartAsync(uploadRequest).Result;
            _uploadResponses.Add(uploadResponse);
        }
    }
}
