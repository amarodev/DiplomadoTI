﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaganaSoft.BuscadorIO.Models
{
    public class FoundsCollection : ObservableCollection<FoundFile>
    {

    }

    public class ErrorsCollection : ObservableCollection<ErrorEventArgs>
    {
    }
}
