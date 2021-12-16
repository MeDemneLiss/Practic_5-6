using System.Windows;

namespace Practic_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Car carNumberOne = new Car ();
        Car carNumberTwo = new Car();

        private void ChangeParameters_Click(object sender, RoutedEventArgs e)
        {
            if (firstCar.IsChecked == true)
            {
                FillInformation(carNumberOne);
            }
            else
            {
                FillInformation(carNumberTwo);
            }
            parameterOutput.Text = carNumberOne.ShowInformation() + "\n \n" + carNumberTwo.ShowInformation();
        }

        private void FillInformation(Car vehicle)
        {
            if (tredemark.Text != string.Empty)
            {
                vehicle.SetParams(tredemark.Text);

            }

            if (int.TryParse(power.Text, out int powerVaue))
            {
                if (powerVaue < 0)
                {
                    MessageBox.Show("Значение поля Мощность должно быть положительным ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    vehicle.SetParams(powerVaue);
                }
            }

            if (double.TryParse(numberCylinders.Text, out double numberCylindersValue))
            {
                if (numberCylindersValue < 0)
                {
                    MessageBox.Show("Значение поля кол-во цилиндров должно быть положительным", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    vehicle.SetParams(numberCylindersValue);
                }
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Самсаков Андрей Александрович ИСП-31\nПрактическая работа№5-6\n - Создать базовый класс Саr (машина), характеризуемый торговой маркой (строка), числом цилиндров, мощностью.Создать необходимые методы и свойства. Создать перегруженные методы SetParams, для установки параметров автомобиля. \n - Использовать базовый класс Саr (машина), характеризуемый торговой маркой (строка), числом цилиндров, мощностью.Разработать операции для определения крутости машин.Машина считается круче, если у одной машины количество цилиндров и мощность больше чем у другой машины или при равенстве одного из параметров второй параметр больше.Разработать операцию увеличение мощности на 1. ", "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void IncreasePower_Click(object sender, RoutedEventArgs e)
        {
            if (firstCar.IsChecked == true)
            {
                carNumberOne++;
                power.Text = carNumberOne.Power.ToString();
            }
            if (secondCar.IsChecked == true)
            {
                carNumberTwo++;
                power.Text = carNumberTwo.Power.ToString();
            }
            parameterOutput.Text = carNumberOne.ShowInformation() + "\n \n" + carNumberTwo.ShowInformation();
        }

        private void Comparison_Click(object sender, RoutedEventArgs e)
        {
            if (carNumberOne > carNumberTwo)
            {
                MessageBox.Show("Первая машина круче второй", "Итог сравнения", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (carNumberOne < carNumberTwo)
            {
                MessageBox.Show("Вторая машина круче первой", "Итог сравнения", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Уровень крутости машинок равный", "Итог сравнения", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void FirstCar_Checked(object sender, RoutedEventArgs e)
        {
            numberCylinders.Clear();
            tredemark.Clear();
            power.Clear();
        }

        private void SecondCar_Checked(object sender, RoutedEventArgs e)
        {
            numberCylinders.Clear();
            tredemark.Clear();
            power.Clear();
        }
    }
}
