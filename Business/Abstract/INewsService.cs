using CoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoDependencyİnjection.Business.Abstract
{
    public interface INewsService
    {
        News Get();
        List<News> GetList();
    }
}
