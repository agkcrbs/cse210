class PromptSelector
{
    private List<string> _promptList = new List<string>();
    private Random _randomInstance = new Random();

    public void FillPromptList(List<string> selectionList)
    {
        _promptList.Clear();
        foreach (string prompt in selectionList)
        {
            _promptList.Add(prompt);
        }
    }

    public string GetRandomPrompt()
    {
        int randomPromptNumber = _randomInstance.Next(0, _promptList.Count);
        return _promptList[randomPromptNumber];
    }

    public List<string> GetRandomizedPromptList()
    {
        // Copy the original list, then randomly select items out of it into a third list.
        List<string> newList = new List<string>();
        foreach (string member in _promptList)
        {
            newList.Add(member);
        }
        List<string> randomizedList = new List<string>();
        for (int i = 0; i < newList.Count; i ++)
        {
            int randomPromptNumber = _randomInstance.Next(0, newList.Count);
            randomizedList.Add(newList[randomPromptNumber]);
            newList.RemoveAt(randomPromptNumber);
        }
        return randomizedList;
    }
}
