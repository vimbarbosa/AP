using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ST.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        public ILogger<ProdutoController> _logger;
        public IProdutoService _produtoService;
        public IUsuarioService _usuarioService;

        public ProdutoController(ILogger<ProdutoController> logger, 
            IProdutoService produtoService, IUsuarioService usuarioService)
        {
            _logger = logger;
            _produtoService = produtoService;
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var produtos = await _produtoService.ObterTodos();

            return Ok(produtos);
        }
    }

}
