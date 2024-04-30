

using BarcodeStandard;
using System.Drawing.Imaging;
using System.Drawing;
using SkiaSharp;
using QRCoder;

namespace jaruernCore.localLib
{
    public class serviceBarcode
    {
        public void CreateBarcode(string barcodeTxt,string filrPath,string fileName,int width,int heigth)
        {
            try
            {
                Barcode barcode = new Barcode();
                SKImage image = barcode.Encode(BarcodeStandard.Type.Code39, barcodeTxt,
                                                    SKColors.Black, SKColors.White, width, heigth);

                SKData encodedData = image.Encode(SKEncodedImageFormat.Png, 100);
                string imagePath = Path.Combine(filrPath, fileName);
                FileStream bitmapImageStream = File.Open(imagePath,
                              FileMode.Create,
                              FileAccess.Write,
                              FileShare.None);

                encodedData.SaveTo(bitmapImageStream);
                bitmapImageStream.Flush(true);
                bitmapImageStream.Dispose();

            }
            catch(Exception ex)
            {
                throw;
            }

        }

        public void CreateQRcode(string DataTxt, string filrPath, string fileName)
        {
            try
            {
                QRCodeGenerator QrGenerator = new QRCodeGenerator();
                QRCodeData QrCodeInfo = QrGenerator.CreateQrCode(DataTxt, QRCodeGenerator.ECCLevel.Q);
                QRCode QrCode = new QRCode(QrCodeInfo);
                Bitmap QrBitmap = QrCode.GetGraphic(25);
                QrBitmap.Save(filrPath + "\\" + fileName);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
