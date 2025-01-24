namespace RoundtableEldenRing;

public abstract class GameMonitor
{
    protected virtual int UpdateInterval => 33;  // 30 FPS
    int LastUpdate { get; set; }

    public bool CheckUpdate(long updateTime, long gameLoadedTime)
    {
        if (updateTime >= LastUpdate + UpdateInterval)
        {
            bool result = OnUpdate(updateTime, gameLoadedTime);
            LastUpdate = (int)updateTime;
            return result;
        }

        return true;
    }
    
    protected abstract bool OnUpdate(long updateTime, long gameLoadedTime);
}