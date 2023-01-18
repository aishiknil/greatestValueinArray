using System;
namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How may values you want to enter? ");
            int NumOfElements = Convert.ToInt32(Console.ReadLine());//number of elements to be passed in the array
            double[] arrGreat = new double[NumOfElements];  //creating array
            
            Console.WriteLine("Enter Values : ");
            for (int i = 0; i < NumOfElements; i++)    //taking array inputs
            {
                arrGreat[i] = Convert.ToDouble(Console.ReadLine());
            }


            //Print array elements
            // System.Console.WriteLine("You've entered: ");
            // foreach (var item in arrGreat)
            // {
            //     System.Console.Write( item+" | ");
            // }

            double dblGreat; //variable to store the greatest value
            dblGreat = arrGreat[0]; //initializing 
            // System.Console.WriteLine(dblGreat);

            for (int i = 0; i < NumOfElements; i++)
            {
                if (arrGreat[i] > dblGreat)
                    dblGreat = arrGreat[i];
            }
            Console.WriteLine("Greatest value : {0}", dblGreat);
        }
    }
}