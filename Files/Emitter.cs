public class Emitter
{
    private string message;


    public string Message
    {
        get { return message; }
        set { message = value; OnNewMessage(message); }
    }


    public event Action<string> NewMessage;

    public void OnNewMessage(string msg)
    {
        if (NewMessage != null)
            NewMessage(msg);
    }
}
