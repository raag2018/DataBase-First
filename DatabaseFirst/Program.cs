using DatabaseFirst.Models;

using (var context = new TiendaContext())
{
    var data = context.Productos.ToList();
    foreach (var item in data)
    {
        Console.WriteLine(item.Nombre);
    }
}