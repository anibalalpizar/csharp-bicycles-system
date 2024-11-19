using ProyectoProgramadolll.Util;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class QuickResponse
{
    public byte[] GenerarQRCode(int numeroOrden)
    {
        try
        {

            QRCodeGenerator qrGenerator = new QRCodeGenerator();


            QRCodeData qrCodeData = qrGenerator.CreateQrCode(numeroOrden.ToString(), QRCodeGenerator.ECCLevel.Q);


            using (QRCode qrCode = new QRCode(qrCodeData))
            using (Bitmap qrBitmap = qrCode.GetGraphic(20))
            {

                using (MemoryStream ms = new MemoryStream())
                {
                    qrBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }
        catch (Exception ex)
        {
            Log.LogException(ex);
            throw new ApplicationException("Error generating QR code.", ex);
        }
    }
}

