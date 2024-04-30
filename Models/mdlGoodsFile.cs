namespace jaruernCore.Models
{
    public class mdlGoodsFile
    {
        public IFormFile GFile { get; set; }
        public string Barcode { get; set; }
        public string ImageType { get; set; }
        public Guid Storeid { get; set; }
    }
}
