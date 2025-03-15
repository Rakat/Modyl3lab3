using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modyl3lab3
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Завдання 1: Форма реєстрації
        private void btnSubmitRegistration_Click(object sender, EventArgs e)
        {
            // Отримуємо значення з NumericUpDown
            int year = (int)numericUpDownYear.Value;
            int month = (int)numericUpDownMonth.Value;
            int day = (int)numericUpDownDay.Value;

            // Отримуємо значення статі
            string gender = radioButtonMale.Checked ? "Чоловік" : "Жінка";

            // Виводимо в TextBox
            textBoxResult.Text = $"Задача 1 - Реєстрація:\nДата народження: {day}/{month}/{year}\nСтать: {gender}\n\n";
        }

        // Завдання 2: Розрахунок вартості замовлення фотографій
        private void btnCalculatePhotoOrder_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDownQuantity.Value;
            double pricePerPhoto = 0;

            // Вибір розміру
            if (radioButton9x12.Checked)
                pricePerPhoto = 10;
            else if (radioButton12x15.Checked)
                pricePerPhoto = 15;
            else if (radioButton18x24.Checked)
                pricePerPhoto = 20;

            // Розрахунок вартості
            double totalCost = pricePerPhoto * quantity;

            // Знижка, якщо більше 20 фотографій
            if (quantity > 20)
                totalCost *= 0.9;

            textBoxResult.AppendText($"Задача 2 - Фото замовлення:\nВартість: {totalCost} грн.\n\n");
        }

        // Завдання 3: Розрахунок вартості автомобіля
        private void btnCalculateCarPrice_Click(object sender, EventArgs e)
        {
            double basePrice = 20000; // Базова ціна автомобіля
            double extraPrice = 0;

            // Додаємо ціну за додаткові опції
            if (checkBoxLeatherSeats.Checked)
                extraPrice += 2000;
            if (checkBoxSunroof.Checked)
                extraPrice += 1500;
            if (checkBoxNavigation.Checked)
                extraPrice += 1000;

            // Розрахунок загальної вартості
            double totalPrice = basePrice + extraPrice;
            textBoxResult.AppendText($"Задача 3 - Автомобіль:\nЗагальна вартість: {totalPrice} грн.\n");
        }
    }
}
