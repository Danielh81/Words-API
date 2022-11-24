using RandomWords.Repository;

namespace RandomWords.Service;

public class WordService
{
    private WordRepository wordRepo;
    public WordService(WordRepository wordRepo)
    {
        this.wordRepo = wordRepo;
    }

    public List<string> GetAllWords()
    {
        var list = this.wordRepo.GetAllWords();
        
        return list;
    }
    
    public string GetWord(int index)
    {
        string oneWord = wordRepo.GetWord(index);

        return oneWord;
    }
    
    public string GetRandomWord(int index)
    {
        var random = wordRepo.GetRandWord(index);

        return random;
    }
}