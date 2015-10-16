using UnityEngine;
using System.Collections;

public class EndScreen : MonoBehaviour {

    public EndFrog firstFrog;
    public EndFrog secondFrog;
    public EndFrog thirdFrog;
    public EndFrog fourthFrog;

    private float timer;
    private float timeout = 1f;

    public GameObject restartButton;

    public bool gameEnded;

    public void Awake()
    {

        gameEnded = false;
    }

    public void setRanks(int[] ranks, int[] scores)
    {
        gameEnded = true;
        timer = Time.time;
        firstFrog.showFrog(ranks[0], scores[0]);
        secondFrog.showFrog(ranks[1], scores[1]);
        thirdFrog.showFrog(ranks[2], scores[2]);
        fourthFrog.showFrog(ranks[3], scores[3]);
    }

    public void hit()
    {
        if (restartButton.activeSelf)
        {
            gameEnded = false;
            restartButton.SetActive(false);
            LevelController.Instance.restart();
        }
    }

	// Use this for initialization
	void Start () {
        restartButton.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (!restartButton.activeSelf && gameEnded && (timer + timeout) < Time.time)
        {
            restartButton.SetActive(true);
        }
	}
}
