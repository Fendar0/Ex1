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
        Data data;
        
        public FormADD(Data _data)
        {
            InitializeComponent();
            data = _data;

            tbSurname.Text = _data.Surname;
            tbName.Text = _data.Name;
            tbPatronymic.Text = _data.Patronymic;
            tbPnonenumber.Text = _data.Phonenumber;           
            dtDateBirth.Value = _data.DateBirth;
            tbEmail.Text = _data.Email;
            ckDisable.Checked = _data.Disable;
            dtDisableDate.Value = (DateTime)_data.DisableDate;
            tbDisableAuthor.Text = _data.DisableAuthor;
        }

        /// <summary>
        /// Кнопка подтверждения действий при редактировании, добавлении или "удалении" записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btApply_Click(object sender, EventArgs e)
        {            
            data.Surname = tbSurname.Text.Trim();
            data.Name = tbName.Text.Trim();
            data.Patronymic = tbPatronymic.Text.Trim();
            data.Phonenumber = tbPnonenumber.Text.Trim();
            data.DateBirth = dtDateBirth.Value;
            data.Email = tbEmail.Text.Trim();
            data.Disable = ckDisable.Checked;
            data.DisableDate = dtDateBirth.Value;
            data.DisableAuthor = tbDisableAuthor.Text.Trim();

            DialogResult = DialogResult.OK;
        }

    }
}
