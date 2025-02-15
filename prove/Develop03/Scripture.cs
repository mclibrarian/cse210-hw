public class Scripture
{
    private List<Word> _text;
    private Reference _reference;
    private Random _rnd;

    public Scripture()
    {
        _reference = new Reference("Moroni", 10, 4, 5);
        _text = new List<Word>();
        _text.Add(new Word("And"));
        _text.Add(new Word("when"));
        _text.Add(new Word("ye"));
        _text.Add(new Word("shall"));
        _text.Add(new Word("receive"));
        _text.Add(new Word("these"));
        _text.Add(new Word("things,"));
        _text.Add(new Word("I"));
        _text.Add(new Word("would"));
        _text.Add(new Word("exhort"));
        _text.Add(new Word("you"));
        _text.Add(new Word("that"));
        _text.Add(new Word("ye"));
        _text.Add(new Word("would"));
        _text.Add(new Word("ask"));
        _text.Add(new Word("God,"));
        _text.Add(new Word("the"));
        _text.Add(new Word("Eternal"));
        _text.Add(new Word("Father,"));
        _text.Add(new Word("in"));
        _text.Add(new Word("the"));
        _text.Add(new Word("name"));
        _text.Add(new Word("of"));
        _text.Add(new Word("Christ,"));
        _text.Add(new Word("if"));
        _text.Add(new Word("these"));
        _text.Add(new Word("things"));
        _text.Add(new Word("are"));
        _text.Add(new Word("not"));
        _text.Add(new Word("true;"));
        _text.Add(new Word("and"));
        _text.Add(new Word("if"));
        _text.Add(new Word("ye"));
        _text.Add(new Word("shall"));
        _text.Add(new Word("ask"));
        _text.Add(new Word("with"));
        _text.Add(new Word("a"));
        _text.Add(new Word("sincere"));
        _text.Add(new Word("heart,"));
        _text.Add(new Word("with"));
        _text.Add(new Word("real"));
        _text.Add(new Word("intent,"));
        _text.Add(new Word("having"));
        _text.Add(new Word("faith"));
        _text.Add(new Word("in"));
        _text.Add(new Word("Christ,"));
        _text.Add(new Word("he"));
        _text.Add(new Word("will"));
        _text.Add(new Word("manifest"));
        _text.Add(new Word("the"));
        _text.Add(new Word("truth"));
        _text.Add(new Word("of"));
        _text.Add(new Word("it"));
        _text.Add(new Word("unto"));
        _text.Add(new Word("you,"));
        _text.Add(new Word("by"));
        _text.Add(new Word("the"));
        _text.Add(new Word("power"));
        _text.Add(new Word("of"));
        _text.Add(new Word("the"));
        _text.Add(new Word("Holy"));
        _text.Add(new Word("Ghost."));
        _text.Add(new Word("And"));
        _text.Add(new Word("by"));
        _text.Add(new Word("the"));
        _text.Add(new Word("power"));
        _text.Add(new Word("of"));
        _text.Add(new Word("the"));
        _text.Add(new Word("Holy"));
        _text.Add(new Word("Ghost"));
        _text.Add(new Word("ye"));
        _text.Add(new Word("may"));
        _text.Add(new Word("know"));
        _text.Add(new Word("the"));
        _text.Add(new Word("truth"));
        _text.Add(new Word("of"));
        _text.Add(new Word("all"));
        _text.Add(new Word("things."));

        _rnd = new Random();
    }
    public string GetRenderedText()
    {
        string finalString = _reference.GetRenderedText();
        foreach (var word in _text)
        {
            finalString += $" {word.GetRenderedText()}";
        }
        return finalString;
    }

    public void HideWords()
    {
        for (int i = 0; i < 3; i++)
        {
            int r = _rnd.Next(_text.Count);
            Word w = _text[r];
            if (w.IsHidden())
            {
                if (IsCompletelyHidden())
                {
                    return;
                }

                i--;
                continue;
            }

            w.Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _text)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}