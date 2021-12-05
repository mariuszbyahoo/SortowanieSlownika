using System;
using System.Collections.Generic;

namespace SortowanieSlownika.DAL
{
    public interface IDictionaryRepo
    {
        IDictionary<string, string> GetAll();
    }
}
