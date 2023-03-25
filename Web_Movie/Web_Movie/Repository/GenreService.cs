﻿using MovieStoreMvc.IRepository;
using MovieStoreMvc.Models;
using WebApplication1.Models;

namespace MovieStoreMvc.Repository
{
    public class GenreService : IGenreService
    {
        private readonly MovieStoreMvcContext ctx;
        public GenreService(MovieStoreMvcContext ctx)
        {
            this.ctx = ctx;
        }
        public bool Add(Genre model)
        {
            try
            {
                ctx.Genre.Add(model);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = GetById(id);
                if (data == null)
                    return false;
                ctx.Genre.Remove(data);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Genre GetById(int id)
        {
            return ctx.Genre.Find(id);
        }

        public IQueryable<Genre> List()
        {
            var data = ctx.Genre.AsQueryable();
            return data;
        }

        public bool Update(Genre model)
        {
            try
            {
                ctx.Genre.Update(model);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
