using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float levelDuration;
    public int targetNumOfCollectibles;
    public Text timerNum;
    public Text collectibleNum;
    public Text gameWin;
    public Text gameLose;

    private float time = 0f;
    private int collectibles = 0;

    void Update()
    {
        time += Time.deltaTime;
        timerNum.text = (levelDuration - time).ToString();

        if (collectibles >= targetNumOfCollectibles)
        {
            GameWin();
        }
        else if (time >= levelDuration)
        {
            GameLose();
        }
    }

    public void IncrementCollectibles()
    {
        collectibles++;
        collectibleNum.text = collectibles.ToString();
    }

    void GameWin()
    {
        Time.timeScale = 0f;
        gameWin.gameObject.SetActive(true);
    }

    void GameLose()
    {
        Time.timeScale = 0f;
        gameLose.gameObject.SetActive(true);
    }
}
