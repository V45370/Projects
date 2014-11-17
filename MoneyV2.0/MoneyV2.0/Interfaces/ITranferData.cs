using System;
using System.Linq;
using MoneyV2._0.Models;

namespace MoneyV2._0.Interfaces
{
    public interface ITranferData
    {
        string GiveChilSourceSelected();

        DateTime GiveChildDateSelected();
        void GiveParentOutcomeSaved(string[] outcome);
    }
}
