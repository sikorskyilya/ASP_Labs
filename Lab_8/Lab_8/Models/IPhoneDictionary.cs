using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_8.Models
{
    public interface IPhoneDictionary
    {
        Telephone SelectOne(int id);
        List<Telephone> Select();
        void Insert(string surname, int number);
        void Update(int id, string surname, int number);
        void Delete(int id);
    }
}
