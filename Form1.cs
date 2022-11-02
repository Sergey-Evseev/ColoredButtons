using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColoredButtons
{
    public partial class Form1 : Form
    {
        //original measurements of buttons (X,Y, width, height)
        //в виде полей класса Rectangle
        //*Stores a set of four integers that represent the location and size of a rectangle
        private Rectangle button1originalRect;
        private Rectangle button2originalRect;
        private Rectangle button3originalRect;
        private Rectangle button4originalRect;
        private Rectangle button5originalRect;
        private Rectangle button6originalRect;
        private Rectangle button7originalRect;
        private Rectangle button8originalRect;
        private Rectangle button9originalRect;
        private Rectangle button10originalRect;
        private Rectangle button11originalRect;
        private Rectangle button12originalRect;
        private Rectangle button13originalRect;
        private Rectangle button14originalRect;
        private Rectangle button15originalRect;
        private Rectangle button16originalRect;
        private Rectangle button17originalRect;

        //original dimensions of the form (width and height)
        //поле класса Size для хранения первоначальных размеров формы
        private Size formOriginalSize;
        
        public Form1() 
        {
            InitializeComponent();
        }
        
        //все методы-обработчики компонентов формы только после метода InitializeComponent
        // т.е. после их создания
        private void Form1_Load(object sender, EventArgs e)
        {
            //Size gets or sets the size of the form - Width and Height.
            formOriginalSize = this.Size;

            //конструктором класса Rectangle создаем объекты Rectangle
            //с первоначальными координатами и размерами кнопок
            button1originalRect = new Rectangle(button1.Location.X, button1.Location.Y,
                button1.Width, button1.Height);
            button2originalRect = new Rectangle(button2.Location.X, button2.Location.Y,
                button2.Width, button2.Height);
            button3originalRect = new Rectangle(button3.Location.X, button3.Location.Y,
                button3.Width, button3.Height);
            button4originalRect = new Rectangle(button4.Location.X, button4.Location.Y,
                button4.Width, button4.Height);
            button5originalRect = new Rectangle(button5.Location.X, button5.Location.Y,
                button5.Width, button5.Height);
            button6originalRect = new Rectangle(button6.Location.X, button6.Location.Y,
                button6.Width, button6.Height);
            button7originalRect = new Rectangle(button7.Location.X, button7.Location.Y,
                button7.Width, button7.Height);
            button8originalRect = new Rectangle(button8.Location.X, button8.Location.Y,
                button8.Width, button8.Height);
            button9originalRect = new Rectangle(button9.Location.X, button9.Location.Y,
                button9.Width, button9.Height);
            button10originalRect = new Rectangle(button10.Location.X, button10.Location.Y,
                button10.Width, button10.Height);
            button11originalRect = new Rectangle(button11.Location.X, button11.Location.Y,
                button11.Width, button11.Height);
            button12originalRect = new Rectangle(button12.Location.X, button12.Location.Y,
                button12.Width, button12.Height);
            button13originalRect = new Rectangle(button13.Location.X, button13.Location.Y,
                button13.Width, button13.Height);
            button14originalRect = new Rectangle(button14.Location.X, button14.Location.Y,
                button14.Width, button14.Height);
            button15originalRect = new Rectangle(button15.Location.X, button15.Location.Y,
                button15.Width, button15.Height);
            button16originalRect = new Rectangle(button16.Location.X, button16.Location.Y,
                button16.Width, button16.Height);
            button17originalRect = new Rectangle(button17.Location.X, button17.Location.Y,
                button17.Width, button17.Height);
        }
                
        //вспомогательный метод для вычисления новых координат и размеров
        //принимает объект (структуру) Rectangle с параметрами кнопок и сам элемент управления
        private void resizeControl(Rectangle originalControlRect, Control control)
        {
            //вычисляем соотношение изменения ширины и высоты формы
            //кастуем обе части к флоат чтобы не было автоматического приведения к инту
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);            
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            //вычисляем новые координаты и размеры кнопок
            //приводим обратно к инту, поскольку структура Rectangle принимает инты
            //*private int x; private int y; private int width; private int height;
            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            //устанавливаем новые координаты элемента
            //класс Location: gets or sets the coordinates of the upper-left corner of the
            //control relative to the upper-left corner of its container.
            control.Location = new Point(newX, newY);

            //устанавливаем новые размеры элемента
            //*структура Size Gets a System.Drawing.Size structure that has
            //a System.Drawing.Size.Height and System.Drawing.Size.Width
            control.Size = new Size(newWidth, newHeight);
        }
        
        //при увеличении формы будут пропорционально увеличиваться все параметры кнопок
        private void resizeFormControls()
        {
            //передаем параметры элемента в структуре Rectangle и сам элемент класса control 
            resizeControl(button1originalRect, button1);
            resizeControl(button2originalRect, button2);
            resizeControl(button3originalRect, button3);
            resizeControl(button4originalRect, button4);
            resizeControl(button5originalRect, button5);
            resizeControl(button6originalRect, button6);
            resizeControl(button7originalRect, button7);
            resizeControl(button8originalRect, button8);
            resizeControl(button9originalRect, button9);
            resizeControl(button10originalRect, button10);
            resizeControl(button11originalRect, button11);
            resizeControl(button12originalRect, button12);
            resizeControl(button13originalRect, button13);
            resizeControl(button14originalRect, button14);
            resizeControl(button15originalRect, button15);
            resizeControl(button16originalRect, button16);
            resizeControl(button17originalRect, button17);
        }

        //при изменинии формы будет генериться событие и вызываться метод 
        //изменения параметров кнопок
        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeFormControls();
        }
    } //end of public partial class Form1 : Form 
} //end of namespace ColoredButtons
