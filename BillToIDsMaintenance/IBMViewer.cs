using BillToIDsMaintenance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillToIDsMaintenance
{
    public interface IBMViewer
    {
        void Show(BMViewModel viewModel);
    }
}
