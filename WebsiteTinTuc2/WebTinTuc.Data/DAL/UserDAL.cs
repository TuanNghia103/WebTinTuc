using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTinTuc.Data.Entities;

namespace WebTinTuc.Data.DAL
{
    public class UserDAL
    {
        private DefaultDBContext context = new DefaultDBContext();

        public User GetByUsername(string username)
        {
            //Get from database
            var user = context.Users
                .Where(i => i.Username == username && i.IsDeleted == false)
                .FirstOrDefault();
            return user;
        }

        public bool Update(User model)
        {
            try
            {
                //Get item user with Id from database
                var item = context.Users.Where(i => i.Id == model.Id).FirstOrDefault();

                //Set value item with value from model
                item.Username = model.Username;

                //Save change to database
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Create(User model)
        {
            try
            {
                //Initialization empty item
                var item = new User();

                //Set value for item with value from model
                item.Username = model.Username;

                //Add item to entity
                context.Users.Add(item);
                //Save to database
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(long id)
        {
            try
            {
                //Tương tự update
                var item = context.Users.SingleOrDefault(i => i.Id == id);

                //Remove item.
                context.Users.Remove(item);

                //Change database
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
