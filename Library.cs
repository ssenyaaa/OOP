using System;
using System.Collections.Generic;
using System.Linq;

namespace лаба_1
{
    
    public class Library<T> where T : EducationalMaterial
    {
        
        private List<T> materials = new List<T>();

        
        private static int totalMaterialCount = 0;

        
        public static int TotalMaterialCount
        {
            get { return totalMaterialCount; }
        }

        public int Count
        {
            get { return materials.Count; }
        }

        
        public void AddMaterial(T material)
        {
            if (material != null)
            {
                materials.Add(material);
                totalMaterialCount++; 
                Console.WriteLine($"Добавлен материал: {material.Title}");
            }
            else
            {
                throw new ArgumentNullException(nameof(material), "Материал не может быть null");
            }
        }

        
        public T FindByTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Название не может быть пустым");

           
            T found = materials.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (found != null)
            {
                Console.WriteLine($"Найден материал: {found.Title}");
            }
            else
            {
                Console.WriteLine($"Материал с названием '{title}' не найден");
            }

            return found;
        }

        
        public void ShowAllContents()
        {
            if (materials.Count == 0)
            {
                Console.WriteLine("Библиотека пуста");
                return;
            }

            Console.WriteLine($"\n ВСЕ МАТЕРИАЛЫ БИБЛИОТЕКИ (всего: {materials.Count}) ");
            for (int i = 0; i < materials.Count; i++)
            {
                Console.WriteLine($"\n Материал #{i + 1} ");
                materials[i].DisplayContent(); 
            }
        }

        
        public void ShowAllBasicInfo()
        {
            if (materials.Count == 0)
            {
                Console.WriteLine("Библиотека пуста");
                return;
            }

            Console.WriteLine($"\n КРАТКАЯ ИНФОРМАЦИЯ (всего: {materials.Count}) ");
            foreach (var material in materials)
            {
                material.ShowBasicInfo();
                Console.WriteLine();
            }
        }

       
        public IReadOnlyList<T> GetAllMaterials()
        {
            return materials.AsReadOnly();
        }

        
        public static void ResetCounter()
        {
            totalMaterialCount = 0;
        }
    }
}