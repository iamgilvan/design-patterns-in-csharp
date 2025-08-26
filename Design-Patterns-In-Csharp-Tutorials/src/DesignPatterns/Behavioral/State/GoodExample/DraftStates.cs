namespace Design_Patterns_In_Csharp_Tutorials.DesignPatterns.Behavioral.State.GoodExample
{
    public class DraftState : State
    {
        private Document _document;

        public DraftState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            _document.State = new ModerationState(_document);
        }
    }
}