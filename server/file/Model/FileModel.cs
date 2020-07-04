using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace file.Model
{
    public class FileModel
    {
        public string FileName { get; set; }
        public IFormFile FormFile { get; set; }
        //public List<IFormFile> FormFiles { get; set; }
    }
}
