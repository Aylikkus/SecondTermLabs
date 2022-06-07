using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGraphics
{
    public partial class PaintForm : Form
    {
        List<Point> listPoints = new List<Point>();
        Point[] points;
        Bitmap  image;
        Pen     pen;
        
        public PaintForm()
        {
            InitializeComponent();

            image = new Bitmap(pictureBox.Width, pictureBox.Height);
            pen   = new Pen(Color.Black);
        }

        // Рисует сплайны Безье располагая точки
        // случайным образом
        public void DrawBeziers(int numberOfPoints)
        {
            Graphics g = Graphics.FromImage(image);
            Random r = new Random();
            points = new Point[numberOfPoints];

            for (int i = 0; i < numberOfPoints; i++)
            {
                points[i].X = r.Next(pictureBox.Width);
                points[i].Y = r.Next(pictureBox.Height);
            }

            g.DrawBeziers(pen, points);
            pictureBox.Image = image;
        }

        // Рисует сплайн Безье посредством кликом мыши
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            listPoints.Add(e.Location);

            if (listPoints.Count % 3 == 1)
            {
                Graphics g = Graphics.FromImage(image);
                points = listPoints.ToArray();

                g.DrawBeziers(pen, points);
                pictureBox.Image = image;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            PromptForm pf = new PromptForm(this);
            pf.ShowDialog();
        }

        // Очистка "холста"
        private void clearBtn_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            image = new Bitmap(pictureBox.Width, pictureBox.Height);
            listPoints.Clear();
        }

        // Выбор цвета
        private void colorPanel_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorPanel.BackColor = colorDialog.Color;
            pen.Color = colorDialog.Color;
        }

        // Регулировка толщины кисти
        private void widthNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = Convert.ToSingle(widthNumUpDown.Value);
        }

        // Регулировка стиля кисти
        // DashStyle - enum, где
        // 0 - обычная, 1 - штриховая
        // 2 - пунктирная, 3 - штрихпунктирная
        // 4 - штрих штрих пунктирная
        private void dashStyleDomUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            pen.DashStyle = (System.Drawing.Drawing2D.DashStyle)
                dashStyleDomUpDown.SelectedIndex;
        }

        // Сброс точек, чтобы нарисовать новый сплайн
        private void newLineBzBtn_Click(object sender, EventArgs e)
        {
            listPoints.Clear();
        }
    }
}
