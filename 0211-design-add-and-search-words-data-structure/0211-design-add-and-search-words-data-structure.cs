public class WordDictionary {
    List<string> dictionary;
    public WordDictionary() {
        dictionary = new List<string>();
    }
    
    public void AddWord(string word) {
        dictionary.Add(word);
    }
    
    public bool Search(string word) {
        foreach (var item in dictionary){
            if (item.Length == word.Length){
                if (item == word) return true;
                else{
                    bool exist = true;
                    for (int i = 0 ; i < item.Length ; i++){
                        if (item[i] != word[i] && word[i] != '.') 
                        {
                            exist = false;
                            break;
                        }
                    }
                    if (exist) return true;
                }
            }
        }
        return false;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */