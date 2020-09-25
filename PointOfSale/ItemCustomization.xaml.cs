using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ItemCustomization.xaml
    /// </summary>
    public partial class ItemCustomization : UserControl
    {
        /// <summary>
        /// Initializes this component.
        /// </summary>
        public ItemCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Changes the visibility of all check boxes and most buttons to collapsed. The finishedButton is hidden and disabled.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void finishedButton_Click(object sender, RoutedEventArgs e)
        {
            customizeMeal.Visibility = Visibility.Collapsed;
            customizeDrink.Visibility = Visibility.Collapsed;
            customizeSide.Visibility = Visibility.Collapsed;
            chooseButton.Visibility = Visibility.Collapsed;
            bunCheckBox.Visibility = Visibility.Collapsed;
            ketchupCheckBox.Visibility = Visibility.Collapsed;
            mustardCheckBox.Visibility = Visibility.Collapsed;
            pickleCheckBox.Visibility = Visibility.Collapsed;
            cheeseCheckBox.Visibility = Visibility.Collapsed;
            tomatoCheckBox.Visibility = Visibility.Collapsed;
            lettuceCheckBox.Visibility = Visibility.Collapsed;
            mayoCheckBox.Visibility = Visibility.Collapsed;
            broccoliCheckBox.Visibility = Visibility.Collapsed;
            mushroomsCheckBox.Visibility = Visibility.Collapsed;
            cheddarCheckBox.Visibility = Visibility.Collapsed;
            sirloinCheckBox.Visibility = Visibility.Collapsed;
            onionCheckBox.Visibility = Visibility.Collapsed;
            rollCheckBox.Visibility = Visibility.Collapsed;
            sausageLinkCheckBox.Visibility = Visibility.Collapsed;
            eggCheckBox.Visibility = Visibility.Collapsed;
            hashbrownCheckBox.Visibility = Visibility.Collapsed;
            pancakeCheckBox.Visibility = Visibility.Collapsed;
            baconCheckBox.Visibility = Visibility.Collapsed;
            iceCheckBox.Visibility = Visibility.Collapsed;
            creamCheckBox.Visibility = Visibility.Collapsed;
            decafCheckBox.Visibility = Visibility.Collapsed;
            lemonCheckBox.Visibility = Visibility.Collapsed;
            nuffSaidButton.Visibility = Visibility.Collapsed;
            sizeListBox.Visibility = Visibility.Collapsed;
            sodaFlavorListBox.Visibility = Visibility.Collapsed;
            finishedButton.Visibility = Visibility.Hidden;
            finishedButton.IsEnabled = false;
        }

        private void nuffSaidButton_Click(object sender, RoutedEventArgs e) {} // Created this on accident. This button will always be disabled.
    }
}
