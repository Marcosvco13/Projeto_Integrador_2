﻿using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Console;
using Projeto_Integrador.Models.Models;
using Projeto_Integrador.Models.Services;
using Projeto_Integrador.ViewModel;

namespace Projeto_Integrador.Controllers
{
    [Authorize]
    public class FichasController : Controller
    {
        private ServiceFichas _ServiceFichas;

        public FichasController()
        {
            _ServiceFichas = new ServiceFichas();
        }
        public IActionResult Index()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(FichaVM.ListarFicha(userid));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create (FichaDoacao fichadoacao)
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var db = new DOACAO_SANGUEContext();
            var fichaExists = db.FichaDoacao.Any(x => x.IdUser == userid);
            if (ModelState.IsValid)
            {
                if (!fichaExists)
                {
                    fichadoacao = await _ServiceFichas.oRepositoryFichas.IncluirAsync(fichadoacao);
                    return View(fichadoacao);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Erro: Já existe uma ficha cadastrada. Caso queira fazer alguma alteração, favor ir para aba de edição da ficha.");
                }
                return View(fichadoacao);
            }
            else
            {
                return View(fichadoacao);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var ficha = await _ServiceFichas.oRepositoryFichas.SelecionarPkAsync(userid);
            return View(ficha);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(FichaDoacao fichaDoacao)
        {
            if(ModelState.IsValid)
            {
                var ficha = await _ServiceFichas.oRepositoryFichas.AlterarAsync(fichaDoacao);
                return RedirectToAction("Index");
            }
            ViewData["MensagemErro"] = "Ocorreu um erro";
            return RedirectToAction("Index");
        }

        public IActionResult Details()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(FichaVM.SelecionarFicha(userid));
        }
    }
}
