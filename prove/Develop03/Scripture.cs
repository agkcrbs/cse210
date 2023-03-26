using System.Linq;

public class Scripture
{
    private string _reference;
    private List<Word> _scriptureTextWordList = new List<Word>();
    private Random _randomInstance = new Random();
    private int _hiddenCount;
    private bool _showHint;
    private bool _noBlanks;

    // When instantiating, set the reference and make the list-form text.
    public Scripture(string _passedReference, string _textString, bool _passedShowHint)
    {
        _reference = _passedReference;
        _hiddenCount = 0;
        _showHint = _passedShowHint;
        _noBlanks = false;
        _textString = _textString.Replace("—", " — "); // Strings are immutable, so these 
        _textString = _textString.Replace("-", " - "); // replacement strings must be re-saved.
        _textString = _textString.Replace("(", "( ");
        _textString = _textString.Replace("\"", " \" ");
        List<string> _textList = _textString.Split(new[] {' '}).ToList();
        foreach (string _wordItem in _textList)
        {
            // I guess I don't need to keep track of these, but just 
            // instantiate them as objects to access their methods.
            Word _listMember = new Word(_wordItem);
            _scriptureTextWordList.Add(_listMember);
        }
    }

    public string ReturnReference()
    {
        return _reference;
    }

    public string ReturnTextString()
    {
        string _textString = "";
        foreach (Word _wordObject in _scriptureTextWordList)
        {
            _textString += _wordObject.ReturnWord(_showHint) + " ";
        }
        return _textString;
    }

    public (string, bool) ReturnBlankedText()
    {
        int _blanksLeft = _scriptureTextWordList.Count - _hiddenCount;
        int _timesToRun;
        if (_blanksLeft >= 3)
        {
            _timesToRun = 3;
        }
        else
        {
            _timesToRun = _blanksLeft;
        }
        for (int _runNumber = 0; _runNumber < _timesToRun; _runNumber++)
        {
            while (true)
            {
                int randomNumber = _randomInstance.Next(0, _scriptureTextWordList.Count);
                if (_scriptureTextWordList[randomNumber].GetIfHidden() == false)
                {
                    _scriptureTextWordList[randomNumber].SetAsHidden();
                    _hiddenCount++;
                    break;
                }
            }
        }
        if (_blanksLeft <= 0)
        {
            _noBlanks = true;
        }
        return (ReturnTextString(), _noBlanks);
    }
}
