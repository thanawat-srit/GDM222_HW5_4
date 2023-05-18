public class Board
{
    private Dictionary<string, int> dictionary;
    public void InitialBoard()
    {
        this.dictionary = new Dictionary<string, int>();
        int index = 64;
        string lastCode = "A1";

        while (index > 0)
        {
            this.dictionary.Add(lastCode, 0);
            lastCode = GenerateNextCode(lastCode);
            index--;
        }
    }
    
    public string GenerateNextCode(string lastCode)
    {
        char[] codeArray = lastCode.ToCharArray();
        int index = codeArray.Length - 1;

        while (index >= 0 && codeArray[index] == '8')
        {
            codeArray[index] = '1';
            index--;
        }

        if (index >= 0)
        {
            codeArray[index]++;
        }
        else
        {
            Array.Resize(ref codeArray, codeArray.Length + 1);
            codeArray[0] = 'A';
        }
        return new string(codeArray);
    }
    public Dictionary<string, int> GetBoard()
    {
        return this.dictionary;
    }
}