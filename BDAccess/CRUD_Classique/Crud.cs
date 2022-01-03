using System;
using Microsoft.Data.SqlClient;
namespace CRUD_Classique
{
    class Crud
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

                // Insertion dans la table Cours
                /*
                Console.WriteLine("Donner le libellé du Cours");
                String libelle = Console.ReadLine();
                
                Console.WriteLine("Donner le VH du Cours");
                int vh = int.Parse(Console.ReadLine());

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connexion;
                cmd.CommandText = "INSERT INTO Cours(Libelle,Vh) VALUES(@libelle,@vh)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@libelle", libelle);
                cmd.Parameters.AddWithValue("@vh", vh);
            
                cmd.ExecuteNonQuery();
                */

                // Insertion dans la table Etudiants

                /*
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connexion;
                cmd.CommandText = "INSERT INTO Etudiants(Nom,Age,Niveau) VALUES(@nom,@age,@niveau)";
                cmd.Prepare();

           
                cmd.Parameters.AddWithValue("@nom", "sami");
                cmd.Parameters.AddWithValue("@age", "26");
                cmd.Parameters.AddWithValue("@niveau", "Ingenieur");



                cmd.ExecuteNonQuery();
                */
                //****************************************************************************/


                // Suppression de la table articles

                /*
                     SqlCommand cmd = new SqlCommand();
                     cmd.Connection = connexion;
                     cmd.CommandText = "DELETE FROM Etudiants WHERE Id=@id";
                     cmd.Prepare();
                     cmd.Parameters.AddWithValue("@id", "4");
                     cmd.ExecuteNonQuery();
                 */

                //****************************************************************************/



                // Update de la table articles
                /*
                Console.WriteLine("Donner le nouveau libellé du Cours 1");
                String newLibelle = Console.ReadLine();

                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = connexion;
                cmd3.CommandText = "UPDATE Cours Set Libelle=@newLibelle where Id=@id";
                cmd3.Prepare();
                cmd3.Parameters.AddWithValue("@newLibelle", newLibelle);
                cmd3.Parameters.AddWithValue("@id", 1);
                cmd3.ExecuteNonQuery();*/
                
                //****************************************************************************/

                // requeste SELECT
                string stm = "SELECT Libelle, Vh FROM Cours";
                // On crée la commande
                SqlCommand cmd2 = new SqlCommand(stm, connexion);
                // On crée la reader pour contenir le résultat de la commande (requete SELECT)
                rdr = cmd2.ExecuteReader();

                //Console.WriteLine("{0}:{1}:{2}", rdr.GetName(0), rdr.GetName(1), rdr.GetName(2));
                Console.WriteLine("{0}:{1}", rdr.GetName(0), rdr.GetName(1));
                while (rdr.Read())
                {
                    //Console.WriteLine(rdr.GetInt32(0) + ":" + rdr.GetString(1) + ":" + rdr.GetInt32(2));
                    Console.WriteLine( rdr.GetString(0) + ":" + rdr.GetInt32(1));
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
