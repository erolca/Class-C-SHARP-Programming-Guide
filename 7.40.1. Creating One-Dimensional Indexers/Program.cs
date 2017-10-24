using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 Indexers are a syntactic convenience that enable you to create a class,
 struct, or interface that client applications can access just as an array.
 Indexers are most frequently implemented in types whose primary purpose is to encapsulate an internal collection or array.
 For example, suppose you have a class named TempRecord that represents 
 the temperature in Farenheit as recorded at 10 different times during a 24 hour period.
 The class contains an array named "temps" of type float to represent the temperatures, 
 and a DateTime that represents the date the temperatures were recorded. By implementing an indexer in this class, 
 clients can access the temperatures in a TempRecord instance as float temp = tr[4] instead of as float temp = tr.temps[4]. The indexer notation not only simplifies the syntax for client applications;
 it also makes the class and its purpose more intuitive for other developers to understand.
     
     
     
     */
//A one-dimensional indexer has this general form:
//Genel Yapı 

class Myclass
{

   /* element-type*/ public int  this[int index]
    {
        // The get accessor.
        get
        {
            return 0;
            // return the value specified by index 
        }

        // The set accessor.
        set
        {
            // set the value specified by index 
        }
    }


}


class Program
    {
        static void Main(string[] args)
        {
        }
    }

