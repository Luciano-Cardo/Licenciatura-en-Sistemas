namespace punto5;

public class TicEventArgs : EventArgs
{
    public int Tics { get; set; }

    public TicEventArgs(int tics)
    {
        Tics = tics;
    }
}
