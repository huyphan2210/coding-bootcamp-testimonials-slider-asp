using CodingBootcampTestimonialsSlider.Models;
using CodingBootcampTestimonialsSlider.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodingBootcampTestimonialsSlider.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileTestimonialsServices? TestimonialsServices;
        public IEnumerable<Testimonials>? Testimonials { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileTestimonialsServices testimonialsServices)
        {
            _logger = logger;
            TestimonialsServices = testimonialsServices;
        }

        public void OnGet()
        {
            Testimonials = TestimonialsServices?.GetTestimonials();
        }
    }
}