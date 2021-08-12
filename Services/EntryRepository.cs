using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using triatlon.Data;

namespace triatlon.Services
{
    public class EntryRepository 
    {
        private readonly ApplicationDbContext _db;
        public EntryRepository(ApplicationDbContext db)
        {
            this._db = db;
        }

        public void AddTime(int number, DateTime time)
        {
            var entry = this._db.Entries
                .Include(t => t.Times)
                .FirstOrDefault(e => e.Number == number);

            if (entry is null) 
            {
                entry = new Entry 
                {
                    Number = number,
                    Times = new List<Time>()
                };
            }

            entry.Times.Add(new Time { Value = time });
            this._db.Entries.Update(entry);
            this._db.SaveChanges();
        }

        public void DeleteTime(Guid id)
        {
            var time = this._db.Times.FirstOrDefault(t => t.Id == id);
            this._db.Times.Remove(time);
            this._db.SaveChanges();
        }

        public void UpdateName(Guid id, string name)
        {
            var entry = this._db.Entries.FirstOrDefault(e => e.Id == id);
            entry.Name = name;
            this._db.SaveChanges();
        }

        public List<Entry> GetAll() => this._db.Entries.Include(t => t.Times).ToList();
    }
}