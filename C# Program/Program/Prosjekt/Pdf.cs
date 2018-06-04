using System.Data;
using System.IO;
using System.Diagnostics;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace Prosjekt
{

    public class PdfForm
    {
        static Document document;
        static DataTable dataTable;

        static string headerText;
        static string filename = "Alarmlist.pdf";
        static string completeFilename;
        
        public static void CreatePdf(string headerString, DataTable table)
        {
            // Store variables, and create migradoc-document
            headerText = headerString;
            dataTable = table;
            document = CreateDocument();

            // Renders the migradoc-document as a pdf document
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always);
            renderer.Document = document;
            renderer.RenderDocument();

            // If Pdf directory don't exist, create it
            string directory = @"Pdf\";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            completeFilename = directory + filename;

            // Save the pdf-document, and open it
            renderer.PdfDocument.Save(completeFilename);
            Process.Start(completeFilename);
        }
        
        private static Document CreateDocument()
        {
            // Creates new Migradoc-document and defines some Info
            Document document = new Document(); 
            document.Info.Author = "IA-Gruppe 3";
            document.Info.Title = "How to create PDF's";

            //Creates header of the document
            CreateHeader(document);

            //Creates the table after the header
            CreateTable(document, dataTable);

            return document;
        }

        private static void CreateHeader(Document document)
        {
            // Adds new section to the migradoc-document
            Section section = document.AddSection();

            // Adds the top headers to the document some formatting
            Paragraph paragraph = section.AddParagraph("Alarmliste");
            paragraph.Format.Font.Size = 22;
            paragraph = section.AddParagraph(headerText);
            paragraph.Format.Font.Size = 14;
            paragraph.Format.SpaceAfter = 5;
        }

        private static void CreateTable(Document document, DataTable  dataTable)
        {
            // Adds new table to migradoc-document with some formatting
            Table table = new Table();
            table.Borders.Width = 0.75;
            table.Format.Font.Size = 14;
            table.Rows.Height = 20;

            // Adds two columns
            Column column = table.AddColumn(Unit.FromCentimeter(5));
            column.Format.Alignment = ParagraphAlignment.Left;
            table.AddColumn(Unit.FromCentimeter(7));

            // Add the heading-row with fixed headings and blue color
            Row row = table.AddRow();
            row.Shading.Color = Colors.LightSkyBlue;
            Cell cell = row.Cells[0];
            cell.AddParagraph("Alarmtype");
            cell = row.Cells[1];
            cell.AddParagraph("Tidspunkt");

            // For every row in datatable, add new row to migradoc-document
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                // Read datetime from datatable, and add a new row to the table
                string datetime = dataTable.Rows[i][1].ToString();
                row = table.AddRow();

                // Adds a light blue color for every other line in table for readability
                if (!IsEven(i)) row.Shading.Color = Colors.AliceBlue;

                // Add text from datatable to the two new cells. Remove seconds from datetimestring
                cell = row.Cells[0];
                cell.AddParagraph(dataTable.Rows[i][0].ToString());
                cell = row.Cells[1];
                cell.AddParagraph(datetime.Remove(16));
            }

            // Adds the newly created table in the bottom of the migradoc-document
            document.LastSection.Add(table);
        }

        private static bool IsEven(int value)
        {
            return value % 2 == 0;
        }

        public static string CompleteFilename
        {
            get { return completeFilename; }
        }
    }

}