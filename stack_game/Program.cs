using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_game
{
    class Game
    {
        private List<string>[] stacks = new List<string>[5];

        public bool canplace(int n)
        {
            return true;
        }
        public bool cantake(int idx)
        {
            return stacks[idx].Count < 4;
        }
        public void add(int idx,string num)
        {
            stacks[idx].Add(num);
            return;
        }
        public void move(int idx1,int idx2)
        {
            string s1 = stacks[idx1][stacks[idx1].Count - 1];
            stacks[idx1].RemoveAt(stacks[idx1].Count - 1);

            stacks[idx2].Add(s1);
            return;
        }
        public bool cantake2(int idx)
        {
            return stacks[idx].Count > 0;
        }
        public int size(int idx)
        {
            return stacks[idx].Count;
        }
        public bool win()
        {
            int empty = 0,ok1 = 0,ok2 = 0,ok3 = 0;
            for(int i=1;i<=4;i++)
            {
                if (stacks[i].Count == 0) empty++;

                int one = 0, two = 0, three = 0;

                for (int k=0;k<stacks[i].Count;k++)
                {
                    if (stacks[i][k] == "1") one++;
                    else if (stacks[i][k] == "2") two++;
                    else if (stacks[i][k] == "3") three++;
                }

                if (stacks[i].Count == 3 && one == 3) ok1 = 1;
                if (stacks[i].Count == 3 && two == 3) ok2 = 1;
                if (stacks[i].Count == 3 && three == 3) ok3 = 1;
            }

            if (empty == 1 && ok1 == 1 && ok2 == 1 && ok3 == 1) return true;
            else return false;
        }
        public string output(int idx1,int idx2)
        {
            return stacks[idx1][idx2];
        }
        public void init()
        {
            for (int i = 0; i <= 4; i++)
            {
                stacks[i] = new List<string>();
            }
            return;
        }
    }
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
