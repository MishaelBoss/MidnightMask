using UnityEngine;

public class ShowPanel : MonoBehaviour
{
    public GameObject panel;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void SetActive() {
        anim.SetTrigger("Black");
        Invoke("SetAcive", 3f);
    }

    void SetAcive() { 
        panel.SetActive(false);
    }
}
