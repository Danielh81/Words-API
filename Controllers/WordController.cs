using Microsoft.AspNetCore.Mvc;
using RandomWords.Service;

namespace RandomWords.Controllers;

[ApiController]
[Route("[controller]")]
public class WordController
{
    private WordService wordService;
    public WordController(WordService service)
    {
        this.wordService = service;
    }
    
    [HttpGet("/words")]
    public List<string> GetAllWords()
    {
        var list = this.wordService.GetAllWords();
        return list;
    }
    
    [HttpGet("/oneword")]
    public string GetWord(int index)
    {
        string wordd = wordService.GetWord(index);
        
        return wordd;
    }

    [HttpGet("/randomword")]
    public string GetRandomWord(int index)
    {
        string rando = wordService.GetRandomWord(index);
        
        return rando;
    }
    
}

