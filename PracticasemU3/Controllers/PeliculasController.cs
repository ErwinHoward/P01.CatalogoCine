using PracticasemU3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 

namespace PracticasemU3.Controllers
{
    public class PeliculasController : Controller
    {

        readonly PeliculasBDConection db = new PeliculasBDConection();
        // GET: Peliculas
        public ActionResult Index()
        {
            var Peliculas = db.Peliculas.ToList();
            return View(Peliculas);
        }

        // GET: Peliculas/Details/5
        public ActionResult Details(int id)
        {
            var pelicula = db.Peliculas.Find(id);
            return View(pelicula);
        }

        // GET: Peliculas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Peliculas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Peliculas/Edit/5
        public ActionResult Edit(int id)
        {
            var Pelicula = db.Peliculas.Find(id);
            return View(Pelicula);
        }

        // POST: Peliculas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Pelicula c)
        {
            try
            {
                var pelicula = db.Peliculas.Find(id);
                // TODO: Add update logic here

                pelicula.Nombre = c.Nombre;
                pelicula.Descripcion = c.Descripcion;
                pelicula.Hora = c.Hora;
                db.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Peliculas/Delete/5
        public ActionResult Delete(int id)
        {
            var pelicula = db.Peliculas.Find(id);
            db.Peliculas.Remove(pelicula);
            db.SaveChanges();
            return View("Index");
        }

        // POST: Peliculas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
