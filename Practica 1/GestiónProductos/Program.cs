namespace GestiónProductos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar la clase del repositorio
            IProductRepository repo = new ProductRepository();

            Console.WriteLine("--- 1. IMPRESIÓN DE LA LISTA COMPLETA ---");
            List<Product> todos = repo.GetAll();
            foreach (var p in todos)
            {
                Console.WriteLine($"[{p.Id}] {p.Name} - ${p.Price} ({p.Category})");
            }

            Console.WriteLine("\n--- 2. BÚSQUEDA DE UN PRODUCTO POR ID (Ej: 2) ---");
            Product buscado = repo.GetById(2);
            if (buscado != null)
            {
                Console.WriteLine($"Encontrado: {buscado.Name} - ${buscado.Price}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }

            Console.WriteLine("\n--- 3. FILTRADO DE PRODUCTOS POR CATEGORÍA (Ej: 'Periféricos') ---");
            List<Product> filtrados = repo.SearchByCategory("Periféricos");
            foreach (var p in filtrados)
            {
                Console.WriteLine($"- {p.Name}");
            }

            Console.WriteLine("\n--- 4. INCORPORACIÓN DE UN NUEVO PRODUCTO ---");
            Product nuevoProducto = new Product
            {
                Id = 7,
                Name = "Auriculares Gamer",
                Price = 35000m,
                Category = "Audio",
                IsAvailable = true
            };
            repo.AddProduct(nuevoProducto);
            Console.WriteLine("Producto 'Auriculares Gamer' agregado con éxito.");

            Console.WriteLine("\n--- IMPRESIÓN DE LA LISTA ACTUALIZADA ---");
            foreach (var p in repo.GetAll())
            {
                Console.WriteLine($"[{p.Id}] {p.Name} - ${p.Price} ({p.Category})");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
