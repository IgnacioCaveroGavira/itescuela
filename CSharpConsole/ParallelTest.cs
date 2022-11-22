using System.Threading;
public class ParallelTest
{    public static void Start()
    {
        var limit = 10000;
        var numbers = Enumerable.Range(0, limit).ToList();
        
        var list1 = new List<int>();
        var list2 = new List<int>();
        var list3 = new List<int>();
        var list4 = new List<int>();



        Parallel.ForEach(numbers, new ParallelOptions(){MaxDegreeOfParallelism = 4}, number => {
            
            Console.WriteLine(number + ": " + Task.CurrentId);

            switch ((Task.CurrentId % 4)??0){
                case 0 : 
                        list1.Add(number);
                        break;

                    case 1 : 
                list2.Add(number);
                break;

                    case 2 : 
                list3.Add(number);
                break;

                    case 3 : 
                list4.Add(number);
                break;
            }
        } );

        Console.WriteLine("list 1: " + list1.Count);
        Console.WriteLine("list 2: " + list2.Count);
        Console.WriteLine("list 3: " + list3.Count);
        Console.WriteLine("list 4: " + list4.Count);

    }

}