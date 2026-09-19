using System.Collections.Concurrent;

public class Word
{
    private string _text;

    public string _Text
    {
        get
        {
            return _text;
        }
        set
        {
            _text = value;
        }
    }

    public void hide()
    {
        Reference reference = new Reference();
        
        List<int> hiddenwords = new List<int>();
        Random rand = new Random();

            string[] words = _Text.Split(" ");
            Console.Clear();
            
            while (hiddenwords.Count < words.Length)
            {
                
                for (int count = 0; count < 3; count++)
                {
                    
                    Console.Clear();
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (hiddenwords.Contains(i))
                        {
                            Console.Write(new string('_', words[i].Length) + " ");
                        }
                        else
                        {
                            Console.Write(words[i] + " ");
                        }
                        
                    }
                    

                    List<int> visiblewords = new List<int>();
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (!hiddenwords.Contains(i))
                        {
                            visiblewords.Add(i);
                        }
                    }

                    if (visiblewords.Count >= 0)
                    {
                        int randomword = rand.Next(visiblewords.Count);
                        hiddenwords.Add(visiblewords[randomword]);
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Press Enter key to continue or type 'quit' to finish");
                string input = Console.ReadLine();
                if (input == "quit")
                {
                    break;
                }
            }

    }

    public void GetDisplay()
    {
        Console.WriteLine(_Text);
    }
}