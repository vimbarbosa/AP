using Microsoft.Extensions.Logging;
using ST.Application.Interfaces;
using ST.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly ILogger<ProdutoService> _logger;
        public ProdutoService(ILogger<ProdutoService> logger)
        {
            _logger = logger;
        }

        public async Task<List<ProdutoViewModel>> ObterTodos()
        {
            var list = new List<ProdutoViewModel>()
            {
                new ProdutoViewModel()
                {
                    Name = "Handcrafted Plastic Keyboard"
                }
            };

            return list;
        }
    }
}
