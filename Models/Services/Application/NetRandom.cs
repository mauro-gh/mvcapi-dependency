using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace mvcapi.Models.Services.Application
{
    public class NetRandom : ITransientRandom,  IScopedRandom, ISingletonRandom
    {

        private int randomNumber;


        public NetRandom()
        {
            var rand = new Random();
            randomNumber= rand.Next(1,21);
        }

        public int GetRandomNumber()
        {
            return randomNumber;
        }
    }
}