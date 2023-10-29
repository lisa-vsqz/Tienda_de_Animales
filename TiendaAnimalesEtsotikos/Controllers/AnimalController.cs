using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaAnimalesEtsotikos.Models;
using TiendaAnimalesEtsotikos.Util;

namespace TiendaAnimalesEtsotikos.Controllers
{
    public class AnimalController : Controller
    {
        // GET: AnimalController
        public IActionResult Index()
        {
            return View(Util.Utils.ListaAnimal);
        }

        // GET: AnimalController/Details/5
        public IActionResult Details(int Id)
        {
            Animal animal = Util.Utils.ListaAnimal.Find(x => x.Id == Id);
            if (animal != null)
            {
                return View(animal);
            }
            return RedirectToAction("Index");
        }

        // GET: AnimalController/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: AnimalController/Create
        [HttpPost]
        public IActionResult Create(Animal animal)
        {
            int Id = Utils.ListaAnimal.Count() + 1;
            animal.Id = Id;
            Util.Utils.ListaAnimal.Add(animal);
            return RedirectToAction("Index");
        }


        // GET: AnimalController/Edit/5
        public IActionResult Edit(int Id)
        {
            Animal animal = Util.Utils.ListaAnimal.Find(x => x.Id == Id);
            if (animal != null)
            {
                return View(animal);
            }
            return RedirectToAction("Index"); 
        }

        // POST: AnimalController/Edit/5
        [HttpPost]
        public IActionResult Edit(Animal animal)
        {
            Animal animal2 = Util.Utils.ListaAnimal.Find(x => x.Id == animal.Id);
            if (animal2 != null)
            {
                animal2.Nombre = animal.Nombre;
                animal2.NombreCientifico = animal.NombreCientifico;
                animal2.Altura = animal.Altura;
                animal2.Propietario = animal.Propietario;
                animal2.Status = animal.Status; 
                animal2.Enfermedad = animal.Enfermedad; 
                animal2.PaisOrigen = animal.PaisOrigen; 
                animal2.Peso = animal.Peso;
               
                return RedirectToAction("Index");
            }
            return View(animal);

        }


        // GET: AnimalController/Delete/5
        public IActionResult Delete(int Id)
        {
            Animal animal = Util.Utils.ListaAnimal.Find(x => x.Id==Id);
            if (animal != null)
            {
                Util.Utils.ListaAnimal.Remove(animal);
                //return View();
            }
            return RedirectToAction("Index");
        }

        
    }
}
