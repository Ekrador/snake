using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char symb;

        Random random = new Random();
        
        public FoodCreator(int mapWidht, int mapHeight, char symb)
        {
            this.mapHeight = mapHeight;
            this.mapWidht = mapWidht;
            this.symb = symb;
        }
        
        public Point CreateFood()
        {
           
                int x = random.Next(2, mapWidht - 2);
                int y = random.Next(2, mapHeight - 2);
          
            return new Point(x, y, symb);
        }
    }
}
