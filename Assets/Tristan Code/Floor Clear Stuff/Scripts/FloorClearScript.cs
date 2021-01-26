using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorClearScript : MonoBehaviour
{
    public Animator TextandBars;
    public Animator FloorCleared;
    public Animator LevelandConfidence;
    public Animator LevelandBar;
    public Animator Inventory;
    public Animator Equip;
    public Animator Next;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Animation");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Animation()
    {
        FloorCleared.SetBool("isOpen", true);
        yield return new WaitForSeconds(2f);
        LevelandConfidence.SetBool("isOpen", true);
        yield return new WaitForSeconds(1f);
        LevelandBar.SetBool("isOpen", true);
        yield return new WaitForSeconds(1f);
        Inventory.SetBool("isOpen", true);
        yield return new WaitForSeconds(1f);
        TextandBars.SetBool("isOpen", true);
        yield return new WaitForSeconds(1f);
        Equip.SetBool("isOpen", true);
        yield return new WaitForSeconds(1f);
        Next.SetBool("isOpen", true);

    }
}
