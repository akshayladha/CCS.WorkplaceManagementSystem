﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace CCS.WorkplaceManagementSystem
{
    class StatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (MachineStatus)value;

            switch (status)
            {
                case MachineStatus.Active: return Brushes.Green;
                case MachineStatus.Away: return Brushes.Yellow;
                case MachineStatus.Shutdown: return Brushes.Red;
                default: return Brushes.Gray;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
