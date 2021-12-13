using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class FormADD : Form
    {
        string selectbutton; //Запись нажатой кнопки
        int ID; //ID записи(КОСТЫЛЬ)

        public FormADD(string selectbt)
        {
            InitializeComponent();
            selectbutton = selectbt; //Получение нажатой кнопки с другой формы
        }

        /// <summary>
        /// Кнопка подтверждения действий при редактировании, добавлении или "удалении" записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btApply_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            switch (selectbutton)
            {
                //Нажата ли кнопка Add
                case"Add":                    
                    data.Surname = tbSurname.Text;
                    data.Name = tbName.Text;
                    data.Patronymic = tbPatronymic.Text;
                    data.Phonenumber = tbPnonenumber.Text;
                    data.DateBirth = dtDateBirth.Value;
                    data.Email = tbEmail.Text;
                    data.Disable = false;

                    Program.logic.AddData(data);
                    break;

                case "Ed":                    
                    
                    //Пока забей
                    break;

                    //нажата ли кнопка Remov
                case "Rem":
                    ID = Program.logic.RowIndex + 1;

                    data.Disable = ckDisable.Checked;
                    data.DisableDate = dtDisableDate.Value;
                    data.DisableAuthor = tbDisableAuthor.Text;                    
                    
                    Program.logic.list.Add(data);
                    Program.logic.DeleteData(ID);
                    break;

            }            

            Hide();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormADD_Load(object sender, EventArgs e)
        {
            //Если нажата кнопка Remove, то появляются определенные поля ввода и заполняются из таблицы
            if(selectbutton.Equals("Rem"))
            {                
                ckDisable.Visible = true;
                dtDisableDate.Visible = true;
                tbDisableAuthor.Visible = true;

                ID = Program.logic.RowIndex + 1; //ID записи (КОСТЫЛЬ) 
                Program.logic.ViewRecord(ID); // Передача ID в метод класса logic

                Data dt = Program.logic.list.ToList()[0];  //Получение листа с данными полей определенной записи (КОСТЫЛЬ)

                tbSurname.Text = dt.Surname;
                tbName.Text = dt.Name;
                tbPatronymic.Text = dt.Patronymic;
                tbPnonenumber.Text = dt.Phonenumber;
                dtDateBirth.Value = dt.DateBirth;
                tbEmail.Text = dt.Email;
                ckDisable.Checked = dt.Disable;
                dtDisableDate.Value = (DateTime)dt.DisableDate;
                tbDisableAuthor.Text = dt.DisableAuthor;

            }
            else if (selectbutton.Equals("Ed"))
            {
                ckDisable.Visible = true;
                dtDisableDate.Visible = true;
                tbDisableAuthor.Visible = true;
            }
            else
            {
                ckDisable.Visible=false;
                dtDisableDate.Visible = false;
                tbDisableAuthor.Visible = false;
            }
        }
    }
}
