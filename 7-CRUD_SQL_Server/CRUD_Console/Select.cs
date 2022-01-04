using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace CRUD_Console
{
    class Select
    {
        static void Main(string[] args)
        {
            SqlDataReader rdr = null;
            SqlConnection connexion = null;

            string connectionString = null;
            try
            {
                // connexion 
                connectionString = ConfigurationManager.ConnectionStrings["dbSqlServer"].ConnectionString;
                 //@"Data Source=(localdb)\V11.0;Initial Catalog=Esprit;"
                // + "Integrated Security=SSPI;";
                // ConfigurationManager.ConnectionStrings["dbSqlServer"].ConnectionString;
                connexion = new SqlConnection(connectionString);
                connexion.Open();


                // requeste SELECT
                string stm = "SELECT * FROM Etudiants";

                // On crée la commande
                SqlCommand cmd = new SqlCommand(stm, connexion);
                // On crée la reader pour contenir le résultat de la commande (requete SELECT)
                rdr = cmd.ExecuteReader();


                Console.WriteLine("{0}:{1}:{2}:{3}", rdr.GetName(0), rdr.GetName(1), rdr.GetName(2), rdr.GetName(3));

                while (rdr.Read())
                {
                    Console.WriteLine(rdr.GetInt32(0) + ":" + rdr.GetString(1)+ ":" + rdr.GetInt32(2)+ ":" + rdr.GetString(3));
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur de configuration : {0}", e.Message);

            }


            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (connexion != null)
                {
                    connexion.Close();
                }
            }
            Console.ReadLine();

        }
    }
}
