using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Phone
{
    public partial class Form2 : KryptonForm
    {
        string choice = "";
        int globalstage = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kryptonRadioButton1.Checked = true;
            kryptonLabel1.Text = "Для каких целей будет использоваться телефон?";
            kryptonRadioButton1.Text = "Для развлечений";
            kryptonRadioButton2.Text = "Для работы";
            kryptonRadioButton3.Visible = false;
            kryptonRadioButton4.Visible = false;
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //Stage 1
            if (kryptonRadioButton1.Checked)
            {
                choice = kryptonRadioButton1.Text;
                globalstage++;
            }
            else if (kryptonRadioButton2.Checked)
            {
                choice = kryptonRadioButton2.Text;
                globalstage++;
            }
            else if (kryptonRadioButton3.Checked)
            {
                choice = kryptonRadioButton3.Text;
                globalstage++;
            }
            else if (kryptonRadioButton4.Checked)
            {
                choice = kryptonRadioButton4.Text;
                globalstage++;
            }

            //Stage 2
            if (choice=="Для развлечений"&globalstage==1)
            {
                //uncheck
                kryptonRadioButton1.Checked=false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //


                kryptonLabel1.Text = "Какой телефон предпочтительнее?";
                kryptonRadioButton1.Text = "Сенсорный";
                kryptonRadioButton2.Text = "Кнопочный";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice== "Для работы"&globalstage == 1)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Тип работы?";
                kryptonRadioButton1.Text = "В офисе";
                kryptonRadioButton2.Text = "Разъезды по городу";
                kryptonRadioButton3.Visible = true;
                kryptonRadioButton4.Visible = false;
                kryptonRadioButton3.Text = "Командировки";

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton3.Checked)
                {
                    choice = kryptonRadioButton3.Text;
                    globalstage++;
                }
            }

            //Stage 3
            if (choice == "Сенсорный" & globalstage == 2)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Как вы проводите свое свободное время?";
                kryptonRadioButton1.Text = "Просмотр фильмов";
                kryptonRadioButton2.Text = "Игры";
                kryptonRadioButton3.Visible = true;
                kryptonRadioButton4.Visible = true;
                kryptonRadioButton3.Text = "Чтение книг";
                kryptonRadioButton4.Text = "Интернет серфинг";

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                        globalstage++;
                }
                else if (kryptonRadioButton3.Checked)
                {
                    choice = kryptonRadioButton3.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton4.Checked)
                {
                    choice = kryptonRadioButton4.Text;
                    globalstage++;
                }
            }
            else if (choice == "Кнопочный" & globalstage == 2)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Какая ОС предпочтительнее?";
                kryptonRadioButton1.Text = "Android";
                kryptonRadioButton2.Text = "Без ОС";
                kryptonRadioButton3.Visible = true;
                kryptonRadioButton4.Visible = false;
                kryptonRadioButton3.Text = "Windows";

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton3.Checked)
                {
                    choice = kryptonRadioButton3.Text;
                    globalstage++;
                }
            }
            else if (choice == "В офисе" & globalstage == 2)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Длина диагонали экрана?";
                kryptonRadioButton1.Text = "1-2 дюйма";
                kryptonRadioButton2.Text = "2-3 дюйма";
                kryptonRadioButton3.Visible = true;
                kryptonRadioButton4.Visible = true;
                kryptonRadioButton3.Text = "3-4 дюйма";
                kryptonRadioButton4.Text = "4-5 дюйма";

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton3.Checked)
                {
                    choice = kryptonRadioButton3.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton4.Checked)
                {
                    choice = kryptonRadioButton4.Text;
                    globalstage++;
                }
            }
            else if (choice == "Разъезды по городу" & globalstage == 2)
            {
                Form3 frm3 = new Form3("63");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Командировки" & globalstage == 2)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Размер оперативной памяти телефона?";
                kryptonRadioButton1.Text = "64-256 КБ";
                kryptonRadioButton2.Text = "256-512 КБ";
                kryptonRadioButton3.Visible = true;
                kryptonRadioButton4.Visible = true;
                kryptonRadioButton3.Text = "512КБ-1ГБ";
                kryptonRadioButton4.Text = "Свыше 1ГБ";

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton3.Checked)
                {
                    choice = kryptonRadioButton3.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton4.Checked)
                {
                    choice = kryptonRadioButton4.Text;
                    globalstage++;
                }
            }

            //Stage 4

            if (choice == "Просмотр фильмов" & globalstage == 3)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Нужен ли Wi-Fi?";
                kryptonRadioButton1.Text = "Да, нужен Wi-Fi";
                kryptonRadioButton2.Text = "Нет, Wi-Fi не нужен";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            //
            else if (choice == "Игры" & globalstage == 3)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Нужен ли фонарик?";
                kryptonRadioButton1.Text = "Да, фонарик нужен";
                kryptonRadioButton2.Text = "Нет, фонарик не нужен";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "Чтение книг" & globalstage == 3)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Нужна ли высокая скорость интернета?";
                kryptonRadioButton1.Text = "Да, нужен быстрый интернет";
                kryptonRadioButton2.Text = "Нет, это не так важно";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "Интернет серфинг" & globalstage == 3)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Важно ли качество камеры?";
                kryptonRadioButton1.Text = "Да, качество камеры играет роль";
                kryptonRadioButton2.Text = "Нет, качество камеры не интересует";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "Android" & globalstage == 3)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Наличие Bluetooth?";
                kryptonRadioButton1.Text = "Да, хотелось бы иметь технологию Bluetooth";
                kryptonRadioButton2.Text = "Нет, мне не нужен Bluetooth";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "Без ОС" & globalstage == 3)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Как часто вы читаете книги?";
                kryptonRadioButton1.Text = "Часто, в книжном виде";
                kryptonRadioButton2.Text = "Часто, в электронном виде";
                kryptonRadioButton3.Visible = true;
                kryptonRadioButton4.Visible = true;
                kryptonRadioButton3.Text = "Редко";
                kryptonRadioButton4.Text = "Не читаю";

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton3.Checked)
                {
                    choice = kryptonRadioButton3.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton4.Checked)
                {
                    choice = kryptonRadioButton4.Text;
                    globalstage++;
                }
            }
            else if (choice == "Windows" & globalstage == 3)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Наличие радио?";
                kryptonRadioButton1.Text = "Да, с радио";
                kryptonRadioButton2.Text = "Нет, без радио";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "1-2 дюйма" & globalstage == 3)
            {
                Form3 frm3 = new Form3("56");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "2-3 дюйма" & globalstage == 3)
            {
                Form3 frm3 = new Form3("57");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "3-4 дюйма" & globalstage == 3)
            {
                Form3 frm3 = new Form3("58");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "4-5 дюйма" & globalstage == 3)
            {
                Form3 frm3 = new Form3("59");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "64-256 КБ" & globalstage == 3)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Нужна ли функция громкой связи?";
                kryptonRadioButton1.Text = "Да, нужна громкая связь";
                kryptonRadioButton2.Text = "Нет, громкая связь не требуется";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "256-512 КБ" & globalstage == 3)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Возраст будущего владельца телефона?";
                kryptonRadioButton1.Text = "18-30 лет";
                kryptonRadioButton2.Text = "31-50 лет";
                kryptonRadioButton3.Visible = true;
                kryptonRadioButton4.Visible = false;
                kryptonRadioButton3.Text = "Свыше 50 лет";

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton3.Checked)
                {
                    choice = kryptonRadioButton3.Text;
                    globalstage++;
                }
            }
            else if (choice == "512КБ-1ГБ" & globalstage == 3)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Наличие диктофона?";
                kryptonRadioButton1.Text = "Да, с диктофоном";
                kryptonRadioButton2.Text = "Нет, без диктофона";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "Свыше 1ГБ" & globalstage == 3)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Тип телефона?";
                kryptonRadioButton1.Text = "Обычный телефон";
                kryptonRadioButton2.Text = "Смартфон";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }

            //Stage 5
            if (choice == "Да, нужен Wi-Fi" & globalstage == 4)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Материал корпуса?";
                kryptonRadioButton1.Text = "Пластик";
                kryptonRadioButton2.Text = "Металл";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "Нет, Wi-Fi не нужен" & globalstage == 4)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Мощность аккамулятора?";
                kryptonRadioButton1.Text = "<1000mAh";
                kryptonRadioButton2.Text = "1000-1500mAh";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "Да, фонарик нужен" & globalstage == 4)
            {
                Form3 frm3 = new Form3("39");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Нет, фонарик не нужен"  & globalstage == 4)
            {
                Form3 frm3 = new Form3("40");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Да, нужен быстрый интернет" & globalstage == 4)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Нужны ли аксессуары?";
                kryptonRadioButton1.Text = "Да, аксессуары нужны";
                kryptonRadioButton2.Text = "Нет, аксессуаров не нужно";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "Нет, это не так важно" & globalstage == 4)
            {
                Form3 frm3 = new Form3("41");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Да, качество камеры играет роль" & globalstage == 4)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Важен ли дизайн?";
                kryptonRadioButton1.Text = "Да, дизайн важен";
                kryptonRadioButton2.Text = "Нет, дизайн не важен";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "Нет, качество камеры не интересует" & globalstage == 4)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Для какой возрастной группы покупается телефон?";
                kryptonRadioButton1.Text = "Нынешнее поколение";
                kryptonRadioButton2.Text = "Старшее поколение";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "Да, хотелось бы иметь технологию Bluetooth" & globalstage == 4)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Нужен ли слот для карты памяти?";
                kryptonRadioButton1.Text = "Да, слот нужен";
                kryptonRadioButton2.Text = "Нет, мне не нужна карта памяти";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "Нет, мне не нужен Bluetooth" & globalstage == 4)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Нужны ли офисные приложения?";
                kryptonRadioButton1.Text = "С приложениями";
                kryptonRadioButton2.Text = "Без приложений";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "Часто, в книжном виде" & globalstage == 4)
            {
                Form3 frm3 = new Form3("59");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Часто, в электронном виде" & globalstage == 4)
            {
                Form3 frm3 = new Form3("53");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Редко" & globalstage == 4)
            {
                Form3 frm3 = new Form3("54");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Не читаю" & globalstage == 4)
            {
                Form3 frm3 = new Form3("55");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Да, с радио" & globalstage == 4)
            {
                Form3 frm3 = new Form3("56");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Нет, без радио" & globalstage == 4)
            {
                Form3 frm3 = new Form3("57");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Да, нужна громкая связь" & globalstage == 4)
            {
                //uncheck
                kryptonRadioButton1.Checked = false;
                kryptonRadioButton2.Checked = false;
                kryptonRadioButton3.Checked = false;
                kryptonRadioButton4.Checked = false;
                //
                kryptonLabel1.Text = "Нужен ли ударопрочный корпус?";
                kryptonRadioButton1.Text = "Да, я часто подвергаю свой телефон опасности";
                kryptonRadioButton2.Text = "Нет, у меня руки-базуки";
                kryptonRadioButton3.Visible = false;
                kryptonRadioButton4.Visible = false;

                if (kryptonRadioButton1.Checked)
                {
                    choice = kryptonRadioButton1.Text;
                    globalstage++;
                }
                else if (kryptonRadioButton2.Checked)
                {
                    choice = kryptonRadioButton2.Text;
                    globalstage++;
                }
            }
            else if (choice == "Нет, громкая связь не требуется" & globalstage == 4)
            {
                Form3 frm3 = new Form3("67");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "18-30 лет" & globalstage == 4)
            {
                Form3 frm3 = new Form3("67");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "31-50 лет" & globalstage == 4)
            {
                Form3 frm3 = new Form3("50");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Свыше 50 лет" & globalstage == 4)
            {
                Form3 frm3 = new Form3("69");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Да, с диктофоном" & globalstage == 4)
            {
                Form3 frm3 = new Form3("70");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Нет, без диктофона" & globalstage == 4)
            {
                Form3 frm3 = new Form3("71");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Обычный телефон" & globalstage == 4)
            {
                Form3 frm3 = new Form3("72");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Смартфон" & globalstage == 4)
            {
                Form3 frm3 = new Form3("73");
                this.Hide();
                frm3.Show();
            }

            //Stage 6
            else if (choice == "Пластик" & globalstage == 5)
            {
                Form3 frm3 = new Form3("1");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Металл" & globalstage == 5)
            {
                Form3 frm3 = new Form3("2");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "<1000mAh" & globalstage == 5)
            {
                Form3 frm3 = new Form3("3");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "1000-1500mAh" & globalstage == 5)
            {
                Form3 frm3 = new Form3("38");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Да, аксессуары нужны" & globalstage == 5)
            {
                Form3 frm3 = new Form3("42");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Нет, аксессуаров не нужно" & globalstage == 5)
            {
                Form3 frm3 = new Form3("43");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Да, дизайн важен" & globalstage == 5)
            {
                Form3 frm3 = new Form3("44");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Нет, дизайн не важен" & globalstage == 5)
            {
                Form3 frm3 = new Form3("45");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Нынешнее поколение" & globalstage == 5)
            {
                Form3 frm3 = new Form3("46");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Старшее поколение" & globalstage == 5)
            {
                Form3 frm3 = new Form3("47");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Да, слот нужен" & globalstage == 5)
            {
                Form3 frm3 = new Form3("48");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Нет, мне не нужна карта памяти" & globalstage == 5)
            {
                Form3 frm3 = new Form3("49");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "С приложениями" & globalstage == 5)
            {
                Form3 frm3 = new Form3("50");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Без приложений" & globalstage == 5)
            {
                Form3 frm3 = new Form3("51");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Да, я часто подвергаю свой телефон опасности" & globalstage == 5)
            {
                Form3 frm3 = new Form3("43");
                this.Hide();
                frm3.Show();
            }
            else if (choice == "Нет, у меня руки-базуки" & globalstage == 5)
            {
                Form3 frm3 = new Form3("65");
                this.Hide();
                frm3.Show();
            }

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            kryptonRadioButton1.Checked = true;
            kryptonLabel1.Text = "Для каких целей будет использоваться телефон?";
            kryptonRadioButton1.Text = "Для развлечений";
            kryptonRadioButton2.Text = "Для работы";
            kryptonRadioButton3.Visible = false;
            kryptonRadioButton4.Visible = false;

            globalstage = 0;
        }
    }
}
