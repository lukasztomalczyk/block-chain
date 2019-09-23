﻿using System;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockChain phillyCoin = new BlockChain();  
            phillyCoin.AddBlock(new Block(DateTime.Now, null, "{sender:Henry,receiver:MaHesh,amount:10}"));  
            phillyCoin.AddBlock(new Block(DateTime.Now, null, "{sender:MaHesh,receiver:Henry,amount:5}"));  
            phillyCoin.AddBlock(new Block(DateTime.Now, null, "{sender:Mahesh,receiver:Henry,amount:5}"));  
  
            Console.WriteLine(JsonConvert.SerializeObject(phillyCoin));

            
            Console.WriteLine($"Is Chain Valid: {phillyCoin.IsValid()}");  
  
            Console.WriteLine($"Update amount to 1000");  
            phillyCoin.Chain[1].Data = "{sender:Henry,receiver:MaHesh,amount:1000}";  
  
            Console.WriteLine($"Is Chain Valid: {phillyCoin.IsValid()}");  
            Console.ReadKey();
        }
    }
}
