using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastralPlan
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            guideLine.Text = "Приложение предназначено для просмотра файлов формата XML, содержащие в себе информацию о кадастровом плане территории."
                + "В верхней части приложения расположено меню с действиями. \n" 
                + "Действие Открыть - открывает диалоговое окно для открытия XML.\n" 
                + "Действие Сохранить - сохраняет открытые ветки древовидного представления в XML с указанным названием. "
                + "*Сохранение веток происходит со всеми вложенными узлами.\n"
                + "Древовидное представление позволяет просмотреть основную информацию, по клику на дочерний элемент можно увидеть весь выбранный узел.";
        }

        private void devInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            devInfo.LinkVisited = true;

            System.Diagnostics.Process.Start("https://github.com/fitumi0");
        }
    }
}
