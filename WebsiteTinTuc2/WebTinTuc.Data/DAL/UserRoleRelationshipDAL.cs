using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTinTuc.Data.DAL
{
    public class UserRoleRelationshipDAL
    {
        private DefaultDBContext context = new DefaultDBContext();

        public Customer GetByUsername(string username)
        {
            //Get from database
            var customer = context.Customers
                .Where(i => i.Username == username && i.IsDeleted == false)
                .FirstOrDefault();
            return customer;
        }

        public bool Update(Customer model)
        {
            try
            {
                //Get item user with Id from database
                var item = context.Customers.Where(i => i.Id == model.Id).FirstOrDefault();

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

        public bool Create(Customer model)
        {
            try
            {
                //Initialization empty item
                var item = new Customer();

                //Set value for item with value from model
                //Phải thêm các thuộc tính khác để đầy đủ hơn
                item.Username = model.Username;

                //Add item to entity
                context.Customers.Add(item);
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
                var item = context.Customers.SingleOrDefault(i => i.Id == id);

                //Remove item.
                context.Customers.Remove(item);

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
