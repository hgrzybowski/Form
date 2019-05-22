using Formularz.Config;
using Formularz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Formularz.Repository
{
    public class PostRepository
    {
        public IList<Post> Get()
        {
            using (var connect = new ConfigContext())
            {
                return connect.Posts.ToList();
            }
        }

        public Post Get(int id)
        {
            using (var connect = new ConfigContext())
            {
                return connect.Posts.Where(x => x.Id == id).SingleOrDefault();
            }
        }

        public void Create(Post post)
        {
            using (var connect = new ConfigContext())
            {
                connect.Posts.Add(post);
                connect.SaveChanges();
            }
        }

        public void Update (int Id, string description, string title)
        {
            using (var connect = new ConfigContext())
            {
                var check = connect.Posts.Where(x => x.Id == Id).SingleOrDefault();
                if(check !=null) 
                {
                    check.Description = description;
                    if (string.IsNullOrEmpty(title)) // title != null || title != ""
                    {
                        check.Title = title;
                    } 
                    connect.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var connect = new ConfigContext())
            {
                var check = connect.Posts.Where(x => x.Id == Id).SingleOrDefault();
                if(check != null)
                {
                    connect.Posts.Remove(check);
                    connect.SaveChanges();
                }
            }
        }
    }
}