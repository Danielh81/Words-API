namespace RandomWords.Repository;

public class WordRepository
{
    private WordList wordList;
    public WordRepository(WordList wordList)
    {
        this.wordList = wordList;
    }
    
    public List<string> GetAllWords()
    {
        return WordList.words;
    }

    public string GetWord(int index)
    {
        var oneWord = WordList.words;
        var word = oneWord.ElementAt(index);
        
        return word;
    }

    public string GetRandWord(int index)
    {
        var randWord = WordList.words;
        Random random = new Random();
        var randomWord = random.Next(0, 7);
        var rando = WordList.words[randomWord];
        
        return rando;
    }

}

