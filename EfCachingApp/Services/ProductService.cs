using System;
using System.Collections;
using System.Collections.Generic;
using EfCachingApp.DataAccess;
using EfCachingApp.DataAccess.Entities;


namespace EfCachingApp.Services;

public class ProductService
{
    public readonly AppDbContext _dbContext;
    public ProductService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public List<Product> GetAllProducts()
    { 
        return _dbContext.Product.ToList();
    }



}