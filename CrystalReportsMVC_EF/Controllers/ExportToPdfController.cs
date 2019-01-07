using CrystalDecisions.CrystalReports.Engine;
using CrystalReportsMVC_EF.Models;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace CrystalReportsMVC_EF.Controllers
{
    public class ExportToPdfController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ExportToPdf
        public ActionResult Export()
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/CrystalReports/ProductsCrystalReport.rpt")));
            rd.SetDataSource(db.Products.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                CategoryName = p.Category.Name,
                Quentity = p.Quentity,
                Price = p.Price
            }).ToList());
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            Stream aStream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            aStream.Seek(0, SeekOrigin.Begin);
            return File(aStream, "application/pdf", "ProductList.pdf");
        }

        public ActionResult ExportToGroupBy()
        {
            return View();
        }
    }
}