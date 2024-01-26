using System;

class Word
{
	private string _text;
	private bool _isHidden;

	public Word(string text)
	{
		_isHidden = false;
		_text = text;
	}

	public void Hide()
	{
		_isHidden = true;
	}

	public void Show()
	{
		Console.Write($" {_text} ");
	}

	public bool IsHidden()
	{
		return _isHidden;
	}

	public string GetDisplayText()
	{
		return _text;
	}
}
