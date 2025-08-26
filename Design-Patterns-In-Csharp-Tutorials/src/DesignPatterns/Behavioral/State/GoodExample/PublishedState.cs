namespace Design_Patterns_In_Csharp_Tutorials.DesignPatterns.Behavioral.State.GoodExample
{
    public class PublishedState : State
    {
        private Document _document;

        public PublishedState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            // do nothing
        }
    }
}