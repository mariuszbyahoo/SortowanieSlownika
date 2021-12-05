using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortowanieSlownika.DAL
{
    public class MockDictionaryRepo : IDictionaryRepo
    {
        public IDictionary<string, string> GetAll()
        {
            var result = new Dictionary<string, string>();
            result.Add("Alicja", "Alojzy");
            result.Add("Bernadetta", "Błażej");
            result.Add("Cecylia", "Cezary");
            result.Add("Danuta", "Dariusz");
            result.Add("Ewa", "Eustachy");
            result.Add("Frombork", "Francja");
            result.Add("Genowefa", "Gienek");
            result.Add("Halina", "Heniek");
            result.Add("Izabela", "Irek");
            result.Add("Jolanta", "Janusz");
            result.Add("Klaudia", "Kamil");
            result.Add("Las", "Leśny");
            result.Add("Monika", "Mariusz");
            result.Add("Natalia", "Norbert");
            result.Add("Ola", "Olaf");
            result.Add("Patrycja", "Patrycjusz");
            result.Add("Renata", "Robert");
            result.Add("Teodora", "Tadeusz");
            result.Add("Urszula", "Ul");
            result.Add("Wiktoria", "Wikariusz");
            result.Add("Zenon", "Zaułek");
            return result;
        }
    }
}
