using System.ComponentModel.DataAnnotations;

namespace ITTWEB_ASPNetCore.Models
{
    public class ESImage
    {
        public long ESImageId { get; set; }
        [MaxLength(128)]
        public string ImageMimeType { get; set; }
        public byte[] Thumbnail { get; set; }
        public byte[] ImageData { get; set; }
    }

    public static class ESImageMock
    {
        public static ESImage GetEsImage()
        {
            return new ESImage()
            {
                ESImageId = 1,
                ImageData = new byte[10],
                ImageMimeType = "Test Mock 1",
                Thumbnail = new byte[10]
            };




        }
    }
}