// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Listos para insertar un registro....");

Categorias categoria = new Categorias();

categoria.CategoriaId=0;
categoria.Descripcion="Profesional";

var contexto = new Contexto();

contexto.Categorias.Add(categoria);
contexto.SaveChanges();



