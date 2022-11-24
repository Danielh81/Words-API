namespace RandomWords.Repository;

public class WordRepository
{
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

    public string GetRandWord()
    {
        Random random = new Random();
        var randomWord = random.Next(0, 6);
        var rando = WordList.words[randomWord];

        return rando;
    }

}

