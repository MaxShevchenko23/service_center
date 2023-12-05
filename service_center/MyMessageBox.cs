using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace service_center
{
    public static class MyMessageBox
    {
        
        public static void Show(string message)
        {
            Form customForm = new Form();
            customForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            customForm.StartPosition = FormStartPosition.CenterParent;
            customForm.Size = new Size(800, 150);

            // Настройка цвета текста и фона
            customForm.BackColor = Color.CornflowerBlue;
            customForm.ForeColor = Color.DarkBlue;

            // Создание метки с текстом
            Label label = new Label();
            label.Text = message;
            label.AutoSize = true;
            label.Font = new Font("Tahoma", 14, FontStyle.Bold);
            label.Location = new Point(20, 20);
            customForm.Controls.Add(label);

            // Создание кнопки "OK"
            Button button = new Button();
            button.Text = "OK";
            button.Font = new Font("Tahoma", 14, FontStyle.Bold);
            button.BackColor = Color.CornflowerBlue;
            button.ForeColor = Color.DarkBlue;
            button.DialogResult = DialogResult.OK;
            button.Location = new Point(350, 70);
            button.Size = new Size(button.Size.Width, 30);
            customForm.Controls.Add(button);

            // Отображение пользовательского окна сообщения
            customForm.ShowDialog();
        }
    }
}
