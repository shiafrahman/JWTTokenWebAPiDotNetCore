namespace ResumeManagementAPI.Models.Domain
{
    public class ImgUpload
    {
        public string ImageName { get; set; }
    }

    public class Common
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime JoinDate { get; set; }

        public string ImageName { get; set; }

        public IFormFile ImageUrl { get; set; }
        public string Experiences { get; set; }
    }

    
}
