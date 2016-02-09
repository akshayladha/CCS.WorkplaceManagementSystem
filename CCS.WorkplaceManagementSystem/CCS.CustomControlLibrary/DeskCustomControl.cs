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
using CCS.WorkplaceManagementSystem.Models;

namespace CCS.CustomControlLibrary
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CCS.CustomControlLibrary"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CCS.CustomControlLibrary;assembly=CCS.CustomControlLibrary"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:DeskCustomControl/>
    ///
    /// </summary>
    public class DeskCustomControl : Control
    {
        public Machine UserMachine
        {
            get { return (Machine)GetValue(UserMachineProperty); }
            set { SetValue(UserMachineProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserMachineProperty =
            DependencyProperty.Register("UserMachine", typeof(Machine), typeof(DeskCustomControl), new PropertyMetadata(null));



        public MachinePosition MachinePosition
        {
            get { return (MachinePosition)GetValue(MachinePositionProperty); }
            set { SetValue(MachinePositionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MachinePositionProperty =
            DependencyProperty.Register("MachinePosition", typeof(MachinePosition), typeof(DeskCustomControl), new PropertyMetadata(MachinePosition.TopRight));



        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(DeskCustomControl), new PropertyMetadata(null));



        static DeskCustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DeskCustomControl), new FrameworkPropertyMetadata(typeof(DeskCustomControl)));
        }
    }
}
