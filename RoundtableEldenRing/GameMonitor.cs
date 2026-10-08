namespace RoundtableEldenRing;

public abstract class GameMonitor
{
    protected virtual int UpdateInterval => 33;  // 30 FPS
    long LastUpdate { get; set; }

    public bool CheckUpdate(long updateTime, long gameLoadedTime)
    {
        if (updateTime >= LastUpdate + UpdateInterval)
        {
            bool result = OnUpdate(updateTime, gameLoadedTime);
            LastUpdate = updateTime;
            return result;
        }

        return true;
    }
    
    protected abstract bool OnUpdate(long updateTime, long gameLoadedTime);
}