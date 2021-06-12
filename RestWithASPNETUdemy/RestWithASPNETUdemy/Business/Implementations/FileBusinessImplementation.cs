using Microsoft.AspNetCore.Http;
using RestWithASPNETUdemy.Data.VO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class FileBusinessImplementation : IFileBusiness
    {
        private readonly string _basePath;
        private readonly IHttpContextAccessor _context;

        public FileBusinessImplementation(IHttpContextAccessor context)
        {
            _context = context;
            _basePath = Directory.GetCurrentDirectory() + "\\UploadDir\\";
        }

        public byte[] GetFile(string filename)
        {
            var filePath = _basePath + filename;
            return File.ReadAllBytes(filePath);
        }

        public async Task<List<FileDetailsVO>> SaveFilesToDisk(List<IFormFile> files)
        {
            List<FileDetailsVO> list = new List<FileDetailsVO>();
            foreach (var file in files)
            {
                list.Add(await SaveFileToDisk(file));
            }
            return list;
        }

        public async Task<FileDetailsVO> SaveFileToDisk(IFormFile file)
        {
            FileDetailsVO fileDetail = new FileDetailsVO();

            var fileType = Path.GetExtension(file.FileName);
            var baseUrl = _context.HttpContext.Request.Host;

            if(fileType.ToLower() == ".pdf" || fileType.ToLower() == ".jpg" ||
                fileType.ToLower() == ".png" || fileType.ToLower() == ".jpeg")
            {
                var docName = Path.GetFileName(file.FileName);
                if(file != null && file.Length > 0)
                {
                    var destination = Path.Combine(_basePath, "", docName);
                    fileDetail.DocumentName = docName;
                    fileDetail.DocType = fileType;
                    fileDetail.DocUrl = Path.Combine(baseUrl + "api/v1/file/" + fileDetail.DocumentName);

                    using var stream = new FileStream(destination, FileMode.Create);
                    await file.CopyToAsync(stream);
                }
            }
            return fileDetail;
        }
    }
}
