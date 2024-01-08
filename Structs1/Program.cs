using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Structs1
{
    internal class Program
    {
        //unity example
        struct Vector3
        {
            public float x;
            public float y;
            public float z;

            public float Length()
            {
                return (float)Math.Sqrt(x*x + y*y + z*z);
            }
        }
        //pretty much unity Vector2
        struct Point2D
        {
            public int x;
            public int y;
        }


        static void Main(string[] args)
        {
            // unity struct example
            Vector3 position;
            position.x = 10.0f;
            position.y = 10.0f;
            position.z = 10.0f;

            Console.WriteLine(position.Length());

            Console.WriteLine("Hello World");
            Console.WriteLine();

            // no structs
            // no classes (objects)


            // player
            int health = 100;
            int shield = 100;
            //int playerX = 10;
            //int playerY = 10;
            Point2D playerPosition;
            playerPosition.x = 10;
            playerPosition.y = 10;

            // 1000 enemies
            int numEnemies = 1000;
            //int[] enemyX = new int[numEnemies];
            //int[] enemyY = new int[numEnemies];
            Point2D[] enemyPosition = new Point2D[numEnemies];
            for (int i = 0; i < numEnemies; i++)
            {
                enemyPosition[i].x = 10;
                enemyPosition[i].y = 10;
            }

            // pre structs 



            // pre classes (objects)

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
