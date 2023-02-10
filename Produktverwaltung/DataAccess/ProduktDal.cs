using Produktverwaltung.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produktverwaltung.DataAccess
{
    /// <summary>Data Access Layer class <c>ProductDal</c>
    /// reads and writes in Products table.</summary>
    public static class ProduktDal
    {
        static SqlConnection con;

        /// <summary>Static constructor for the <c>ProductDal</c>
        /// class. Login data retrieved from <c>App.config</c>
        /// file.</summary>
        static ProduktDal()
        {
            con = ProduktDb.SqlConnection("SqlServer");
            con.Open();
        }

        /// <summary>Method <c>GetAll()</c> returns a list with
        /// all entries in table.
        /// <example>Example usage:
        /// <code>
        /// List<Produkt> db = ProduktDal.GetAll();
        /// </code>
        /// Results in having a list with all data
        /// retrived from table.
        /// </example>
        /// </summary>
        public static List<Produkt> GetAll()
        {
            List<Produkt> list = new List<Produkt>();
            string sql = $@"SELECT * FROM Produkt";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Produkt eintrag = new Produkt();
                    // Mapping:
                    eintrag.ProduktId = int.Parse(rd["ProduktId"].ToString());
                    eintrag.Name = rd["Name"].ToString();
                    eintrag.Beschreibung = rd["Beschreibung"].ToString();
                    eintrag.Kategorie = rd["Kategorie"].ToString();
                    eintrag.MengeProEinheit = int.Parse(rd["MengeProEinheit"].ToString());
                    eintrag.PreisProEinheit = float.Parse(rd["PreisProEinheit"].ToString());
                    eintrag.EinheitAufLager = int.Parse(rd["EinheitAufLager"].ToString());
                    eintrag.EinheitVorbestellt = int.Parse(rd["EinheitVorbestellt"].ToString());
                    eintrag.NachbestellungsStufe = int.Parse(rd["NachbestellungsStufe"].ToString());
                    eintrag.ProduktionEingestellt = rd["ProduktionEingestellt"].ToString();
                    list.Add(eintrag);
                }
                rd.Close();
            }
            return list;
        }

        /// <summary>Method <c>Get(int id)</c> returns an entry
        /// related to the given parameter <c>int id</c>.
        /// <example>Example usage:
        /// <code>
        /// Produkt eintrag = null;
        /// eintrag = ProduktDal.Get(id);
        /// </code>
        /// Results in having the requested entry.
        /// </example>
        /// </summary>
        public static Produkt Get(int id)
        {
            Produkt eintrag = null;
            string sql = $@"SELECT * FROM Produkt WHERE ProduktId=@ProduktId";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ProduktId", id);

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    eintrag = new Produkt();
                    // Mapping:
                    eintrag.ProduktId = int.Parse(rd["ProduktId"].ToString());
                    eintrag.Name = rd["Name"].ToString();
                    eintrag.Beschreibung = rd["Beschreibung"].ToString();
                    eintrag.Kategorie = rd["Kategorie"].ToString();
                    eintrag.MengeProEinheit = int.Parse(rd["MengeProEinheit"].ToString());
                    eintrag.PreisProEinheit = float.Parse(rd["PreisProEinheit"].ToString());
                    eintrag.EinheitAufLager = int.Parse(rd["EinheitAufLager"].ToString());
                    eintrag.EinheitVorbestellt = int.Parse(rd["EinheitVorbestellt"].ToString());
                    eintrag.NachbestellungsStufe = int.Parse(rd["NachbestellungsStufe"].ToString());
                    eintrag.ProduktionEingestellt = rd["ProduktionEingestellt"].ToString();
                }
                rd.Close();
            }
            return eintrag;
        }

        /// <summary>Method <c>Add(Produkt eintrag)</c> adds
        /// a product</c>.
        /// <example>Example usage:
        /// <code>
        /// int id = 0;
        /// id = ProduktDal.Add(eintrag);
        /// </code>
        /// Results in having the requested entry added.
        /// </example>
        /// </summary>
        public static int Add(Produkt eintrag)
        {
            int id = 0;
            string sql = $@"
INSERT INTO Produkt(Name,Beschreibung,Kategorie,MengeProEinheit,PreisProEinheit,EinheitAufLager,EinheitVorbestellt, NachbestellungsStufe,ProduktionEingestellt) 
output INSERTED.ProduktId VALUES(@Name,@Beschreibung,@Kategorie,@MengeProEinheit,@PreisProEinheit,@EinheitAufLager,@EinheitVorbestellt,@NachbestellungsStufe,@ProduktionEingestellt)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ProduktId", eintrag.ProduktId);
                cmd.Parameters.AddWithValue("@Name", eintrag.Name);
                cmd.Parameters.AddWithValue("@Beschreibung", eintrag.Beschreibung);
                cmd.Parameters.AddWithValue("@Kategorie", eintrag.Kategorie);
                cmd.Parameters.AddWithValue("@MengeProEinheit", eintrag.MengeProEinheit);
                cmd.Parameters.AddWithValue("@PreisProEinheit", eintrag.PreisProEinheit);
                cmd.Parameters.AddWithValue("@EinheitAufLager", eintrag.EinheitAufLager);
                cmd.Parameters.AddWithValue("@EinheitVorbestellt", eintrag.EinheitVorbestellt);
                cmd.Parameters.AddWithValue("@NachbestellungsStufe", eintrag.NachbestellungsStufe);
                cmd.Parameters.AddWithValue("@ProduktionEingestellt", eintrag.ProduktionEingestellt);
                id = (int)cmd.ExecuteScalar();
            }
            return id;
        }

        /// <summary>Method <c>Update(Produkt eintrag)</c> updates
        /// data of a product</c>.
        /// <example>Example usage:
        /// <code>
        /// int anzahl = -1;
        /// anzahl = ProduktDal.Update(eintrag);
        /// </code>
        /// Results in having the requested entry updated.
        /// </example>
        /// </summary>
        public static int Update(Produkt eintrag)
        {
            int anzahl = -1; // initialwert
            string sql = $@"UPDATE Produkt SET 
Name=@Name, Beschreibung=@Beschreibung, Kategorie=@Kategorie, 
MengeProEinheit=@MengeProEinheit, PreisProEinheit=@PreisProEinheit, EinheitAufLager=@EinheitAufLager, EinheitVorbestellt=@EinheitVorbestellt
, NachbestellungsStufe=@NachbestellungsStufe, ProduktionEingestellt=@ProduktionEingestellt
WHERE ProduktId=@ProduktId
";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ProduktId", eintrag.ProduktId);
                cmd.Parameters.AddWithValue("@Name", eintrag.Name);
                cmd.Parameters.AddWithValue("@Beschreibung", eintrag.Beschreibung);
                cmd.Parameters.AddWithValue("@Kategorie", eintrag.Kategorie);
                cmd.Parameters.AddWithValue("@MengeProEinheit", eintrag.MengeProEinheit);
                cmd.Parameters.AddWithValue("@PreisProEinheit", eintrag.PreisProEinheit);
                cmd.Parameters.AddWithValue("@EinheitAufLager", eintrag.EinheitAufLager);
                cmd.Parameters.AddWithValue("@EinheitVorbestellt", eintrag.EinheitVorbestellt);
                cmd.Parameters.AddWithValue("@NachbestellungsStufe", eintrag.NachbestellungsStufe);
                cmd.Parameters.AddWithValue("@ProduktionEingestellt", eintrag.ProduktionEingestellt);
                anzahl = cmd.ExecuteNonQuery();
            }
            return anzahl;
        }

        /// <summary>Method <c>Delete(Produkt eintrag)</c> deletes
        /// a product</c>.
        /// <example>Example usage:
        /// <code>
        /// int anzahl = -1;
        /// anzahl = ProduktDal.Delete(eintrag);
        /// </code>
        /// Results in having the requested entry deleted.
        /// </example>
        /// </summary>
        public static int Delete(Produkt eintrag)
        {
            int anzahl = -1;
            string sql = $@"DELETE Produkt WHERE ProduktId=@ProduktId";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ProduktId", eintrag.ProduktId);
                anzahl = cmd.ExecuteNonQuery();
            }
            return anzahl;
        }

    }
}
