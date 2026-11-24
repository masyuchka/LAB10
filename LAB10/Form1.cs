namespace LAB10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxEvent.Items.Add("Соревнование по легкой борьбе");
            comboBoxEvent.Items.Add("Мастер класс по рисованию");
            comboBoxEvent.Items.Add("Музыкальный квиз");

        }

        private int clickCount = 0;
        public bool notifications;
        public bool darktheme;
        public bool sound;

        private void buttonShow_Click(object sender, EventArgs e)
        {

        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCount_Click(object sender, EventArgs e)
        {

        }

        private void sbrosit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDate_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {


        }

        private void checkBoxNotifications_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSound_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDarkTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
        }

        private void labelMethod_Click(object sender, EventArgs e)
        {

        }

        private void buttonMethod_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonDelivery_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPickUp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubject_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAge_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxAge.Text, out int age) || age <= 0 || age > 120)
            {
                MessageBox.Show("Введите корректный возраст!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            if (textBoxName.Text == null)
            {
                MessageBox.Show("Введите имя!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            if (comboBoxEvent.SelectedItem == null)
            {
                MessageBox.Show("Выберите мероприятие из списка!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!radioButtonOffline.Checked && !radioButtonOnline.Checked)
            {
                MessageBox.Show("Выберите один из вариантов формата участия",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }

            string format = radioButtonOffline.Checked ? "Очно" : "Онлайн";
            string notifications = checkBoxAgreement.Checked ? "Да" : "Нет";
            labelResult.Text = $"Участник: {textBoxName.Text} ({textBoxAge.Text}лет)  \n " +
                $"Формат участия:  {format} \n  " +
                $"Выбранное мероприятие: {comboBoxEvent.Text}\n   " +
                $"Уведомления: {notifications} \n  ";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBoxAge.Clear();
            textBoxName.Clear();
            comboBoxEvent.SelectedItem = null;
            radioButtonOnline.Checked = false;
            radioButtonOffline.Checked = false;
            checkBoxAgreement.Checked = false;

            labelResult.Text = null;

        }
    }
}
