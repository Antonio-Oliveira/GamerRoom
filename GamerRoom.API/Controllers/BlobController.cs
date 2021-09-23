using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerRoom.API.Controllers
{
    public class BlobController
    {
        private readonly IConfiguration _configuration;

        public BlobController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }

    [HttpPost]
    public async Task<Lanche> Save(IFormFile file, Lanche lanche)
    {
        var imagemUrl = await Upload(file, lanche.Nome, lanche.Categoria);
        lanche.ImagemURL = imagemUrl;
        return lanche;
    }

    private async Task<string> Upload(IFormFile file, string nome, Categoria categoria)
    {
        //Obtem as configurações blob do 'appsettings.json' e atribui as variaveis
        var accountName = _configuration.GetSection("StorageConfiguration")["AccountName"];
        //var accountName = _configuration["StorageConfiguration: AccountName"];
        var accountKey = _configuration.GetSection("StorageConfiguration")["AccountKey"];
        //var accountKey = _configuration["StorageConfiguration: AccountKey"];
        var containerName = _configuration.GetSection("StorageConfiguration")["ContainerName"];
        //var containerName = _configuration["StorageConfiguration: ContainerName"];

        //Cria as credenciais de acesso do blob do Azure Storage e abre uma conexão com as APIs
        var storageCredentials = new StorageCredentials(accountName, accountKey);
        var storageAccount = new CloudStorageAccount(storageCredentials, true);
        var blobAzure = storageAccount.CreateCloudBlobClient();
        //Pega a referência do container que será feito o upload
        var container = blobAzure.GetContainerReference(containerName);

        //Atribui o nome do arquivo dentro do blob (podemos tratar com regex)
        string nameProductF = "group-category_" + categoria.Nome.Replace(" ", "_").ToLower() + "/" + "image_product-"
            + nome.Replace(" ", "_").ToLower() + ".jpg";
        var blob = container.GetBlockBlobReference(nameProductF);

        //Define o tipo do arquivo
        blob.Properties.ContentType = file.ContentType;
        //Realiza o upload do arquivo para o Blob
        await blob.UploadFromStreamAsync(file.OpenReadStream());

        //Obtem o URL do arquvivo no blob
        return blob.SnapshotQualifiedStorageUri.PrimaryUri.ToString();

    }
}
