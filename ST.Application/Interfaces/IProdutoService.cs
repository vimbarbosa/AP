using ST.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST.Application.Interfaces
{
    public interface IProdutoService
    {
        Task<List<ProdutoViewModel>> ObterTodos();
    }
}
