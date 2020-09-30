using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using Microsoft.EntityFrameworkCore;

namespace Lab_8.Models
{
    public class TelephoneContext : DbContext, IPhoneDictionary
    {
        public DbSet<Telephone> Telephones { get; set; }
        public TelephoneContext(DbContextOptions<TelephoneContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public Telephone SelectOne(int id)
        {
            var telephones = this.Telephones.ToList();
            int index = telephones.IndexOf(telephones.Find(x => x.Id == id));
            if (index != -1)
            {
                return telephones[index];
            }
            else
            {
                return new Telephone();
            }
        }

        public List<Telephone> Select()
        {
            var telephones = this.Telephones;
            return telephones.OrderBy(t => t.Surname).ToList();
        }

        public void Insert(string surname, int number)
        {
            this.Telephones.Add(new Telephone { Surname = surname, Number = number });
            this.SaveChanges();
        }

        public void Update(int id, string surname, int number)
        {
            var telephones = this.Telephones.ToList();
            int index = telephones.IndexOf(telephones.Find(x => x.Id == id));
            if (index != -1)
            {
                telephones[index].Surname = surname;
                telephones[index].Number = number;
                this.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var telephones = this.Telephones.ToList();
            Telephone removed = telephones.Find(x => x.Id == id);
            if (removed != null)
            {
                this.Telephones.Remove(removed);
                this.SaveChanges();
            }
        }
    }
}
