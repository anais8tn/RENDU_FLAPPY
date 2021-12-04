using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void relaunchGame()
    {
        Player _player = FindObjectOfType<Player>();
        Checkpoint[] _checkpoints = FindObjectsOfType<Checkpoint>();
        Pipe[] _pipes = FindObjectsOfType<Pipe>();
        //relaunch des pipes

        foreach (Checkpoint item in _checkpoints)
        {
            item.relaunchObject();

        }

        foreach (Pipe _pipe in _pipes)
        {
            _pipe.relaunchObject();

        }

        _player.relaunchObject();

        FindObjectOfType<UIManager>().Start();
        FindObjectOfType<Score>().resetScore();


    }

}
