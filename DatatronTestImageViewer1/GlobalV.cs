using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class GlobalV
    {
      
        

        private static string[] filesArrayC;
        private static int CURRENT_INDEX;

        //Get files array
        public static string[] getFilesArray()
        {
            return filesArrayC;
        }

        public static string getFilesArrayIndex(int index)
        {
            return filesArrayC[index];

        }

        //Set files array
        public static void setFilesArray(string[] filesArray)
        {
            filesArrayC = filesArray;
        }



        //Get Current Index
        public static int getCurrentIndex()
        {
            return CURRENT_INDEX;

        }

        //Set Current Index
        public static void setCurrentIndex(int currentIndex)
        {
            CURRENT_INDEX = currentIndex;

        }

        //get Files No
        public static string getFileNo()
        {
            return ("" + (getCurrentIndex() + 1));
        }









}

