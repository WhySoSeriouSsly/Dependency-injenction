using CoreMVC.Business.Abstract;
using CoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoDependencyİnjection.Business.Concrete
{
    public class SqlNewsDataManager:INewsService
    {
        public News Get()
        {
            return new News();

        }

        public List<News> GetList()
        {
            return new List<News>();
        }

    }
}
