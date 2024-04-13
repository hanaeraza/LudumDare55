using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public TMP_Text buttonText;
    bool isOpen; 

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                isOpen = animator.GetBool("open");

                animator.SetBool("open", !isOpen);

                if (isOpen)
                    buttonText.text = ">";
                else
                    buttonText.text = "<"; 
            }
        }
    }

}
