using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSingleton.Models
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {
            // Constructor privado para evitar instanciación directa
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public string GetMessage()
        {
            return "¡Hola desde el servicio Singleton!";
        }

        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}