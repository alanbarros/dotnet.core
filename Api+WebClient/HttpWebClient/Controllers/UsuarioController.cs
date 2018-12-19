using System.Collections.Generic;
using System.Threading.Tasks;
using UsuarioAPI.Models;
using HttpWebClient.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace HttpWebClient.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioRepositorio _repository;

        public UsuarioController()
        {
            _repository = new UsuarioRepositorio();
        }

        public ActionResult Index(){

            var usuarioTask = _repository.GetUsuariosAsync();

            return View(usuarioTask.Result.ToArray());            
        }

        public IActionResult Create(){

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Password")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {                
                await _repository.PostUsuarioAsync(usuario);
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Cliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _repository.GetUsuarioAsync((long)id);
            if (usuario.Username == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _repository.DeleteUsuarioAsync((long)id);
            return RedirectToAction(nameof(Index));
        }

        // GET: Usuario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _repository.GetUsuarioAsync((long)id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Password")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _repository.PutUsuarioAsync((long) id, usuario);               
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _repository.GetUsuarioAsync((long)id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }
        
    }
}