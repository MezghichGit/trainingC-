using System;

namespace Methods
{
    class Program
    {
        /*
         The ref is a keyword in C# which is used for the passing the arguments by a reference. Or we can say that if any changes made in this argument in the method will reflect in that variable when the control return to the calling method. 

         * */
        

        // StartService method.
        static void StartService(int upTime, bool shutdownAutomatically)
        {
            Console.WriteLine("Paramètres : " + upTime + " " + shutdownAutomatically);
        }


        static void StopService(bool forceStop, string serviceName = null, int serviceId = 1)
        {
            Console.WriteLine("Paramètres : " + forceStop + " " + serviceName + " " + serviceId);
        }


        public static void Main()
        {
            StopService(serviceId: 10, serviceName:"IA", forceStop:false);
            StopService(true,"Web");
            var upTime = 2000;
            var shutdownAutomatically = true;
            StartService(upTime, shutdownAutomatically);

            // Assign string value
            string str = "Formation";

            // Pass as a reference parameter
            SetValue(ref str);

            // Display the given string
            Console.WriteLine(str);
        }

        static void SetValue(ref string str1)
        {

            // Check parameter value
            if (str1 == "Formation")
            {
                Console.WriteLine("Hello!! C#");
            }

            // Assign the new value
            // of the parameter
            str1 = "Formation C#";
        }

        /*
        static public void Main()
        {

            // Declaring variable
            // without assigning value
            int G;

            // Pass variable G to the method
            // using out keyword
            Sum(out G);

            // Display the value G
            Console.WriteLine("The sum of" +
                    " the value is: {0}", G);
        }

        // Method in which out parameter is passed
        // and this method returns the value of
        // the passed parameter
        public static void Sum(out int G)
        {
            G = 80;
            G += G;
        }*/
    }
}
