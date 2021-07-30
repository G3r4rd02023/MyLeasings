using System.ComponentModel.DataAnnotations;

namespace MyLeasings.Data.Entities
{
    public class PropertyImage
    {
        public int Id { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        // TODO: Change the path when publish
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://myleasing.azurewebsites.net{ImageUrl[1..]}";

        public Property Property { get; set; }
    }
}
