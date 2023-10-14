﻿using project_backend.Dto;
using project_backend.Models;
using project_backend.Schemas;
using System.Linq.Expressions;

namespace project_backend.Interfaces
{
    public interface ITableRestaurant
    {
        public Task<List<TableRestaurant>> GetAll();
        public Task<TableRestaurant> GetById(int id);
        public Task<bool> CreateTable(TableRestaurant table);
        public Task<bool> UpdateTable(TableRestaurant table);
        public Task<bool> DeleteTable(TableRestaurant table);
        public Task<int> Count(Expression<Func<TableRestaurant, bool>> predicate = null);
        public Task<List<TableRestaurantWithCommand>> GetTableCollectionWithCommand(string role);
    }
}
