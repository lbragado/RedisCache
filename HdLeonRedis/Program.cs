/*
Descripción: Ejercicio Redis Caché 
La descripción del tutorial está en mi Documento de Google Drive Software/WorldRemit/Redis Cache documento: Héctor de León - Utilizar Redis en C# .Net, guardar información en memoria

1. Descargar e instalar Chocolatey 
2. Instalar paquete StackExchange.Redis
3. Crear clase RedisDB

 */

using System;
using StackExchange.Redis;

namespace HdLeonRedis
{
    class Program
    {
        static void Main(string[] args)
        {

            //Llamamos a la Base de Datos de Redis
            var redisDataBase = RedisDB.Connection.GetDatabase(); 

            //Set de key-valor
            redisDataBase.StringSet("4", "Test 4");

            //Get de key-valor
            var valor = redisDataBase.StringGet("4"); 
            Console.WriteLine($"El valor es: { valor}");

            //Eliminar key
            if(redisDataBase.KeyExists("1"))
                redisDataBase.KeyDelete("1");   //Eliminar
        }
    }

    public class RedisDB
    {
        //Laizy nos permitirá hacer la creación de objetos grandes
        private static Lazy<ConnectionMultiplexer> _lazyConnection;

        public static ConnectionMultiplexer Connection
        {
            get
            {
                return _lazyConnection.Value;
            }
        }
        static RedisDB()
        {
            _lazyConnection = new Lazy<ConnectionMultiplexer>(()=>
                ConnectionMultiplexer.Connect("localhost")   //A dónde nos vamos a conectar
            );
        }
    }
}
