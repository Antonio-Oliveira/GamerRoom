using Microsoft.AspNetCore.Mvc;

namespace GamerRoom.API.Controllers
{
    public class BlobController : Controller
    {/*
        private readonly IConfiguration _configuration;

        public BlobController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpPost]
        public async Task<Game> Save(IFormFile file, Game game)
        {
            var imageUri = await Upload(file, game.Name);
            game.ImageUri = imageUri;
            return game;
        }

        private async Task<string> Upload(IFormFile file, string name)
        {
            //Obtem as configurações blob do 'appsettings.json' e atribui as variaveis
            var accountName = _configuration.GetSection("StorageConfiguration")["AccountName"];
            var accountKey = _configuration.GetSection("StorageConfiguration")["AccountKey"];
            var containerName = _configuration.GetSection("StorageConfiguration")["ContainerName"];

            //Cria as credenciais de acesso do blob do Azure Storage e abre uma conexão com as APIs
            var storageCredentials = new StorageCredentials(accountName, accountKey);
            var storageAccount = new CloudStorageAccount(storageCredentials, true);

            var blobAzure = storageAccount.CreateCloudBlobClient();

            //Pega a referência do container que será feito o upload
            var container = blobAzure.GetContainerReference(containerName);

            //Atribui o nome do arquivo dentro do blob (podemos tratar com regex)
            string nameFormatted = "game_images" + "/" + "image_game-" + name.Replace(" ", "_").ToLower() + ".jpg";
            var blob = container.GetBlockBlobReference(nameFormatted);

            //Define o tipo do arquivo
            blob.Properties.ContentType = file.ContentType;

            //Realiza o upload do arquivo para o Blob
            await blob.UploadFromStreamAsync(file.OpenReadStream());

            //Obtem o URL do arquvivo no blob
            return blob.SnapshotQualifiedStorageUri.PrimaryUri.ToString();
        }*/
    }
}
