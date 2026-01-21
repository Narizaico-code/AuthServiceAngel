namespace AuthServiceAngel.Application.Interfaces;

public interface ICloudinaryService
{
    Task<string> UploadImageAsync(byte[] imageData, string fileName);
    Task<bool> DeleteImageAsync(string publicId);
    string GetDefaultAvatarUrl();
    string GetFullImageUrl(string imagePath);
}