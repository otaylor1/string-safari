using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSafari
{
    public class SafariGuide
    {
        /// <summary>
        /// Looks for a baby zebra in <paramref name="str"/>.
        /// <para>A baby zebra is "zebra", all lowercase.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has "zebra" in it, false otherwise</returns>
        public static bool HasBabyZebra(string str)

        {
            // TODO

            

            if (str.Contains("zebra"))
            {
                return true;
            }
            else
            {
                return false;
            }

            // return str.Contains("zebra");
            //also works and is prob prefered
        }

        /// <summary>
        /// Looks for an adult zebra in <paramref name="str"/>.
        /// <para>An adult zebra is "ZEBRA", all uppercase.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has "ZEBRA" in it, false otherwise</returns>
        public static bool HasAdultZebra(string str)
        {
            // TODO

            if (str.Contains("ZEBRA"))
            {
                return true;
            }
            else
            {
                return false;
            }



            //return str.Contains("ZEBRA");
            //also works and is prob prefered
        }

        /// <summary>
        /// Looks for a zebra in <paramref name="str"/>.
        /// <para>A zebra is the letters "ZEBRA", in any case combination (upper or lower)</para>
        /// <para>"Zebra", "zebra", "ZEBRA", and "ZeBrA" are all valid examples of zebras.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has a zebra in it, false otherwise</returns>
        public static bool HasZebra(string str)
        {
            // TODO

           string newString = str.ToLower();
            return HasBabyZebra(newString);

            //HasBabyZebra(str.ToLower());

            // return str.ToLower().Contains("zebra")
            
            //both are also ways to write it

        }

        /// <summary>
        /// Looks for at least two zebras in <paramref name="str"/>.
        /// <para>A zebra is defined as it is for the <see cref="HasZebra(string)"/> method.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has at least two zebras in it, false otherwise</returns>
        public static bool HasADazzle(string str)
        {
            // TODO
            string newString = str.ToLower();
            int firstZebra = newString.IndexOf("zebra");
            int lastZebra = newString.LastIndexOf("zebra");
            

                if (firstZebra == lastZebra)
            {
                //only one zebra
                return false;
            }

            else
            {
                //at least 2 zebras
                return true;
            }
         
            
        }
    
        /// <summary>
        /// Looks for at least two lions in <paramref name="str"/>.
        /// <para>A lion is the letters "LION", in any case combination (upper or lower)</para>
        /// <para>"Lion", "lion", "LION", and "LiOn" are all valid examples of lions.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has at least two lions in it, false otherwise</returns>
        public static bool HasAPride(string str)
        {
            // TODO

            string newString = str.ToLower();
            int firstLion = newString.IndexOf("lion");
            int lastLion = newString.LastIndexOf("lion");


            if (firstLion == lastLion)
            {
                //only one lion
                return false;
            }

            else
            {
                //at least 2 lion
                return true;
            }
        }

        /// <summary>
        /// Looks for a pride of lions and only one zebra in <paramref name="str"/>.
        /// <para>If there are two or more zebras, this method should return false.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has at least two lions in it and just one zebra, false otherwise</returns>
        public static bool ThereWillBeBlood(string str)
        {
            // TODO

            if (HasAPride(str) && !HasADazzle(str))
            {
                return true;
            }
            else
            { return false;
            }
        }

        /// <summary>
        /// Looks for a lion and determines if the lion is far enough away for safety.
        /// <para>If there is no lion, this method returns true.</para>
        /// <para>If there is a lion at the start of the string, this method returns false.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if there is no lion at the start of the string</returns>
        public static bool SafeDistanceToLion(string str)
        {
            // TODO

            int firstLion = str.IndexOf("lion");
            int lastLion = str.LastIndexOf("lion");
            int numberOfLions = lastLion + firstLion;
            if (numberOfLions >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
