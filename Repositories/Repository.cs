using AVSoft.Data;
using AVSoft.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace AVSoft.Repositories
{
    public class Repository : IRepository
    {
        private AppDBContext dbcontext;
        public Repository(AppDBContext dBContent)
        {
            dbcontext = dBContent;
        }
        
        public void AddCounter(Counter counter)
        {
            dbcontext.Counters.Add(counter);
            dbcontext.SaveChanges();
        }

        public IQueryable<Counter> GetAll()
        {
            return dbcontext.Counters.ToList().AsQueryable<Counter>();
            //dbcontext.SaveChanges();
        }
    }
}