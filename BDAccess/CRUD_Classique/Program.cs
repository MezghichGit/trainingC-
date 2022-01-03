using System;
using Microsoft.Data.SqlClient;
namespace CRUD_Classique
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataReader rdr = null;
            SqlConnection connexion = null;

            string connectionString = null;
            try
            {
                 connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bdecole;"
                 + "Integrated Security=SSPI;";
              
                connexion = new SqlConnection(connectionString);
                connexion.Open();


                // requeste SELECT
                string stm = "SELECT * FROM Etudiants"; // requette SQL

                // On crée la commande
                SqlCommand cmd = new SqlCommand(stm, connexion);
                // On crée la reader pour contenir le résultat de la commande (requete SELECT)
                rdr = cmd.ExecuteReader();


                Console.WriteLine("{0}:{1}:{2}:{3}", rdr.GetName(0), rdr.GetName(1), rdr.GetName(2), rdr.GetName(3));

                while (rdr.Read())
                {
                    Console.WriteLine(rdr.GetInt32(0) + ":" + rdr.GetString(1) + ":" + rdr.GetInt32(2) + ":" + rdr.GetString(3));
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
