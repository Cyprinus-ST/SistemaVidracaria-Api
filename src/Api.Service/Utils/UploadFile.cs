using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Api.Service.Utils
{
    public class UploadFile
    {
        private readonly IConfiguration Configuration;

        public UploadFile(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        ///  Método para realizar o upload de arquivos
        /// </summary>
        /// <param name="destinationFolder"> Pasta aonde o arquivo será salvar considero o caminho padrão src/Files/DestinantionFolder</param>
        /// <param name="file"></param>
        /// <param name="idUser"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public async Task<string> Upload(string destinationFolder, IFormFile file, Guid idUser, string fileName)
        {
            try
            {

                string serverPath = Configuration["PathFile"];

                serverPath = serverPath + "/" + idUser + "/" + destinationFolder;

                //Se o diretório não existir ele vai criar
                if (!Directory.Exists(serverPath))
                {
                    Directory.CreateDirectory(serverPath);
                }

                using (FileStream filestream = File.Create(serverPath + @"/" + fileName))
                {
                    await file.CopyToAsync(filestream);
                    filestream.Flush();
                    string path = idUser + "/" + destinationFolder + "/" + fileName;
                    return path;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

