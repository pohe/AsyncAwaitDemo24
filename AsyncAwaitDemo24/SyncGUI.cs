// See https://aka.ms/new-console-template for more information
public class SyncGUI
{
    public SyncBackend SyncBackend { get; set; }
    public SyncGUI()
    {
        SyncBackend = new SyncBackend();
    }
    public void HandleButtonClick()
    {
        Console.WriteLine("Start of HandleButtonClick");
        SyncBackend.DoTaskA();
        SyncBackend.DoTaskB();
        int result = SyncBackend.DoTaskC();
        Console.WriteLine($"I got {result} from DoTaskC()");
        Console.WriteLine("All done HandleButtonClick");
    }


}