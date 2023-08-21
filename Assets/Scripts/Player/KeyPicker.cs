using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPicker : MonoBehaviour
{
    public ChestOpener chestOpener;
    public AudioClip pickUpSound;
    public Transform cameraPos;
    public Text coinsTxt;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            AudioSource.PlayClipAtPoint(pickUpSound, cameraPos.position);
            chestOpener.haveKey ++;
            coinsTxt.text = chestOpener.haveKey.ToString();
            Destroy(this.gameObject);
        }
    }
}
