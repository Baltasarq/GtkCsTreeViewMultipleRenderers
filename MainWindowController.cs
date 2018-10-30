namespace TreeViewMultipleRenderers
{
    public class MainWindowController
    {
        public MainWindowController()
        {
            this.Form = new MainWindowView();

            this.Form.DeleteEvent += (o, args) => Gtk.Application.Quit();
        }

        public MainWindowView Form {
            get; private set;
        }
    }
}
