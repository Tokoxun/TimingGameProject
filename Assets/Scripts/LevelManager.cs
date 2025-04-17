using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public PlayerLevel Player;
    public float levelSpeed;

    // Update is called once per frame
    void Update()
    {
        if(Player.playerLevel > 0)
        {
            levelSpeed = Player.playerLevel / 100f;
        }
    }
}
