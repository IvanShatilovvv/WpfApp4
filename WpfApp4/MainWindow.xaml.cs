using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ObjectMovementApp
{
    public partial class MainWindow : Window
    {
        private void MoveObject(double X, double Y)   //Метод MoveObject перемещает объект на заданные пиксели по горизонтали и вертикали
        {                                            
            Canvas.SetLeft(objectToMove, Canvas.GetLeft(objectToMove) + X);  //Перемещение по горизонтале (ось Х)
            Canvas.SetTop(objectToMove, Canvas.GetTop(objectToMove) + Y);    //Перемещение по вертикале (ось У)
            //После происходит проверка, чтобы объект не вышел за границы окна по ширине и высоте. Если объект выходит за пределы окна, его позиция корректируется
            double ширина = Math.Max(0, Math.Min(x.ActualWidth - objectToMove.ActualWidth, Canvas.GetLeft(objectToMove)));
            double высота = Math.Max(0, Math.Min(x.ActualHeight - objectToMove.ActualHeight, Canvas.GetTop(objectToMove)));
            Canvas.SetLeft(objectToMove, ширина);
            Canvas.SetTop(objectToMove, высота);
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)   //Задаю кнопке то, что она должна делать
        {
            MoveObject(0, -15);  //Смещение на 15 пикселей вверх
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)  //Задаю кнопке то, что она должна делать
        {
            MoveObject(0, 15);   //Смещение на 15 пикселей вниз
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)   //Задаю кнопке то, что она должна делать
        {
            MoveObject(-15, 0);   //Смещение на 15 пикселей влево
        }

        private void RightButton_Click(object sender, RoutedEventArgs e)   //Задаю кнопке то, что она должна делать
        {
            MoveObject(15, 0);   //Смещение на 15 пикселей вправо
        }
    }
}
