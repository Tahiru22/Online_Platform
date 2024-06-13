namespace Online_Platform.Services
{
    public interface ICloudinaryService
    {
        string UploadFile(byte[] fileBytes, string fileName, string cloudFileFolder);
    }
}
