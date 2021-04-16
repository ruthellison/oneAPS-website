using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Dta.OneAps.Api.Services.Entities;

namespace Dta.OneAps.Api.Services {
    public interface IFileService {
        Task SaveFile(string path, Stream stream);
        Task<string> GetFile(string path);
    }
}
