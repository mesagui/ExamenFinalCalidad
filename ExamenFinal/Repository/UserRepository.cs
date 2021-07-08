
using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Repository
{
    public interface IUserRepository
    {
        public Usuario FindUser(string username, string password);
        Usuario FindByUsername(string username);
        void Create(Usuario user);
        List<Usuario> GetAll();
    }

    public class UserRepository : IUserRepository
    {
        private readonly IFinalContext context;

        public UserRepository(IFinalContext context)
        {
            this.context = context;
        }

        public void Create(Usuario user)
        {
            context.Add(user);
            context.SaveChanges();
        }

        public Usuario FindByUsername(string username)
        {
            return context.Usuarios.Where(o => o.UserName == username).FirstOrDefault();
        }

        public List<Usuario> GetAll()
        {
            return context.Usuarios.ToList();
        }
        public Usuario FindUser(string username, string password)
        {
            return context.Usuarios
               .Where(o => o.UserName == username && o.Password == password)
               .FirstOrDefault();
        }
    }
}
