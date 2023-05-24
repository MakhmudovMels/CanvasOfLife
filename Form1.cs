using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanvasOfLife
{
    /// <summary>
    /// Форма с тестом
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Массив названий файлов изображений
        /// </summary>
        private List<List<string>> pathOfImages = new List<List<string>>();
        /// <summary>
        /// Путь к изображениям
        /// </summary>
        private string mainPath = "../../images/";
        /// <summary>
        /// Путь к фоновому изображению
        /// </summary>
        private string backgroundPath;
        private readonly List<string> nameOfFiles = new List<string>() {
                "Когда вы родились/", "Какая у вас семья/",
                "Брат сестра/", "Где вы родились/",
                "Женат замужем/", "Дети/",
                "Образование/", "Работа/",
                "Должность/", "Домашние животные/",
                "Питание/", "Хобби/",
                "Спорт/", "Путешествие/",
            };
        
        public Form1()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// Переход к предыдущему слайду
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 1;
        }

        /// <summary>
        /// Переход к следующему слайду
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForwardBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex += 1;
        }

        /// <summary>
        /// Меняет цвет кнопки при наведении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.BackColor = Color.DarkCyan;
            btn.ForeColor = Color.White;
        }

        /// <summary>
        /// Меняет цвет кнопки при наведении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.BackColor = Color.Aquamarine;
            btn.ForeColor = Color.Black;
        }

        /// <summary>
        /// Завершает тест
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void FinishBtn_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = false; // Блокируем тест
            Cursor = Cursors.WaitCursor; // Устанавливаем ожидающий курсор
            if (!IsValidation()) // Валидация
            {
                tabControl1.Enabled = true; // Разблокируем тест
                Cursor = Cursors.Default; // Устанавливаем стандартный курсор
                return;
            }
                
            PathInitialization(); // Инициализируем массив путей

            Bitmap bitmap = new Bitmap(1, 1);
            // Создаём класс Canvas и передаём пути к изображениям
            await Task.Run(() => { bitmap = Canvas.CanvasGeneration(backgroundPath, pathOfImages); });
            
            // Создаём вторую форму и передаём сгенерированное изображение
            Form2 form2 = new Form2(bitmap);
            form2.Show();

            Restart();
            Cursor = Cursors.Default; // Устанавливаем стандартный курсор
            tabControl1.SelectedIndex = 0; // Устанавливаем первый слайд
            tabControl1.Enabled = true; // Разблокируем тест
        }

        /// <summary>
        /// Инициализирует пути к изображениям
        /// </summary>
        private void PathInitialization()
        {
            // Определяем расцветку изображения
            if (сolorRadioBtn1.Checked)
                mainPath += "blue/";
            else if (сolorRadioBtn2.Checked)
                mainPath += "green/";
            else if (сolorRadioBtn3.Checked)
                mainPath += "red/";
            else if (сolorRadioBtn4.Checked)
                mainPath += "yellow/";
            else if (сolorRadioBtn5.Checked)
                mainPath += "grey/";
            else if (сolorRadioBtn6.Checked)
                mainPath += "brown/";
            else if (сolorRadioBtn7.Checked)
                mainPath += "violet/";
            else if (сolorRadioBtn8.Checked)
                mainPath += "black/";

            backgroundPath = mainPath + "background.png";

            // Инициализируем пути к пиктограммам
            var tabPages = tabControl1.TabPages;
            for (int i = 0; i < tabPages.Count - 1; i++)
            {                
                List<string> list = new List<string>();
                var controls = tabPages[i].Controls;
                foreach (Control controlElement in controls)
                {
                    if (controlElement is CheckBox)
                        if ((controlElement as CheckBox).Checked)
                            list.Add(mainPath + nameOfFiles[i] + (controlElement as CheckBox).Text + ".png");
                    if (controlElement is RadioButton)
                        if ((controlElement as RadioButton).Checked)
                        {
                            list.Add(mainPath + nameOfFiles[i] + (controlElement as RadioButton).Text + ".png");
                            break;
                        }
                }
                pathOfImages.Add(list);                
            }
        }

        /// <summary>
        /// Перезапускает тест
        /// </summary>
        private void Restart()
        {
            mainPath = "../../images/";
            pathOfImages.Clear();

            // Чистим тест
            var tabPages = tabControl1.TabPages;
            foreach (TabPage tabPage in tabPages)
            {                
                var controls = tabPage.Controls;
                foreach (Control controlElement in controls)
                {
                    if (controlElement is CheckBox)
                        if ((controlElement as CheckBox).Checked)
                            (controlElement as CheckBox).Checked = false;
                    if (controlElement is RadioButton)
                        if ((controlElement as RadioButton).Checked)
                            (controlElement as RadioButton).Checked = false;
                }
            }
        }

        /// <summary>
        /// Проверяет заполнены ли все чекбоксы и радиокнопки
        /// </summary>
        /// <returns></returns>
        private bool IsValidation()
        {
            // Проверяем заполнены ли все чекбоксы и радиокнопки
            var tabPages = tabControl1.TabPages;
            foreach (TabPage tabPage in tabPages)
            {
                bool isNotValidation = true;
                var controls = tabPage.Controls;                
                foreach (Control controlElement in controls)
                {     
                    if(controlElement is CheckBox)
                        if ((controlElement as CheckBox).Checked)
                        {
                            isNotValidation = false;
                            break;
                        }
                    if(controlElement is RadioButton)
                        if ((controlElement as RadioButton).Checked)
                        {
                            isNotValidation = false;
                            break;
                        }
                }
                if (isNotValidation)
                {
                    MessageBox.Show("Вы ответили не на все вопросы", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabControl1.SelectedTab = tabPage;
                    return false;
                }
            }            
            return true;
        }       
    }
}
