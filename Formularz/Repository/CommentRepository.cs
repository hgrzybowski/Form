using Formularz.Config;
using Formularz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Formularz.Repository
{
    public class CommentRepository
    {
        public IList<Comment> Get()
        {
            using (var connect = new ConfigContext())
            {
                return connect.Comments.ToList();
            }
        }

        public Comment Get(int id)
        {
            using (var connect = new ConfigContext())
            {
                return connect.Comments.Where(x => x.Id == id).SingleOrDefault();
            }
        }

        public void Create(Comment comment)
        {
            using (var connect = new ConfigContext())
            {
                connect.Comments.Add(comment);
                connect.SaveChanges();
            }
        }

        public void Update(int Id, string description, string title)
        {
            using (var connect = new ConfigContext())
            {
                var check = connect.Comments.Where(x => x.Id == Id).SingleOrDefault();
                if (check != null)
                {
                    check.Description = description;
                    if (string.IsNullOrEmpty(title)) // title != null || title != ""
                    {
                        check.Author = title;
                    }
                    connect.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var connect = new ConfigContext())
            {
                var check = connect.Comments.Where(x => x.Id == Id).SingleOrDefault();
                if (check != null)
                {
                    connect.Comments.Remove(check);
                    connect.SaveChanges();
                }
            }
        }
    }
}