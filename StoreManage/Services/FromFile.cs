using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

public class FormFile : IFormFile
{
    private readonly Stream _stream;

    public FormFile(Stream stream, long position, long length, string name, string fileName)
    {
        _stream = stream;
        Length = length;
        Name = name;
        FileName = fileName;
        _stream.Position = position; // Đặt vị trí đọc trong stream
    }

    public Stream OpenReadStream() => _stream;

    public void CopyTo(Stream target) => _stream.CopyTo(target);

    public Task CopyToAsync(Stream target, CancellationToken cancellationToken)
    {
        // Bỏ qua CancellationToken
        return Task.Run(() => _stream.CopyTo(target));
    }

    public string ContentType { get; set; }
    public string ContentDisposition { get; set; }
    public IHeaderDictionary Headers { get; set; }
    public long Length { get; }
    public string Name { get; }
    public string FileName { get; }
}
