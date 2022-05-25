namespace FingerPrintSolution.Models
{
    public class FingerPrint
    {
        public int FingerPrintId { get; set; }

        public int ErrorCode { get; set; }

        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public string SerialNumber { get; set; }

        public int ImageWidth { get; set; }

        public int ImageHeight { get; set; }

        public int ImageDPI { get; set; }

        public int ImageQuality { get; set; }

        public int ImageNFIQ { get; set; }

        public string ImageDataBase64 { get; set; }

        public string BMPBase64 { get; set; }
        public string TemplateBase64 { get; set; }

        public int WSQImageSize { get; set; }
        public string WSQImage { get; set; }

        public string JavaScriptToRun { get; set; }
        public string JSMethodName { get; set; }
        public string JSParameter { get; set; }


    }
}
