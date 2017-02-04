using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class GlobalV
    {

        private string[] filesArrayC;




        //Get files array
        public string[] getFilesArray()
        {
            return this.filesArrayC;
        }

        public string getFilesArrayIndex(int index)
        {
            return this.filesArrayC[index];

        }

        //Set files array
        public void setFilesArray(string[] filesArray)
        {
            this.filesArrayC = filesArray;
        }


    }

