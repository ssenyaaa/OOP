using System;
using System.Collections.Generic;
using System.Linq;

namespace лаба_1
{
    // Обобщенный класс с ограничением: T должен быть EducationalMaterial или его наследником
    public class Library<T> where T : EducationalMaterial
    {
        // Приватное поле для хранения материалов
        private List<T> materials = new List<T>();

        // Статическое поле для подсчета количества материалов (во всех библиотеках)
        private static int totalMaterialCount = 0;

        // Статическое свойство для доступа к счетчику
        public static int TotalMaterialCount
        {
            get { return totalMaterialCount; }
        }

        // Свойство для получения количества материалов в текущей библиотеке
        public int Count
        {
            get { return materials.Count; }
        }

        // 1. Метод для добавления материала
        public void AddMaterial(T material)
        {
            if (material != null)
            {
                materials.Add(material);
                totalMaterialCount++; // Увеличиваем статический счетчик
                Console.WriteLine($"Добавлен материал: {material.Title}");
            }
            else
            {
                throw new ArgumentNullException(nameof(material), "Материал не может быть null");
            }
        }

        // 2. Метод для поиска материала по названию
        public T FindByTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Название не может быть пустым");

            // Поиск первого материала с указанным названием (без учета регистра)
            T found = materials.FirstOrDefault(m =>
                m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

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

        // 3. Метод для отображения содержимого всех материалов
        public void ShowAllContents()
        {
            if (materials.Count == 0)
            {
                Console.WriteLine("Библиотека пуста");
                return;
            }

            Console.WriteLine($"\n=== ВСЕ МАТЕРИАЛЫ БИБЛИОТЕКИ (всего: {materials.Count}) ===");
            for (int i = 0; i < materials.Count; i++)
            {
                Console.WriteLine($"\n--- Материал #{i + 1} ---");
                materials[i].DisplayContent(); // Полиморфный вызов
            }
        }

        // 4. Метод для вывода краткой информации обо всех материалах
        public void ShowAllBasicInfo()
        {
            if (materials.Count == 0)
            {
                Console.WriteLine("Библиотека пуста");
                return;
            }

            Console.WriteLine($"\n=== КРАТКАЯ ИНФОРМАЦИЯ (всего: {materials.Count}) ===");
            foreach (var material in materials)
            {
                material.ShowBasicInfo();
                Console.WriteLine();
            }
        }

        // 5. Метод для получения всех материалов (на случай, если нужен доступ к списку)
        public IReadOnlyList<T> GetAllMaterials()
        {
            return materials.AsReadOnly();
        }

        // 6. Статический метод для сброса счетчика (опционально)
        public static void ResetCounter()
        {
            totalMaterialCount = 0;
        }
    }
}