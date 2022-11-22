public class Generics
{
    public static void Start()
    {

        //ICollector<ICollectionRequest> collector = (ICollector<ICollectionRequest>) new CollectorElements();


    }

}


public interface ICollector//<T> where T : ICollectionRequest
{
    public Task<string> ExecutePartition<T>(string collectionPartitionData, ICollection<T> data)where T : ICollectionRequest;
}


public interface ICollectionRequest
{

}

public interface ICollectionRequestElement : ICollectionRequest
{

}

public class CollectionRequestElement : ICollectionRequestElement
{

}


public class CollectorElements //: ICollector//<CollectionRequestElement>
{

}