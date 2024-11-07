namespace Учебная_практика
{
    public partial class Form1 : Form
    {
        // Объявляем объект Random для генерации случайных чисел
        private Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();// Создаем новый экземпляр Random для генерации случайных чисел
            ApplyStyles(); // Применяем стили при инициализации формы

            // Скрываем label1 при запуске программы
            labelResult.Visible = false;
        }

        private void buttonToss_Click(object sender, EventArgs e)
        {
            // Генерируем случайное число 0 или 1 для симуляции подбрасывания монеты
            int tossResult = random.Next(0, 2); //0 соответствует "Орлу", 1 - "Решке"

            // Определяем результат
            string result = tossResult == 0 ? "Орёл" : "Решка";

            // Отображаем результат в метке
            labelResult.Text = "Результат: " + result;

            // Делаем labelResult видимой
            labelResult.Visible = true; // Показываем метку после генерации результата
        }

        private void ApplyStyles()
        {
            // Настройка фона формы
            this.BackColor = Color.LightSkyBlue;

            // Настройка метки
            labelResult.Font = new Font("Arial", 14, FontStyle.Bold);
            labelResult.ForeColor = Color.Navy;
            labelResult.BackColor = Color.Transparent; // Прозрачный фон для метки
            labelResult.AutoSize = true; // Автоматический размер для метки

            // Настройка кнопки
            buttonToss.Font = new Font("Arial", 12, FontStyle.Bold);
            buttonToss.ForeColor = Color.White;
            buttonToss.BackColor = Color.DodgerBlue;
            buttonToss.FlatStyle = FlatStyle.Flat; // Плоский стиль
            buttonToss.FlatAppearance.BorderSize = 0; // Убираем границу
            buttonToss.Cursor = Cursors.Hand; // Изменяем курсор на руку при наведении
        }

    }
}
