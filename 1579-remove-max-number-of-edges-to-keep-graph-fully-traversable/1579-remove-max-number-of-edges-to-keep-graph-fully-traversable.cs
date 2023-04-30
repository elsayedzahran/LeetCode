public class Solution {
    public int MaxNumEdgesToRemove(int n, int[][] edges) {
        int res=0;
        UnionFind uf=new UnionFind(n);
        foreach(int[] e in edges)
            if(e[0]==3 && !uf.union(e[1],e[2]))
                res++;
        
        foreach(int[] e in edges)
            if(e[0]==1 && !uf.union(e[1],e[2]))
                res++;
        
        if(!uf.isConnected())
            return -1;
        
        uf=new UnionFind(n);
        foreach(int[] e in edges)
            if(e[0]==3) 
                uf.union(e[1],e[2]);
                
        
        foreach(int[] e in edges)
            if(e[0]==2 && !uf.union(e[1],e[2]))
                res++;
        if(!uf.isConnected())
            return -1;

        return res;
    }
}

public class UnionFind{
    int[] parent;
    int[] size;
    public int cmpCnt;
    public UnionFind(int sz)
    {
        parent=Enumerable.Range(0,sz+1).ToArray();
        size=new int[sz+1];
        cmpCnt=sz;
    }
    
    int find(int node)
    {
        if(parent[node]!=node)
            parent[node]=find(parent[node]);
        
        return parent[node];
        
    }
    
    public bool union(int i,int j)
    {
        int pi=find(i);
        int pj=find(j);
        
        if(pi==pj)
            return false;
        
        parent[pi]=pj;
        size[pi]+=size[pj];
        cmpCnt--;
        return true;
    }

    public bool isConnected()
    {
        return cmpCnt==1;
    }
}