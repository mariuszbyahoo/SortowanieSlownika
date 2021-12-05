using SortowanieSlownika.DAL;
using System;

namespace SortowanieSlownika
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new MockDictionaryRepo();

            var pairs = repo.GetAll();
        }
    }
}
