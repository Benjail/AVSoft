using AVSoft.Data;
using AVSoft.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AVSoft.Repositories
{
    public interface IRepository
    {
        IQueryable<Counter> GetAll();                       
        void AddCounter(Counter counter);                   
    }
}