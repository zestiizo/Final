using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    [SerializeField] GameObject goodTileObject;
    [SerializeField] GameObject moreInfoObject;
    [SerializeField] GameObject finalInfoObject;

    void Start()
    {
        goodTileObject.SetActive(false);
        moreInfoObject.SetActive(false);
        finalInfoObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GoodInfo"))
        {
            goodTileObject.SetActive(true);
            StartCoroutine("WaitForSecOne");
        }
        else if (other.gameObject.CompareTag("MoreInfo"))
        {
            moreInfoObject.SetActive(true);
            StartCoroutine("WaitForSecTwo");
        }
        else if (other.gameObject.CompareTag("FinalInfo"))
        {
            finalInfoObject.SetActive(true);
            StartCoroutine("WaitForSecThree");
        }
    }

    IEnumerator WaitForSecOne()
    {
       yield return new WaitForSeconds(6);
       Destroy(goodTileObject);
    }

    IEnumerator WaitForSecTwo()
    {
        yield return new WaitForSeconds(4);
        Destroy(moreInfoObject);
    }

    IEnumerator WaitForSecThree()
    {
        yield return new WaitForSeconds(5);
        Destroy(finalInfoObject);
    }
}
