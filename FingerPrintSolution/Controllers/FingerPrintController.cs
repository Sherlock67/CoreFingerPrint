using FingerPrintSolution.Data;
using FingerPrintSolution.Models;
using Grpc.Core;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using System.Web;


namespace FingerPrintSolution.Controllers
{
    public class FingerPrintController : Controller
    {
        private readonly ApplicationDbContext _db;
        public FingerPrintController(ApplicationDbContext db)
        {
            _db = db;
        }
        public ActionResult CreateFingerPrintData()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFingerPrintData(FingerPrint fingerPrint)
        {
            fingerPrint.ErrorCode = fingerPrint.ErrorCode;
            fingerPrint.Manufacturer = fingerPrint.Manufacturer;
            fingerPrint.Model = fingerPrint.Model;
            fingerPrint.SerialNumber = fingerPrint.SerialNumber;
            fingerPrint.ImageWidth = fingerPrint.ImageWidth;
            fingerPrint.ImageHeight = fingerPrint.ImageHeight;
            fingerPrint.ImageDPI = fingerPrint.ImageDPI;
            fingerPrint.ImageQuality = fingerPrint.ImageQuality;
            fingerPrint.ImageNFIQ = fingerPrint.ImageNFIQ;
            fingerPrint.ImageDataBase64 = fingerPrint.ImageDataBase64;
            fingerPrint.BMPBase64 = fingerPrint.BMPBase64;
            fingerPrint.TemplateBase64 = fingerPrint.TemplateBase64;
            fingerPrint.WSQImage = fingerPrint.WSQImage;
            fingerPrint.WSQImageSize = fingerPrint.WSQImageSize;
            _db.Fingerprints.Add(fingerPrint);
            _db.SaveChanges();
            return View();

        }
  
       
        //[HttpPost]
        //public IActionResult GetByID(int id)
        //{


        //    return View(jScaller);
        //}
        
        [HttpGet]
        public IActionResult GetFingerPrint(int id)
        {

            var result = _db.Fingerprints.Where(a => a.FingerPrintId == id).FirstOrDefault();
            string templatebase64 = result.TemplateBase64;
            FingerPrint jScaller = new FingerPrint();
            jScaller.JSMethodName = "SuccessFunc1";
            jScaller.JSParameter = templatebase64;
            //result.JavaScriptToRun = "ShowPopUp('ghfiagfia')";
            //result.JavaScriptToRun = "SuccessFunc1(/" + result.TemplateBase64 + "/)";
            return View(jScaller);
        }

    }
}

