using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Drawing;
using System.Data;
using System.Threading;
using System.Data.SqlClient;

namespace DiscountCodeGenerate
{
    class Program
    {
              private int m_currentPageIndex;
        private IList<Stream> m_streams;
        DataSet ChargeDS;
        DataTable tempDT;
        static void Main(string[] args)
        {
            Program ps = new Program();
            ps.DiscountCodeprint(ps.FillDataset());
        }


    public DataSet FillDataset(){
   
           DiscountDS CPDS = new DiscountDS();
           Random rand = new Random();

        for(int i=1000;i<1003;i++){


            CPDS.DiscountDT.Rows.Add(i.ToString(), CreatePassword1(4,i), CreatePassword2(4,i), DateTime.Now, DateTime.Now.AddYears(1), "عادی", 10, 0, 0, false);        
        }
        return CPDS;
    
    }
    public string CreatePassword1(int length,int i)
    {
        const string valid = "01234567899876543210987654321001234567890123456789987654321098765432100123456789";
        StringBuilder res = new StringBuilder();
        Random rnd = new Random(DateTime.Now.Ticks.GetHashCode()*(3*i));
     //  Thread.Sleep(1);
        while (0 < length--)
        {
            res.Append(valid[rnd.Next(valid.Length)]);
        }
        return res.ToString();
    }
    public string CreatePassword2(int length, int i)
    {
        const string valid = "98765432100123456789012345678998765432109876543210012345678901234567899876543210";
        StringBuilder res = new StringBuilder();
        Random rnd = new Random(DateTime.Now.Millisecond*(2*i));
     //  Thread.Sleep(1);
        while (0 < length--)
        {
            res.Append(valid[rnd.Next(valid.Length)]);
        }
        return res.ToString();
    }



    public string Register(string ID, string FirstPW, string SecondPW, DateTime? RegisterDate, DateTime? ExpireDate, string CardType, int CreditCount, float CreditFund, float Score, bool Status, string Operation_Description, DateTime? Operation_Date, string F_OP_ID)
    {

        try
        {
            SqlConnection SQLcon; SQLcon = new SqlConnection("Data Source=.;Initial Catalog=DiscountDB;Integrated Security=True");
            SqlCommand SQLcom = new SqlCommand("DC_Register");
            SQLcom.Connection = SQLcon;
            SQLcom.CommandType = CommandType.StoredProcedure;
            SQLcom.Parameters.AddWithValue("@DC_ID", ID);
            SQLcom.Parameters.AddWithValue("@DC_FirstPW", FirstPW);
            SQLcom.Parameters.AddWithValue("@DC_SecondPW", SecondPW);
            SQLcom.Parameters.AddWithValue("@DC_RegisterDate", RegisterDate);
            SQLcom.Parameters.AddWithValue("@DC_ExpireDate", ExpireDate);
            SQLcom.Parameters.AddWithValue("@DC_CardType", CardType);
            SQLcom.Parameters.AddWithValue("@DC_CreditCount", CreditCount);
            SQLcom.Parameters.AddWithValue("@DC_CreditFund", CreditFund);
            SQLcom.Parameters.AddWithValue("@DC_Score", Score);
            SQLcom.Parameters.AddWithValue("@DC_Status", Status);
            SQLcom.Parameters.AddWithValue("@Operation_Description", Operation_Description);
            SQLcom.Parameters.AddWithValue("@Operation_Date", Operation_Date);
            SQLcom.Parameters.AddWithValue("@F_OP_ID", F_OP_ID);
            SQLcon.Open();
            SQLcom.ExecuteNonQuery();
            SQLcon.Close();
            return "DAL-OK";
        }
        catch (Exception)
        {

            return "DAL-NOK";
        }


    }


        public void DiscountCodeprint(DataSet ds) {
            ChargeDS = ds;
            tempDT = new DataTable("DiscountDT");
            tempDT.Columns.Add("DC_ID", typeof(string));
            tempDT.Columns.Add("DC_FirstPW", typeof(string));
            tempDT.Columns.Add("DC_SecondPW", typeof(string));
            tempDT.Columns.Add("DC_RegisterDate", typeof(DateTime));
            tempDT.Columns.Add("DC_ExpireDate", typeof(DateTime));
            tempDT.Columns.Add("DC_CardType", typeof(string));
            tempDT.Columns.Add("DC_CreditCount", typeof(int));
            tempDT.Columns.Add("DC_CreditFund", typeof(float));
            tempDT.Columns.Add("DC_Score", typeof(float));
            tempDT.Columns.Add("DC_Status", typeof(Boolean));
            foreach (DataRow dr in ChargeDS.Tables["DiscountDT"].Rows)
            {
                //tempDT.Rows.Clear();
                tempDT.Rows.Add(dr.ItemArray);
               
              
            }
            Run();
            
        }
        private DataTable LoadSalesData()
        {
            // Create a new DataSet and read sales data file 
            //    data.xml into the first DataTable.

            return tempDT;
        }
        // Routine to provide to the report renderer, in order to
        //    save an image for each page of the report.
        private Stream CreateStream(string name,
          string fileNameExtension, Encoding encoding,
          string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }
        // Export the given report as an EMF (Enhanced Metafile) file.
        private void Export(LocalReport report)
        {
            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>5.8in</PageWidth>
                <PageHeight>8.3in</PageHeight>
                <MarginTop>0in</MarginTop>
                <MarginLeft>0in</MarginLeft>
                <MarginRight>0in</MarginRight>
                <MarginBottom>0in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }
        // Handler for PrintPageEvents
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }
        // Create a local report for Report.rdlc, load the data,
        //    export the report to an .emf file, and print it.
        private void Run()
        {
            LocalReport report = new LocalReport();
            report.ReportEmbeddedResource = "DiscountCodeGenerate.DiscountCardPrint.rdlc";
            report.DataSources.Add(
               new ReportDataSource("myDS", LoadSalesData()));
            Export(report);
            Print();
        }

        public void Dispose()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }

        //public static void Main(string[] args)
        //{
        //    using (ChargePrint CP = new ChargePrint())
        //    {
        //        CP.Run();
        //    }
        //}
    }
    }

