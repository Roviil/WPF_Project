using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiDesktopApp1.interfaces;
using UiDesktopApp1.Models;

namespace UiDesktopApp1.Services
{
    internal class GangnamguPopulationService : IDatabase<GangnamguPopulation>
    {

        private readonly WpfProjectDatabaseContext? _wpfProjectDatabaseContext;

        public GangnamguPopulationService(WpfProjectDatabaseContext wpfProjectDatabaseContext)
        {
            this._wpfProjectDatabaseContext = wpfProjectDatabaseContext;
        }
        public void Create(GangnamguPopulation entity)
        {
            this._wpfProjectDatabaseContext?.GangnamguPopulations.Add(entity);
            this._wpfProjectDatabaseContext?.SaveChanges();
        }

        public void Delete(int id)
        {
            var validData = this._wpfProjectDatabaseContext?.GangnamguPopulations.FirstOrDefault(x => x.Id == id);
            if (validData != null)
            {
                this._wpfProjectDatabaseContext?.GangnamguPopulations.Remove(validData);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public List<GangnamguPopulation>? Get()
        {
            return this._wpfProjectDatabaseContext?.GangnamguPopulations.ToList();
        }

        public GangnamguPopulation? GetDetail(int id)
        {
            var validData = this._wpfProjectDatabaseContext?.GangnamguPopulations.FirstOrDefault(x => x.Id == id);
            if(validData != null)
            {
                return validData;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void Update(GangnamguPopulation entity)
        {
            this._wpfProjectDatabaseContext?.GangnamguPopulations.Update(entity);
            this._wpfProjectDatabaseContext?.SaveChanges();
        }
    }
}
