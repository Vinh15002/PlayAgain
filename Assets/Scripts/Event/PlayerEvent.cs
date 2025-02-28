public class PlayerEvent 
{
    public delegate void SentPlayerControl(PlayerController control);

    public static SentPlayerControl sentPlayerControl;


    public delegate void PlayerDieEnvent();
    public static PlayerDieEnvent playerDieEnvent;
}