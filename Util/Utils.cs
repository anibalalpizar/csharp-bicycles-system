using iTextSharp.text.pdf.qrcode;
using Newtonsoft.Json;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

public static class Utils
{

    public static void CultureInfo()
    {
        // Colocar Cultura Estandar para Costa Rica
        // esto me permite no tener problemas con (.) de los decimales
        CultureInfo Micultura = new CultureInfo("es-CR", false);
        Micultura.NumberFormat.CurrencySymbol = "¢";
        Micultura.NumberFormat.CurrencyDecimalDigits = 2;
        Micultura.NumberFormat.CurrencyDecimalSeparator = ".";
        Micultura.NumberFormat.CurrencyGroupSeparator = ",";
        int[] grupo = new int[] { 3, 3, 3 };
        Micultura.NumberFormat.CurrencyGroupSizes = grupo;
        Micultura.NumberFormat.NumberDecimalDigits = 2;
        Micultura.NumberFormat.NumberGroupSeparator = ",";
        Micultura.NumberFormat.NumberDecimalSeparator = ".";
        Micultura.NumberFormat.NumberGroupSizes = grupo;
        //Micultura.DateTimeFormat.
        Thread.CurrentThread.CurrentCulture = Micultura;


    }
    public static async Task<List<Provincia>> ObtenerProvinciasAsync()
    {
        string url = "https://raw.githubusercontent.com/lateraluz/Datos/master/provincias.json";
        try
        {
            HttpResponseMessage response = await new HttpClient().GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var provincias = JsonConvert.DeserializeObject<List<Provincia>>(responseBody);
            return provincias ?? new List<Provincia>();
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error al obtener provincias: {ex.Message}");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al obtener provincias: {ex.Message}");
            return null;
        }
    }

    public static async Task<List<Canton>> ObtenerCantonesAsync()
    {
        string url = "https://raw.githubusercontent.com/lateraluz/Datos/master/cantones.json";
        try
        {
            HttpResponseMessage response = await new HttpClient().GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var cantones = JsonConvert.DeserializeObject<List<Canton>>(responseBody);
            return cantones ?? new List<Canton>();
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error al obtener cantones: {ex.Message}");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al obtener cantones: {ex.Message}");
            return null;
        }
    }

    public static async Task<List<Distrito>> ObtenerDistritosAsync()
    {
        string url = "https://raw.githubusercontent.com/lateraluz/Datos/master/distritos.json";
        try
        {
            HttpResponseMessage response = await new HttpClient().GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var distritos = JsonConvert.DeserializeObject<List<Distrito>>(responseBody);
            return distritos ?? new List<Distrito>();
        }
        catch (HttpRequestException ex)
        {
            return null;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public static async Task<String> ObtenerNombreClienteHaciendaAsync(string identificacion)
    {
        string url = $"https://api.hacienda.go.cr/fe/ae?identificacion={identificacion}";
        try
        {
            HttpResponseMessage response = await new HttpClient().GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var clienteInfo = JsonConvert.DeserializeObject<Cliente>(responseBody);

            return clienteInfo?.Nombre ?? "Sin resultados";

        }
        catch (HttpRequestException ex)
        {
            return null;
        }
        catch (Exception ex)
        {

            return null;
        }
    }

    public static async Task<decimal> ObtenerTipoCambioAsync()
    {
        string url = "https://tipodecambio.paginasweb.cr/api";
        try
        {
            HttpResponseMessage response = await new HttpClient().GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var tipoCambio = JsonConvert.DeserializeObject<ProductoServicio>(responseBody);
            return tipoCambio?.Venta ?? 0m;
        }
        catch (HttpRequestException ex)
        {
            return 0m;
        }
        catch (Exception ex)
        {
            return 0m;
        }
    }


    public static byte[] ImageToByteArray(Image image)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
    }

    public static Image ByteArrayToImage(byte[] byteArray)
    {
        try
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al convertir byte array a imagen: {ex.Message}");
            return null;
        }
    }

    public static void GenerarYProcesarOrdenPdf(OrdenTrabajoDTO orden)
    {
        try
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "OrdenTrabajo.pdf");

            using (System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Create))
            {
                using (iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 30, 30))
                {
                    iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                    doc.Open();


                    iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph(
                        "Orden de Trabajo #" + orden.IdOrdenTrabajo,
                        iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 20, iTextSharp.text.BaseColor.BLUE)
                    );
                    title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    doc.Add(title);
                    doc.Add(new iTextSharp.text.Paragraph(" "));

                    iTextSharp.text.pdf.PdfPTable infoTable = new iTextSharp.text.pdf.PdfPTable(2);
                    infoTable.WidthPercentage = 100;
                    infoTable.SetWidths(new float[] { 1, 3 });

                    AddCellToTable(infoTable, "Fecha de Inicio:", true);
                    AddCellToTable(infoTable, orden.FechaInicio.ToString("dd/MM/yyyy"), false);
                    AddCellToTable(infoTable, "Fecha de Finalización:", true);
                    AddCellToTable(infoTable, orden.FechaFinalizacion.ToString("dd/MM/yyyy"), false);
                    AddCellToTable(infoTable, "Cliente:", true);
                    AddCellToTable(infoTable, orden.NombreCliente, false);
                    AddCellToTable(infoTable, "Vendedor:", true);
                    AddCellToTable(infoTable, orden.NombreVendedor, false);

                    doc.Add(infoTable);
                    doc.Add(new iTextSharp.text.Paragraph(" "));


                    doc.Add(new iTextSharp.text.Paragraph(
                        "Detalles de Servicio",
                        iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 16, iTextSharp.text.BaseColor.BLACK)
                    ));
                    doc.Add(new iTextSharp.text.Paragraph(" "));

                    iTextSharp.text.pdf.PdfPTable detailTable = new iTextSharp.text.pdf.PdfPTable(3);
                    detailTable.WidthPercentage = 100;
                    detailTable.SetWidths(new float[] { 2, 2, 3 });

                    AddCellToTable(detailTable, "Bicicleta", true, true);
                    AddCellToTable(detailTable, "Servicio", true, true);
                    AddCellToTable(detailTable, "Descripción", true, true);

                    foreach (var detalle in orden.ListaDetalles)
                    {
                        AddCellToTable(detailTable, detalle.NumeroSerie, false, true);
                        AddCellToTable(detailTable, orden.NombreProducto, false, true);
                        AddCellToTable(detailTable, detalle.Descripcion, false, true);
                    }

                    doc.Add(detailTable);
                    doc.Add(new iTextSharp.text.Paragraph(" "));


                    if (orden.ListaFotografias != null && orden.ListaFotografias.Any())
                    {
                        doc.Add(new iTextSharp.text.Paragraph(
                            "Fotografías",
                            iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 16, iTextSharp.text.BaseColor.BLACK)
                        ));
                        doc.Add(new iTextSharp.text.Paragraph(" "));


                        iTextSharp.text.pdf.PdfPTable fotoTable = new iTextSharp.text.pdf.PdfPTable(3);
                        fotoTable.WidthPercentage = 100;
                        fotoTable.SpacingBefore = 10;

                        int fotoCount = 0;
                        foreach (var foto in orden.ListaFotografias.GroupBy(f => f.IdFotografiaOrden).Select(g => g.First()))
                            using (MemoryStream ms = new MemoryStream())
                            {

                                using (System.Drawing.Image image = System.Drawing.Image.FromStream(new MemoryStream(foto.Fotografia)))
                                {
                                    var qualityParam = new System.Drawing.Imaging.EncoderParameters(1);
                                    qualityParam.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 50L);


                                    var jpegCodec = System.Drawing.Imaging.ImageCodecInfo.GetImageDecoders()
                                        .FirstOrDefault(codec => codec.FormatID == System.Drawing.Imaging.ImageFormat.Jpeg.Guid);

                                    if (jpegCodec != null)
                                    {
                                        image.Save(ms, jpegCodec, qualityParam);
                                    }

                                    byte[] compressedImage = ms.ToArray();

                                    iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(compressedImage);
                                    float cellWidth = fotoTable.TotalWidth / 3;
                                    float cellHeight = 100f;
                                    imagen.ScaleToFit(cellWidth, cellHeight);



                                    fotoTable.AddCell(imagen);
                                    fotoCount++;

                                    if (fotoCount % 3 == 0)
                                    {
                                        fotoTable.CompleteRow();
                                    }
                                }

                            }


                        int remainingCells = 3 - (fotoCount % 3);
                        if (remainingCells < 3)
                        {
                            for (int i = 0; i < remainingCells; i++)
                            {
                                fotoTable.AddCell("");
                            }
                            fotoTable.CompleteRow();
                        }


                        doc.Add(fotoTable);
                    }
                    else
                    {
                        doc.Add(new iTextSharp.text.Paragraph("La orden no incluye fotografías adjuntadas."));
                    }

                    if (orden.Firma != null)
                    {

                        doc.Add(new iTextSharp.text.Paragraph(
                            "Firma",
                            iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 16, iTextSharp.text.BaseColor.BLACK)
                        ));
                        doc.Add(new iTextSharp.text.Paragraph(" "));

                        iTextSharp.text.Image firma = iTextSharp.text.Image.GetInstance(orden.Firma);


                        firma.ScaleToFit(100, 50);

                        firma.Alignment = iTextSharp.text.Element.ALIGN_LEFT;

                        firma.Border = iTextSharp.text.Rectangle.BOX;
                        firma.BorderWidth = 1;
                        firma.BorderColor = new iTextSharp.text.BaseColor(200, 200, 200);

                        doc.Add(firma);
                        doc.Add(new iTextSharp.text.Paragraph(" "));
                    }

                    doc.Close();
                }
            }

            MessageBox.Show("Archivo guardado en el escritorio y se enviará por correo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            EnviarPdfPorCorreo(path, orden);

        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    public static void AddCellToTable(iTextSharp.text.pdf.PdfPTable table, string text, bool isHeader, bool alignCenter = false)
    {
        var font = isHeader
            ? iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 12, iTextSharp.text.BaseColor.WHITE)
            : iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 12, iTextSharp.text.BaseColor.BLACK);

        var backgroundColor = isHeader ? iTextSharp.text.BaseColor.DARK_GRAY : iTextSharp.text.BaseColor.WHITE;

        var cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(text, font))
        {
            BackgroundColor = backgroundColor,
            Padding = 5,
            HorizontalAlignment = alignCenter ? iTextSharp.text.Element.ALIGN_CENTER : iTextSharp.text.Element.ALIGN_LEFT
        };

        table.AddCell(cell);
    }


    public static void EnviarPdfPorCorreo(string filePath, OrdenTrabajoDTO orden)
    {
        try
        {
            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("No se encontró el archivo para enviar por correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress("nikiarias40@gmail.com");
            mail.To.Add(orden.CorreoCliente);
            mail.Subject = $"Orden de trabajo {orden.IdOrdenTrabajo}";
            mail.Body = $"Se adjunta la orden de trabajo {orden.NombreCliente}.";

            System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(filePath);
            mail.Attachments.Add(attachment);

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new System.Net.NetworkCredential("nikiarias40@gmail.com", "nmxwrlpkdsrhrjcw"),
                EnableSsl = true
            };


            smtp.Send(mail);

            MessageBox.Show("Correo enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al enviar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void EnviarPdfPorCorreo(string filePath, FacturaDTO factura, string xml)
    {
        try
        {
            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("No se encontró el archivo para enviar por correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress("nikiarias40@gmail.com");
            mail.To.Add(factura.CorreoCliente);
            mail.Subject = $"Factura {factura.IdFactura}";
            mail.Body = $"Se adjunta la factura {factura.NombreCliente}.";

            System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(filePath);
            mail.Attachments.Add(attachment);
            mail.Attachments.Add(new Attachment(xml));

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new System.Net.NetworkCredential("nikiarias40@gmail.com", "nmxwrlpkdsrhrjcw"),
                EnableSsl = true
            };


            smtp.Send(mail);

            MessageBox.Show("Correo enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al enviar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    public static void GenerarYProcesarFacturadenPdf(FacturaDTO factura, string xmlFilePath)
    {
        try
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Factura.pdf");

            using (System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Create))
            {
                using (iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 30, 30))
                {
                    iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                  
                    iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph(
                        "Factura #" + factura.IdFactura,
                        iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 20, iTextSharp.text.BaseColor.BLUE)
                    );
                    title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    doc.Add(title);
                    doc.Add(new iTextSharp.text.Paragraph(" "));

                    iTextSharp.text.pdf.PdfPTable infoTable = new iTextSharp.text.pdf.PdfPTable(2);
                    infoTable.WidthPercentage = 100;
                    infoTable.SetWidths(new float[] { 1, 3 });
                 
                    AddCellToTable(infoTable, "Fecha de Factura:", true);
                    AddCellToTable(infoTable, factura.FechaFactura.ToString("dd/MM/yyyy"), false);
                    AddCellToTable(infoTable, "Cliente:", true);
                    AddCellToTable(infoTable, factura.NombreCliente, false);
                    AddCellToTable(infoTable, "Vendedor:", true);
                    AddCellToTable(infoTable, factura.NombreVendedor, false);
                    AddCellToTable(infoTable, "Monto Total Colones: ", true);
                    AddCellToTable(infoTable, $"₡{factura.MontoColones.ToString("N2")}",false, false);
                    AddCellToTable(infoTable, "Monto Total Dólares:", true);
                    AddCellToTable(infoTable, factura.Venta.ToString("C"), false);
                    AddCellToTable(infoTable, "Información de Pago:", true);
                    AddCellToTable(infoTable, factura.TipoTarjeta, false);
                    AddCellToTable(infoTable, "Número de Tarjeta:", true);
                    AddCellToTable(infoTable, factura.NumeroTarjeta, false);
                    AddCellToTable(infoTable, "Fecha de Pago:", true);
                    AddCellToTable(infoTable, factura.FechaPago.ToString("dd/MM/yyyy"), false);

                    doc.Add(infoTable);
                    doc.Add(new iTextSharp.text.Paragraph(" "));

                    doc.Add(new iTextSharp.text.Paragraph(
                        "Detalles de Factura",
                        iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 16, iTextSharp.text.BaseColor.BLACK)
                    ));
                    doc.Add(new iTextSharp.text.Paragraph(" "));

                    iTextSharp.text.pdf.PdfPTable detailTable = new iTextSharp.text.pdf.PdfPTable(5);
                    detailTable.WidthPercentage = 100;
                    detailTable.SetWidths(new float[] { 2, 2, 3, 3, 2 });

             
                    AddCellToTable(detailTable, "Orden de Trabajo", true, true);
                    AddCellToTable(detailTable, "Bicicleta", true, true);
                    AddCellToTable(detailTable, "Descripción", true, true);
                    AddCellToTable(detailTable, "Monto Colones", true, true);
                    AddCellToTable(detailTable, "Monto Dólares", true, true);

                  
                  
                    foreach (var detalle in factura.ListaDetallesFactura)
                    {
                        AddCellToTable(detailTable, detalle.IdOrdenTrabajo.ToString(), false, true);
                        AddCellToTable(detailTable, detalle.NumeroSerie, false, true);
                        AddCellToTable(detailTable, detalle.DescripcionDetalle, false, true);
                        AddCellToTable(detailTable, detalle.PrecioProducto.ToString("N2"), false, true);
                        AddCellToTable(detailTable, detalle.PrecioDolarProducto.ToString("C"), false, true);
                    }

                    doc.Add(detailTable);
                    doc.Add(new iTextSharp.text.Paragraph(" "));

                
                    iTextSharp.text.Image qrImage = GenerateQRCode(factura.IdFactura.ToString());
                    qrImage.ScaleAbsolute(50, 50); 

                    
                    var pdfContent = writer.DirectContent;
                    var pageSize = doc.PageSize;

                    
                    float qrX = pageSize.Right - 120; 
                    float qrY = pageSize.Top - 70;  

                    qrImage.SetAbsolutePosition(qrX, qrY);
                    pdfContent.AddImage(qrImage);

                    doc.Close();
                }
            }

            MessageBox.Show("Archivo guardado en el escritorio y se enviará por correo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

         
            EnviarPdfPorCorreo(path, factura, xmlFilePath);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

 
    private static iTextSharp.text.Image GenerateQRCode(string data)
    {
        BarcodeWriter writer = new BarcodeWriter
        {
            Format = BarcodeFormat.QR_CODE,
            Options = new EncodingOptions
            {
                Height = 150,
                Width = 150,
                Margin = 0
            }
        };

        using (var bitmap = writer.Write(data))
        {
            using (var stream = new System.IO.MemoryStream())
            {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return iTextSharp.text.Image.GetInstance(stream.ToArray());
            }
        }
    }



}

