using System.Collections;
using UnityEngine;

public class NightAnimation : MonoBehaviour
{
    private Animator _animator;

    public void Start()
    {
        _animator = GetComponent<Animator>();
        PlayerMain.Instance.PlayerInteract.PlayerSleep += NightFalls;
    }

    public void NightFalls()
    {
        _animator.SetBool("Sleep", true);
        StartCoroutine(WaitNight());
    }

    public void SunUp()
    {
        _animator.SetBool("Sleep", false);
    }

    private IEnumerator WaitNight()
    {
        yield return new WaitForSeconds(2);
        SunUp();
    }
}
