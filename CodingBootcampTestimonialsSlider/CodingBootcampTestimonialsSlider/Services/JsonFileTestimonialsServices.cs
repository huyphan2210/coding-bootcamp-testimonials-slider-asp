﻿using CodingBootcampTestimonialsSlider.Models;
using System.Text.Json;

namespace CodingBootcampTestimonialsSlider.Services
{
    public class JsonFileTestimonialsServices
    {
        public JsonFileTestimonialsServices(IWebHostEnvironment webHostEnvironment)
        {
           WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "testimonials.json"); }
        }

        public IEnumerable<Testimonials> GetTestimonials()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Testimonials[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
