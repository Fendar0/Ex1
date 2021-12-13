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
        /// Переменная с номером строки в таблице из первой формы.
        /// Просто костыль, чтобы понять как все +- работает, да и просто хз как сделать правильно)
        /// </summary>
        public int RowIndex;

        /// <summary>
        /// лист для передачи полей в методы
        /// </summary>
        public List<Data> list = new List<Data>();

        /*public void GetData()
        {
            using (var db = new ModelDBContainer())
            {
                list = db.DataSet.Select(x => x).ToList();
            }
        }*/

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

        /// <summary>
        /// Метод для "удаления" записи
        /// </summary>
        /// <param name="dataID">Перемення для определения ID записи (КОСТЫЛЬ)</param>
        public void DeleteData(int dataID)
        {            
            using (ModelDBContainer db = new ModelDBContainer())
            {
               Data data = list.ToList()[1];                                //Получение листа с данными полей определенной записи (КОСТЫЛЬ)
               Data dtrem = db.DataSet.FirstOrDefault(x => x.ID == dataID);
               dtrem.Disable = data.Disable;
               dtrem.DisableDate = data.DisableDate;
               dtrem.DisableAuthor = data.DisableAuthor;

               db.SaveChanges();
            }
        }

        /// <summary>
        /// Метод для занесения имеющихся данных в поля для редактирования данных
        /// </summary>
        /// <param name="dataID">Перемення для определения ID записи (КОСТЫЛЬ)</param>
        public void ViewRecord(int dataID)
        {
            list.Clear();
            using (ModelDBContainer db = new ModelDBContainer())
            {
                Data dtrem = db.DataSet.FirstOrDefault(x => x.ID == dataID);
                list.Add(dtrem);                                             //Занесение в лист данных определенной записи(КОСТЫЛЬ)
            }
        }
    }
}
