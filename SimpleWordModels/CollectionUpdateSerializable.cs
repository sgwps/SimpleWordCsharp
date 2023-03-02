namespace SimpleWordModels;

//[Serializable]
class CollectionUpdateSerializable {

    public int Id {get; private set;}
    public string SourceLanguage {get; private set;}

    public string DistanationLanguage {get; private set;}

    public string Name {get; private set;}

    public string? Description{get; private set;}

    public string? Author {get; private set;}

    public string LinkName {get; private set;}

    public List<Card> Cards {get; private set; } = new();



    internal CollectionUpdateSerializable(Collection collection){
        Id = collection.Id;
        SourceLanguage = collection.SourceLanguage;
        DistanationLanguage = collection.DistanationLanguage;
        Name = collection.Name;
        Description = collection.Description;
        Author = collection.Author;
        LinkName = collection.LinkName;
        Cards = collection.Cards;

    }


}