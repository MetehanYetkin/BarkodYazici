using Bussiness.Concrate;
using DataAccess.EntityFramework;
using Entities.Concrate;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MakaraTest();
        }
        private static void MakaraTest() 
        {
            Makara _makara;
           _makara =   new Makara { BarkodNo = "20017ABD001" ,MakaraTipi=7,MaxKullanimAdedi=10
            ,KullanimAdedi=3,KullanimDisi=0} ;

            MakaraManager makaraManager = new MakaraManager(new EfMakaraDal());

            makaraManager.Add(_makara);
            
           // Console.WriteLine("GetAlla girdi"+ makaraManager.GetAll()); 
        }
    }
}
