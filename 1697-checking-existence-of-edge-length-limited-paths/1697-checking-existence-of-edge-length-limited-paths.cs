public class Solution
{
        private class Unions
        {
            private readonly int[] _parents;
            private readonly int[] _ranks;

            public Unions(int n)
            {
                _parents = new int[n];
                _ranks = new int[n];
                for (int i = 0; i < n; i++)
                {
                    _parents[i] = i;
                }
            }

            public int Find(int x)
            {
                if (x != _parents[x])
                {
                    x = Find(_parents[x]);
                }
                return _parents[x];
            }

            public bool Union(int x, int y)
            {
                int px = Find(x);
                int py = Find(y);
                if (px == py)
                {
                    return false;
                }
                if (_ranks[px] > _ranks[py])
                {
                    _parents[py] = px;
                    _ranks[px]++;
                }
                else
                {
                    _parents[px] = py;
                    _ranks[py]++;
                }
                return true;
            }
        }


        public bool[] DistanceLimitedPathsExist(int n, int[][] edgeList, int[][] queries)
        {
            bool[] res = new bool[queries.Length];
            (int idx, int[] q)[] qData = new (int idx, int[] q)[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                qData[i] = (i, queries[i]);
            }

            //sort edges by length
            Array.Sort(edgeList, (e1, e2) => e1[2].CompareTo(e2[2]));
            //sort queries by limit
            Array.Sort(qData, (q1, q2) => q1.q[2].CompareTo(q2.q[2]));
            Unions dsu = new Unions(n);

            int edIdx = 0;

            for (int i = 0; i < qData.Length; i++)
            {
                //add edges accodring to current limit
                while (edIdx < edgeList.Length && edgeList[edIdx][2] < qData[i].q[2])
                {
                    dsu.Union(edgeList[edIdx][0], edgeList[edIdx][1]);
                    edIdx++;
                }

                res[qData[i].idx] = (dsu.Find(qData[i].q[0]) == dsu.Find(qData[i].q[1]));
            }

            return res;
        }
    }