using Education.Infrastructure.Services.Operations;

namespace Education.Infrastructure.Services.Storage
{
    public class Storage
    {
        protected delegate bool HasFile(string pathOrContainerName, string fileName);
        protected async Task<string> FileRenameAsync(string pathOrContainerName, string fileName,
            HasFile hasFileMethod, int num = 1)
        {
            return await Task.Run(async () =>
            {
                string extension = Path.GetExtension(fileName);
                string oldName = $"{Path.GetFileNameWithoutExtension(fileName)}-{num}";
                string newFileName = $"{NameOperations.CharacterRegulatory(oldName)}{extension}".ToString();

                //if (File.Exists($"{path}\\{newFileName}"))
                if (hasFileMethod(pathOrContainerName, newFileName))
                {
                    return await FileRenameAsync(pathOrContainerName, $"{newFileName.Split($"-{num}")[0]}{extension}", hasFileMethod, ++num);
                }

                return newFileName;
            });
        }
    }
}
