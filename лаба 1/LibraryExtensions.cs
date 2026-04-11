using System;
using System.Collections.Generic;
using System.Linq;

namespace лаба_1
{
    
    public static class LibraryExtensions
    {
        public static List<EducationalMaterial> FindByAuthor(
            this Library<EducationalMaterial> library,
            string author)
        {
            var allMaterials = library.GetAllMaterials();

            var result = allMaterials
                .Where(m => m.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                .ToList();

            Console.WriteLine($"Найдено материалов автора '{author}': {result.Count}");
            return result;
        }
    }
}