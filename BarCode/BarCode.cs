using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BarCode
{
    public partial class BarCode : Form
    {
        public BarCode()
        {
            InitializeComponent();
        }

        private void generar_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document doc = new Document();

            try
            {
                //if(DateTime.Now > new DateTime(2015,12,31))
                //    throw new Exception("Ha terminado el periodo de evaluación, contáctese con el proveedor.");

                if (this.msup.Text.Equals(""))
                    throw new Exception("Debe ingresar el margen superior.");

                if (this.minf.Text.Equals(""))
                    throw new Exception("Debe ingresar el margen inferior.");

                if (this.mizq.Text.Equals(""))
                    throw new Exception("Debe ingresar el margen izquierdo.");

                if (this.mder.Text.Equals(""))
                    throw new Exception("Debe ingresar el margen derecho.");

                if (this.filas.Text.Equals(""))
                    throw new Exception("Debe ingresar la cantidad de filas.");

                if (this.columnas.Text.Equals(""))
                    throw new Exception("Debe ingresar la cantidad de columnas.");

                if (this.ndesde.Text.Equals(""))
                    throw new Exception("Debe ingresar el rango desde.");

                if (this.nhasta.Text.Equals(""))
                    throw new Exception("Debe ingresar el rango hasta.");

                doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4,
                                                                            Convert.ToInt32(Convert.ToDecimal(this.mizq.Text, new CultureInfo("en-US")) * 10m / 0.353m),
                                                                            Convert.ToInt32(Convert.ToDecimal(this.mder.Text, new CultureInfo("en-US")) * 10m / 0.353m),
                                                                            Convert.ToInt32(Convert.ToDecimal(this.msup.Text, new CultureInfo("en-US")) * 10m / 0.353m),
                                                                            Convert.ToInt32(Convert.ToDecimal(this.minf.Text, new CultureInfo("en-US")) * 10m / 0.353m));

                FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Etiquetas.pdf", FileMode.Create, FileAccess.Write, FileShare.None);

                PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                doc.Open();

                float[] anchos = new float[Convert.ToInt32(columnas.Text)];
                for (int i = 0; i < Convert.ToInt32(columnas.Text); i++)
                    anchos[i] = 1;


                PdfPTable table = new PdfPTable(anchos);
                table.WidthPercentage = 100f;

                PdfPCell cell;
                float cellHeigth = (doc.PageSize.Height - doc.BottomMargin - doc.TopMargin) / float.Parse(this.filas.Text);

                int desde = Convert.ToInt32(ndesde.Text);
                int hasta = Convert.ToInt32(nhasta.Text);

                PdfContentByte cb = writer.DirectContent;

                for (int i = desde; i <= hasta; i++)
                {
                    String myString = i.ToString();
                    Barcode128 code128 = new Barcode128();
                    code128.Code = myString;
                    code128.CodeType = Barcode128.CODE128;
                    //code128.BarHeight = 200;
                    iTextSharp.text.Image code128Image = code128.CreateImageWithBarcode(cb, null, null);
                    code128Image.ScalePercent(125, 125);
                    
                    // Creamos la imagen del código de barras.
                    myString = i.ToString();
                    Barcode39 code39 = new Barcode39();
                    code39.Code = myString;
                    //code39.BarHeight = 200;
                    iTextSharp.text.Image code39Image = code39.CreateImageWithBarcode(cb, null, null);
                    code39Image.ScalePercent(125, 125);
                    
                    if(tipoCodigo.Text == "BARCODE_39")
                        cell = new PdfPCell(code39Image);
                    else
                        cell = new PdfPCell(code128Image);

                    cell.Padding = 2f;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cell.BorderWidth = 1f;
                    cell.MinimumHeight = cellHeigth;

                    table.AddCell(cell);
                }

                doc.Add(table);

                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Etiquetas.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                doc.Close();                 
            }
        }
    }
}
