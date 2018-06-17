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
using System.Xml;

namespace HW_Module_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /*
     
         */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            XmlElement root = doc.CreateElement("Questions");

            XmlElement q = doc.CreateElement("Question");
            q.InnerText = tbQuestion.Name + " - " +
                ((ComboBoxItem)cmNumber.SelectedValue).Content + "Бал:" + numm;

            root.AppendChild(q);
            doc.AppendChild(root);

            doc.Save("Questions.xml");
          
        }

        public static int numm;
    
        private void cmNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string tes = ((ComboBoxItem)((ComboBox)sender).SelectedValue)
                        .Content.ToString();

             MessageBox.Show(tes);

            if (tes == "a)")
                numm = numm + 5;
            else if (tes == "b)")
                numm = numm + 5;
            else if (tes == "c)")
                numm = numm + 5;
            else if (tes == "d)")
                numm = numm + 5;
            else
            numm = numm + 0;
        }

        private void cmNumber2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string tes = ((ComboBoxItem)((ComboBox)sender).SelectedValue)
                        .Content.ToString();

            MessageBox.Show(tes);

            if (tes == "a)")
                numm = numm + 5;
            else
                numm = numm + 0;

        }
        private void cmNumber3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string tes = ((ComboBoxItem)((ComboBox)sender).SelectedValue)
                        .Content.ToString();

            MessageBox.Show(tes);

            if (tes == "a)")
                numm = numm + 5;
            else
                numm = numm + 0;
        }
        private void cmNumber4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string tes = ((ComboBoxItem)((ComboBox)sender).SelectedValue)
                        .Content.ToString();

            MessageBox.Show(tes);

            if (tes == "c)")
                numm = numm + 5;
            else
                numm = numm + 0;
        }
        private void cmNumber5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string tes = ((ComboBoxItem)((ComboBox)sender).SelectedValue)
                        .Content.ToString();

            MessageBox.Show(tes);
            if (tes == "a)")
                numm = numm + 5;
            else
                numm = numm + 0;
        }

      
    }
}
