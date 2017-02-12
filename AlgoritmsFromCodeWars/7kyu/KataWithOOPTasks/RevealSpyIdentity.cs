﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu.KataWithOOPTasks
{
    public class RevealSpyIdentity
    {
        public static string FindHisIdentity(Human person)
        {
            if (person.GetType() == typeof(Police))
            {
                return person.Name + " is a Police";
            }
            if (person.GetType() == typeof(Spy))
            {
                return person.Name + " is a Spy";
            }
            return person.Name + " is a Human";
        }

        public static string FindHisIdentity2(Human person)
        {
            return $"{person.Name} is a {person.GetType().Name}";
        }

        public static string FindHisIdentity3(Human person)
        {
            string id;
            if (person is Police) id = "Police"; else id = "Spy";
            return string.Format("{0} is a {1}", person.Name, id);
        }

    }

    public class Human
    {
        public string Name { get; set; }
    }

    public class Police : Human
    {
    }

    public class Spy : Human
    {
    }
}
