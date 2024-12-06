using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogicaBenner
{
    public class Network
    {
        private int[] parent;
        private int[] rank;

        public Network(int size)
        {
            if (size <= 0)
            {
                throw new NegativeNumberException();
            }

            parent = new int[size + 1];
            rank = new int[size + 1];

            for (int i = 0; i < size; i++) 
            { 
                parent[i] = i;
                rank[i] = 0;
            }
        }

        public int Find(int xy) {
            if (parent[xy] != xy)
            {
                parent[xy] = Find(parent[xy]);
            }
            return parent[xy];
        }

        public void Connect(int x, int y) {

            if (x <= 0 || y <= 0)
            {
                throw new NegativeNumberException();
            }


            int rootX = Find(x);
            int rootY = Find(y);

            if (rootX == rootY) 
            {
                return;
            }

            if (rank[rootX] > rank[rootY])
            {
                parent[rootY] = rootX;
            }
            else if (rank[rootX] < rank[rootY])
            {
                parent[rootX] = rootY;
            }
            else
            {
                parent[rootY] = rootX;
                rank[rootX]++;
            }
        }

        public bool Query (int x, int y) 
        {
            if (x <= 0 || y <= 0)
            {
                throw new NegativeNumberException();
            }

            return Find(x) == Find(y);
        }
    }
}
