using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWindow : MonoBehaviour
{
    public enum State { Opened, Closed }
    public string mecanimStateOpened, mecanimStateClosed;
    public State state { get; private set; }
    Animator _animator = null;
    Animator animator
    {
        get
        {
            if (_animator == null)
            {
                _animator = GetComponent<Animator>();
            }
            return _animator;
        }
    }

    private void Start()
    {
        Close(true);
    }
    void Open(bool isFastForward)
    {
        int i = 0;
        if (isFastForward)
        {
            i = 1;
        }
        animator.Play(mecanimStateOpened, -1, i);
        state = State.Opened;
    }
    void Close(bool isFastForward)
    {
        int i = 0;
        if (isFastForward)
        {
            i = 1;
        }
        animator.Play(mecanimStateClosed, -1, i);
        state = State.Closed;
    }
    public void Toggle()
    {
        switch (state)
        {
            case State.Closed:
                Open(false);
                break;
            case State.Opened:
                Close(false);
                break;
        }
    }
}
