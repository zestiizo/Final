using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5;
    Rigidbody rb;

    private AudioSource playerAudio;
    [SerializeField] AudioClip rowOneSound;
    [SerializeField] AudioClip rowTwoSound;
    [SerializeField] AudioClip rowThreeSound;
    [SerializeField] AudioClip rowFourSound;
    [SerializeField] AudioClip rowFiveSound;
    [SerializeField] AudioClip rowSixSound;
    [SerializeField] AudioClip rowSevenSound;
    [SerializeField] AudioClip rowEightSound;
    [SerializeField] AudioClip rowNineSound;
    [SerializeField] AudioClip rowTenSound;
    [SerializeField] AudioClip rowElevenSound;

    [SerializeField] AudioClip badSoundOne;
    [SerializeField] AudioClip badSoundTwo;
    [SerializeField] AudioClip badSoundThree;
    [SerializeField] AudioClip badSoundFour;
    [SerializeField] AudioClip badSoundFive;
    [SerializeField] AudioClip badSoundSix;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAudio = GetComponent<AudioSource>();
    }


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime;
        transform.Translate(moveDirection);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("RowOne"))
        {
            playerAudio.PlayOneShot(rowOneSound, 1.0f);
        }
        else if (other.gameObject.CompareTag("RowTwo"))
        {
            playerAudio.PlayOneShot(rowTwoSound, 1.0f);
        }
        else if (other.gameObject.CompareTag("RowThree"))
        {
            playerAudio.PlayOneShot(rowThreeSound, 1.0f);
        }
        else if (other.gameObject.CompareTag("RowFour"))
        {
            playerAudio.PlayOneShot(rowFourSound, 1.0f);
        }
        else if (other.gameObject.CompareTag("RowFive"))
        {
            playerAudio.PlayOneShot(rowFiveSound, 1.0f);
        }
        else if (other.gameObject.CompareTag("RowSix"))
        {
            playerAudio.PlayOneShot(rowSixSound, 1.0f);
        }
        else if (other.gameObject.CompareTag("RowSeven"))
        {
            playerAudio.PlayOneShot(rowSevenSound, 1.0f);
        }
        else if (other.gameObject.CompareTag("RowEight"))
        {
            playerAudio.PlayOneShot(rowEightSound, 1.0f);
        }
        else if (other.gameObject.CompareTag("RowNine"))
        {
            playerAudio.PlayOneShot(rowNineSound, 1.0f);
        }
        else if (other.gameObject.CompareTag("RowTen"))
        {
            playerAudio.PlayOneShot(rowTenSound, 1.0f);
        }
        else if (other.gameObject.CompareTag("RowEleven"))
        {
            playerAudio.PlayOneShot(rowElevenSound, 1.0f);
        }
        else if (other.gameObject.CompareTag("BadSoundOne"))
        {
            playerAudio.PlayOneShot(badSoundOne, 0.2f);
        }
        else if (other.gameObject.CompareTag("BadSoundTwo"))
        {
            playerAudio.PlayOneShot(badSoundTwo, 1.0f);
        }
        else if (other.gameObject.CompareTag("BadSoundThree"))
        {
            playerAudio.PlayOneShot(badSoundThree, 1.0f);
        }
        else if (other.gameObject.CompareTag("BadSoundFour"))
        {
            playerAudio.PlayOneShot(badSoundFour, 1.0f);
        }
        else if (other.gameObject.CompareTag("BadSoundFive"))
        {
            playerAudio.PlayOneShot(badSoundFive, 1.0f);
        }
        else if (other.gameObject.CompareTag("BadSoundSix"))
        {
            playerAudio.PlayOneShot(badSoundSix, 1.0f);
        }
        else if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Lvl Menu One");
            Cursor.visible = true;
        }
        else if (other.gameObject.CompareTag("FinishTwo"))
        {
            SceneManager.LoadScene("Lvl Menu Two");
            Cursor.visible = true;
        }
        else if (other.gameObject.CompareTag("FinishThree"))
        {
            SceneManager.LoadScene("FinalMenu");
            Cursor.visible = true;
        }
    }
}
