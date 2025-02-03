using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public float moveSpeed, health, damage;

    private static PlayerStats Instance;

    private void Start()
    {
        if(Instance == null) Instance = this;
    }


    public static float GetStat(Stats stat)
    {
        PlayerStats playerStats = PlayerStats.Instance;
        if(stat == Stats.MOVE_SPEED)
        {
            return playerStats.moveSpeed;
        }
        return 0;
    }


}

public enum Stats
{
    MOVE_SPEED,
    HEALTH,
    DAMAGE
}
