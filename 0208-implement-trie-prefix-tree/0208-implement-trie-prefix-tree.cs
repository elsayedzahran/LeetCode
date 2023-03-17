public class Trie {
    private readonly Trie[] _children = new Trie[26];
    private int _count;
    public void Insert(string word)
    {
        Insert(word,0);
    }

    private void Insert(string word, int pos)
    {
        if (pos == word.Length)
        {
            _count++;
            return;   
        }
        _children[word[pos] - 'a'] ??= new Trie();
        _children[word[pos] - 'a'].Insert(word,pos+1);
    }

    public bool Search(string word)
    {
        return Search(word, 0);
    }

    private bool Search(string word, int pos)
    {
        if (pos == word.Length) 
            return _count > 0;
        
        return _children[word[pos] - 'a'] != null && 
            _children[word[pos] - 'a'].Search(word, pos + 1);
    }

    public bool StartsWith(string prefix)
    {
        return StartsWith(prefix, 0);
    }

    private bool StartsWith(string prefix, int pos)
    {
        if (pos == prefix.Length) 
            return true;
        
        return _children[prefix[pos] - 'a'] != null &&
            _children[prefix[pos] - 'a'].StartsWith(prefix, pos + 1);
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */