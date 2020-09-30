using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneInterface

{
    public interface IPhoneDictionary
    {
        List<Telephone> Select();
        void Insert(string surname, int number);
        void Update(int id, string surname, int number);
        void Delete(int id);
    }
}