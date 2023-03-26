public class Word
{
    private string _wordItself;
    private char _firstLetter;
    private char _secondLetter;
    private bool _isHidden;
    private string _hintWord;

    // A constructor.  The object probably needs to be fed its text.
    public Word(string _wordText)
    {
        _wordItself = _wordText;
        _isHidden = false;
    }

    // Attribute-getter/setter.
    public bool GetIfHidden()
    {
        return _isHidden;
    }
    public void SetAsHidden()
    {
        _isHidden = true;
    }

    // A method that returns a blank word of the same length as the word.
    public string ReturnWord(bool _hintBool)
    {
        if (_isHidden == false)
        {
            return _wordItself;
        }
        else
        {
            Hide(_hintBool);
            return _wordItself;
        }
    }

    // A method that hides the word while also making a hint version.
    public void Hide(bool _hint)
    {
        _firstLetter = ' ';
        if (_wordItself.Length > 0)
        {
            _firstLetter = _wordItself[0];
        }
        string _punctuation = "";
        if (_wordItself.Length > 1)
        {
            _secondLetter = _wordItself[1];
        }
        else
        {
            _secondLetter = ' ';
        }
        string _blankWord = "";
        foreach(char x in _wordItself)
        {
            switch (x.ToString())
            {
                case "(":
                    _blankWord += "(";
                    _punctuation = "(";
                    break;
                case ")":
                    _blankWord += ")";
                    _punctuation = ")";
                    break;
                case "—":
                    _blankWord += "—";
                    _punctuation = "—";
                    break;
                case ",":
                    _blankWord += ",";
                    _punctuation = ",";
                    break;
                case ".":
                    _blankWord += ".";
                    _punctuation = ".";
                    break;
                case ":":
                    _blankWord += ":";
                    _punctuation = ":";
                    break;
                case ";":
                    _blankWord += ";";
                    _punctuation = ";";
                    break;
                case "!":
                    _blankWord += "!";
                    _punctuation = "!";
                    break;
                case "?":
                    _blankWord += "?";
                    _punctuation = "?";
                    break;
                case "'":
                    _blankWord += "'";
                    _punctuation = "'";
                    break;
                case "\"":
                    _blankWord += "\"";
                    _punctuation = "\"";
                    break;
                default:
                    _blankWord += "_";
                    break;
            }
        }
        _wordItself = _blankWord;
        // if (_firstLetter.ToString() != "(") // This just causes a parenthesis bug.
        // {
            if (_punctuation == "")
            {
                _hintWord = (_firstLetter + _wordItself).Remove(_wordItself.Length);
            }
            else
            {
                _hintWord = (_firstLetter + _wordItself).Remove(_wordItself.Length - 1) + _punctuation;
            }
        // }
        // else
        // {
        //     _hintWord = (_firstLetter + _secondLetter + _wordItself).Remove(_wordItself.Length); // + _punctuation);
        // }
        if (_hint == true)
        {
            _wordItself = _hintWord;
        }
    }
}

