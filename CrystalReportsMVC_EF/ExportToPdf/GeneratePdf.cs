using CrystalReportsMVC_EF.Models;

namespace CrystalReportsMVC_EF.ExportToPdf
{
    public class GeneratePdf
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public void Export()
        {
            //ReportDocument aReportDocument = new ReportDocument();
            //aReportDocument.Load(Path.Combine(Server.MapPath("~/CrystalReports/ProductsCrystalReport.rpt")));
            //aReportDocument.SetDataSource(db.Products.Select(p => new
            //{
            //    Id = p.Id,
            //    Name = p.Name,
            //    CategoryName = p.Category.Name,
            //    Quentity = p.Quentity,
            //    Price = p.Price
            //}).ToList());
            //Response.Buffer = false;
            //Response.ClearContent();
            //Response.ClearHeaders();
            //Stream aStream = aReportDocument.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            //aStream.Seek(0, SeekOrigin.Begin);
            //return File(aStream, "application/pdf", "ProductList.pdf");
        }
    }
}