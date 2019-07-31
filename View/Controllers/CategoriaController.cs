﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace View.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        ///  Método que permitirá ter acesso aos dados das categorias,
        ///  filltrando, ordenando e paginando as informações de acordo com os parametros
        /// </summary>
        /// <param name="quantidade"></param>
        /// <param name="pagina"></param>
        /// <param name="busca"></param>
        /// <param name="colunaOrdem"></param>
        /// <param name="ordem"></param>
        /// <returns></returns>



        [HttpGet, Route("obtertodos")]
        public IActionResult ObterTodos(int quantidade = 10, int pagina = 0, string busca = "", string colunaOrdem = "nome", string ordem = "ASC")
        {
            return Ok();
        }
    }
}