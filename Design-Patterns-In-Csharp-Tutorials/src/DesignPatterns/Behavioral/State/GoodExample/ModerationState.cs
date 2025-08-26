namespace Design_Patterns_In_Csharp_Tutorials.DesignPatterns.Behavioral.State.GoodExample
{
    public class ModerationState : State
    {
        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            if (_document.CurrentUserRole == UserRoles.ADMIN)
            {
                _document.State = new PublishedState(_document);
            }
        }
    }
}