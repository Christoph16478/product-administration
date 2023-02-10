using Produktverwaltung.DataAccess;
using Produktverwaltung.Entities;
using Produktverwaltung.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Produktverwaltung.BusinessLogic
{
    /// <summary>Business Logic class <c>ProductManager</c>
    /// prepares and maipulates data from product table.</summary>
    public static class ProduktManager
    {
        /// <summary>Method <c>GetAll(Expression<Func<Produkt, bool >> filter = null)</c>
        /// returns a list with all entries in table.
        /// <example>Example usage:
        /// <code>
        /// List<Produkt> list = new List<Produkt>();
        /// list = ProduktDal.GetAll();
        /// </code>
        /// Returns list with all products.
        /// </example>
        /// </summary>
        public static List<Produkt> GetAll(Expression<Func<Produkt, bool >> filter = null)
        {
            List<Produkt> list = new List<Produkt>();
            list = ProduktDal.GetAll();
            if (filter != null)
            {
                list = list.AsQueryable().Where(filter).ToList();
            }
            return list;
        }

        /// <summary>Method <c>Get(int id)</c> returns entry
        /// according to the parameter <c>int id</c>.
        /// <example>Example usage:
        /// <code>
        /// Produkt eintrag = null;
        /// eintrag = ProduktDal.Get(id);
        /// </code>
        /// Results in getting back an entry with
        /// a specific identifier.
        /// </example>
        /// </summary>
        public static Produkt Get(int id)
        {
            Produkt eintrag = null;
            eintrag = ProduktDal.Get(id);
            return eintrag;
        }

        /// <summary>Method <c>Add(Produkt eintrag)</c>
        /// adds a product.
        /// <example>Example usage:
        /// <code>
        /// int id = 0;
        /// id = ProduktDal.Add(eintrag);
        /// return id;
        /// </code>
        /// Results in adding a product.
        /// </example>
        /// </summary>
        public static int Add(Produkt eintrag)
        {
            int id = 0;
            id = ProduktDal.Add(eintrag);
            return id;
        }

        /// <summary>Method <c>Add(Produkt eintrag)</c>
        /// manipulating data pf a product.
        /// <example>Example usage:
        /// <code>
        /// int anzahl = -1;
        /// anzahl = ProduktDal.Update(eintrag);
        /// return anzahl;
        /// return id;
        /// </code>
        /// Results in manipulating data of a product.
        /// </example>
        /// </summary>
        public static int Update(Produkt eintrag)
        {
            int anzahl = -1;
            anzahl = ProduktDal.Update(eintrag);
            return anzahl;
        }

        /// <summary>Method <c>Delete(Produkt eintrag)</c>
        /// delets an existing product.
        /// <example>Example usage:
        /// <code>
        /// int anzahl = -1;
        /// anzahl = ProduktDal.Delete(eintrag);
        /// return anzahl;
        /// </code>
        /// Results in deleting a product.
        /// </example>
        /// </summary>
        public static int Delete(Produkt eintrag)
        {
            int anzahl = -1;
            anzahl = ProduktDal.Delete(eintrag);
            return anzahl;
        }

        /// <summary>Method <c>Delete(int id)</c>
        /// delets an existing product.
        /// <example>Example usage:
        /// <code>
        /// int anzahl = -1;
        /// Produkt eintrag = Get(id);
        /// anzahl = Delete(eintrag);
        /// return anzahl;
        /// </code>
        /// Results in deleting a product according
        /// to its identifier.
        /// </example>
        /// </summary>
        public static int Delete(int id)
        {
            int anzahl = -1;
            Produkt eintrag = Get(id);
            anzahl = Delete(eintrag);
            return anzahl;
        }

        /// <summary>Method <c>GetAllProduktView()</c> updates
        /// view of product table.
        /// <example>Example usage:
        /// <code>
        /// List<Produkt> db = ProduktDal.GetAll();
        /// </code>
        /// Results in updated view of all products.
        /// </example>
        /// </summary>
        public static List<ProduktView> GetAllProduktView()
        {
            List<ProduktView> list = new List<ProduktView>();
            List<Produkt> db = ProduktDal.GetAll();
            foreach (var eintrag in db)
            {
                ProduktView neu = new ProduktView();
                // Mapping
                neu.ProduktId = eintrag.ProduktId;
                neu.Name = eintrag.Name;
                neu.Beschreibung = eintrag.Beschreibung;
                neu.Kategorie = eintrag.Kategorie;

                list.Add(neu);
            }
            return list;
        }
    }
}
