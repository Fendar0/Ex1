using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    /// <summary>
    /// Главный класс с логикой
    /// </summary>
    public class Logical
    {        
        /// <summary>
        /// лист для передачи полей в методы
        /// </summary>
        public List<Data> list = new List<Data>();

        public List<Data> GetData()
        {
            using (ModelDBContainer db = new ModelDBContainer())
            {
               return db.DataSet.ToList();
            }
        }

        public void UpdateRecord(Data data)
        {
            using (ModelDBContainer db = new ModelDBContainer())
            {
                Data oldData = db.DataSet.FirstOrDefault(x => x.ID == data.ID);
                oldData.Surname = data.Surname;
                oldData.Name = data.Name;
                oldData.Patronymic = data.Patronymic;
                oldData.Phonenumber = data.Phonenumber;
                oldData.DateBirth = data.DateBirth;
                oldData.Email = data.Email;
                oldData.Disable = data.Disable;
                oldData.DisableDate = data.DisableDate;
                oldData.DisableAuthor = data.DisableAuthor;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Метод добавления новых записей
        /// </summary>
        /// <param name="data">Пременная для передачи заполненных полей</param>
        public void AddData(Data data)
        {
            using (ModelDBContainer db = new ModelDBContainer())
            {                
                db.DataSet.Add(data);
                db.SaveChanges();
            }
        }
    }
}
