namespace TreeViewMultipleRenderers
{
    public class Ppal
    {
        public static void Main()
        {
            Gtk.Application.Init();
            new MainWindowController().Form.ShowAll();
            Gtk.Application.Run();
        }
    }
}
