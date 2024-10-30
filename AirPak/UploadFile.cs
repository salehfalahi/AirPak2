namespace AirPak
{
    public class UploadFile
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UploadFile(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public string Upload(IFormFile file)
        {
            if (file == null) return "";
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); // تولید نام فایل منحصر به فرد
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "images", fileName); // ترکیب مسیر
            using (var f = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(f);
            }
            return "/images/" + fileName;
        }

        public void Delete(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, filePath.TrimStart('/'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
        }
    }
}


