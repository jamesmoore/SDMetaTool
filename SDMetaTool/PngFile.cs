using System;

namespace SDMetaTool
{
    public partial class PngFile
    {
        public string Filename { get; set; }
        public DateTime LastUpdated { get; set; }
        public long Length { get; set; }
        public GenerationParams Parameters { get; set; }
    }
}
