using Microsoft.AspNetCore.Mvc;
using Contas.Domain.Interfaces.Services;
using Contas.Domain.Models;
using System;

namespace Contas.Controllers
{
    public class EmpresaController : BaseController
    {
        private readonly IEmpresaService service;

        public EmpresaController(IEmpresaService service)
        {
            this.service = service;
        }

        // GET: EmpresaController
        public ActionResult Index()
        {
            return View(service.Select());
        }

        // GET: EmpresaController/Details/5
        public ActionResult Details(int id)
        {
            Empresa empresa = service.Select(id);

            if (empresa == null)
                return NotFound();

            return View(empresa);
        }

        // GET: EmpresaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpresaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Empresa empresa)
        {
            try
            {
                ClearMessage();

                if (ModelState.IsValid)
                {
                    service.Insert(empresa);

                    SetMessage("Empresa criada com sucesso.");

                    return RedirectToAction("Index");
                }

                SetMessage("Alguns dados da empresa não estão corretos, revise.", true);

                return View(empresa);
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message, true);

                return RedirectToAction("Index");
            }
        }

        // GET: EmpresaController/Edit/5
        public ActionResult Edit(int id)
        {
            Empresa empresa = service.Select(id);

            if (empresa == null)
                return NotFound();

            return View(empresa);
        }

        // POST: EmpresaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Empresa empresa)
        {
            try
            {
                ClearMessage();

                if (id != empresa.Id)
                    return NotFound();

                if (ModelState.IsValid)
                {
                    service.Update(empresa);

                    SetMessage("Empresa editada com sucesso.");

                    return RedirectToAction("Index");
                }

                SetMessage("Alguns dados da empresa não estão corretos, revise.", true);

                return View(empresa);
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message, true);

                return RedirectToAction("Index");
            }
        }

        // GET: EmpresaController/Delete/5
        public ActionResult Delete(int id)
        {
            Empresa empresa = service.Select(id);

            if (empresa == null)
                return NotFound();

            return View(empresa);
        }

        // POST: EmpresaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Empresa empresa)
        {
            try
            {
                ClearMessage();

                if (id != empresa.Id)
                    return NotFound();

                service.Delete(id);

                if (service.Select(id) == null)
                {
                    SetMessage("Empresa apagada com sucesso.");

                    return RedirectToAction("Index");
                }

                SetMessage("Não foi possível apagar a empresa selecionada.", true);

                return View(empresa);
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message, true);

                return RedirectToAction("Index");
            }
        }
    }
}
