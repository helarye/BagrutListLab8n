using ListLab;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Node<int> lst = new Node<int>(5);//יצירת חוליה ראשונה ששם הרשימה מצביע עליה
                                         //null בעת היצירה החוליה היחידה מצביעה על
        Console.WriteLine(lst);
        Node<int> currNode = new Node<int>(7, lst);//יצירת חוליה נוספת, שמוצבת לפני ליסט ומצביעה
                                                   //על החוליה הראשונה של ליסט
        lst = currNode;//גורמים למצביע ליסט להצביע על החוליה שהוספנו בתחילת הרשימה
        Console.WriteLine(lst);
        currNode = new Node<int>(9, lst);
        lst = currNode;
        currNode = new Node<int>(-2, lst);
        lst = currNode;
        currNode = new Node<int>(10, lst);
        lst = currNode;
        currNode = new Node<int>(22, lst);
        lst = currNode;
        currNode = new Node<int>(1, lst);
        lst = currNode;
        currNode = new Node<int>(-1, lst);
        lst = currNode;
        currNode = new Node<int>(-9, lst);
        lst = currNode;
        lst = new Node<int>(-55, lst);//צורת כתיבה שמאפשרת להוסיף חוליה בראש שרשרת החוליות ולהעביר אתיה את מצביע ראש הרשימה
        Console.WriteLine(lst);

        Console.WriteLine(lst.GetValue());//הדפסת הערך של החוליה הראשונה ברשימה

        Console.WriteLine(lst.GetNext().GetValue());//הדפסת הערך של החוליה השנייה ברשימה

        currNode = lst.GetNext();//הצבעה על החוליה השניה בשרשרת החוליות

        currNode = currNode.GetNext();//קידום ההצבעה של החוליות הנוכחית באחת

        //שילוב חוליה חדשה בשרשרת אחרי חוליה נתונה
        //נהנה למשל שרשרת חוליות מסודרת בסדר עולה
        Node<int> lst1 = new Node<int>(10);// 10-->null
        lst1 = new Node<int>(8, lst1);// 8-->10-->null
        lst1 = new Node<int>(6, lst1);// 6-->8-->10-->null
        lst1 = new Node<int>(4, lst1);// 4-->6-->8-->10-->null
        Console.WriteLine(lst1);
        
        //ניצור חולייה חדשה ונכניס אותה לשרשרת לפי ערך המספר
        Node<int> NewNode = new Node<int>(12);// 12-->null
        lst1=InsretNode2OrderedList(lst1, NewNode);
        Console.WriteLine(lst1);// 4-->6-->8-->10-->12-->null

        NewNode = new Node<int>(7);// 7-->null
        lst1 = InsretNode2OrderedList(lst1, NewNode);
        Console.WriteLine(lst1);// 4-->6-->7-->8-->10-->12-->null

        NewNode = new Node<int>(3);// 3-->null
        lst1 = InsretNode2OrderedList(lst1, NewNode);
        Console.WriteLine(lst1);// 3-->4-->6-->7-->8-->10-->12-->null

    }
    public static Node<int> InsretNode2OrderedList(Node<int> lst1, Node<int> NewNode)
    {//הפונקציה מקבלת שרשרת חוליות ממויינת מקטן לגדול וחוליה חדשה לשילוב ומחזירה רשימה מסודרת
        Node<int> currNode = lst1;
        if (currNode.GetValue() > NewNode.GetValue())
        {
            Console.WriteLine("inIf");
            NewNode.SetNext(lst1);//הכנסת החוליה החדשה לראש הרשימה
            lst1 = NewNode;
        }
        else
        {
            while (currNode.HasNext() && currNode.GetNext().GetValue() < NewNode.GetValue())
            {
                currNode = currNode.GetNext();
            }
            NewNode.SetNext(currNode.GetNext());//הצבת החוליה שאחרי הנוכחית לאחר החוליה החדשה
            currNode.SetNext(NewNode);//הכנסת החוליה החדשה אחרי החוליה הנוכחית
        }
        return lst1;
    }

}