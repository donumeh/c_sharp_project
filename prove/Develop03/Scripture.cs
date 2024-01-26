using System;

class Scripture
{
	public Reference _reference = new Reference();
	public List<Word> _words = new List<Word>();


	public Scripture(Reference reference, string text)
	{
		_reference = reference;
		_words = StringToWords(text);
	}

	private List<Word> StringToWords(string text)
	{
		List<Word> words = new List<Word>();
		string[] textWords;
		
		textWords = textWords.Split(' ');
		foreach (string w in textWords)
		{
			Word word = new Word(w);
			words.Add(word);
		}
	}

	public void HideRandomWords(int numberToHide)
	{
		int loop = 3;
		Random random = new Random();
		int randomNumber;

		while (loop >= 0)
		{
			int i = 0;
			List<int> numbers = new List<int>();

			foreach (Word w in _words)
			{
				if (w.IsHidden() == false)
				{
					numbers.Add(i);
				}
				i++;
			}
			if (numbers.Count)
			{
				randomNumber = random.Next(0, numbers.Count);
				_words[randomNumber].Hide();
			}
			else
			{
				break;
			}
			loop--;
		}
	}





}
