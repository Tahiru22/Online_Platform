namespace Online_Platform.Services
{
    public interface IPdfService
    {
        byte[] ConvertToPdf(string url);
    }
}
