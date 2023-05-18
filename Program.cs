class Program
{
    public static Node<string> head = new Node<string>("A1");
    static void Main(string[] args)
    {
        Board board = new Board();
        board.InitialBoard();
        while (true)
        {
            int dir = int.Parse(Console.ReadLine());
            if (dir == 11)
            {
                Console.WriteLine(head.GetValue());
                return;
            }
            if (dir == 9 || dir == 10)
            {
                Move(dir, 69, board);
            }
            else
            {
                int count = int.Parse(Console.ReadLine());
                Move(dir, count, board);
            }
        }
    }

    static void Move(int dir, int count, Board board)
    {
        string currentPos = head.GetValue();
        char[] arrPos = currentPos.ToCharArray();
        string moveTargetPos = null;

        switch (dir)
        {
            case 1:
                moveTargetPos = arrPos[0].ToString() + (int.Parse(arrPos[1].ToString()) + count).ToString();
                break;
            case 2:
                moveTargetPos = ((char)(arrPos[0] - count)).ToString() + (int.Parse(arrPos[1].ToString()) + count).ToString();
                break;
            case 3:
                moveTargetPos = ((char)(arrPos[0] - count)).ToString() + (int.Parse(arrPos[1].ToString())).ToString();
                break;
            case 4:
                moveTargetPos = ((char)(arrPos[0] - count)).ToString() + (int.Parse(arrPos[1].ToString()) - count).ToString();
                break;
            case 5:
                moveTargetPos = arrPos[0].ToString() + (int.Parse(arrPos[1].ToString()) - count).ToString();
                break;
            case 6:
                moveTargetPos = ((char)(arrPos[0] + count)).ToString() + (int.Parse(arrPos[1].ToString()) - count).ToString();
                break;
            case 7:
                moveTargetPos = ((char)(arrPos[0] + count)).ToString() + (int.Parse(arrPos[1].ToString())).ToString();

                break;
            case 8:
                moveTargetPos = ((char)(arrPos[0] + count)).ToString() + (int.Parse(arrPos[1].ToString()) + count).ToString();
                break;
            case 9:
                if (head.Before() != null)
                {
                    head = head.Before();
                }
                break;
            case 10:
                if (head.Next() != null)
                {
                    head = head.Next();
                }
                break;
        }
        if (moveTargetPos != null)
        {
            if (Is_inBoard(moveTargetPos, board.GetBoard()))
            {
                Node<string> temp = new Node<string>(moveTargetPos);
                temp.SetBefore(head);
                head.SetNext(temp);
                head = temp;
            }
        }
    }
    
    static bool Is_inBoard(string searchCode, Dictionary<string, int> board)
    {
        foreach (KeyValuePair<string, int> p in board)
        {
            if (p.Key == searchCode)
            {
                return true;
            }
        }
        return false;
    }
}