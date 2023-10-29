using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaAnimalesEtsotikos.Models;
using TiendaAnimalesEtsotikos.Util;

namespace TiendaAnimalesEtsotikos.Controllers
{
    public class ClienteController : Controller
    {
        // GET: ClienteController
        public IActionResult Index()
        {
            return View(Util.Utils.ListaCliente);
        }

        // GET: ClienteController/Details/5
        public IActionResult Details(int Cedula)
        {
            Cliente cliente = Util.Utils.ListaCliente.Find(x => x.Cedula == Cedula);
            if (cliente != null)
            {
                return View(cliente);
            }
            return RedirectToAction("Index");
        }

        // GET: ClienteController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {           
            Util.Utils.ListaCliente.Add(cliente);
            return RedirectToAction("Index");
        }


        // GET: ClienteController/Edit/5
        public IActionResult Edit(int Cedula)
        {
            Cliente cliente = Util.Utils.ListaCliente.Find(x => x.Cedula == Cedula);
            if (cliente != null)
            {
                return View(cliente);
            }
            return RedirectToAction("Index");
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            Cliente cliente2 = Util.Utils.ListaCliente.Find(x => x.Cedula == cliente.Cedula);
            if (cliente2 != null)
            {
                cliente2.Password = cliente.Password;
                cliente2.Nombre = cliente.Nombre;
                cliente2.Cedula = cliente.Cedula;
                cliente2.Direccion = cliente.Direccion;
                cliente2.AnimalComprado = cliente.AnimalComprado;

                return RedirectToAction("Index");
            }
            return View(cliente);

        }

        // GET: ClienteController/Delete/5
        public IActionResult Delete(int Cedula)
        {
            Cliente cliente = Util.Utils.ListaCliente.Find(x => x.Cedula == Cedula);
            if (cliente != null)
            {
                Util.Utils.ListaCliente.Remove(cliente);
                //return View();
            }
            return RedirectToAction("Index");
        }


    }
}
