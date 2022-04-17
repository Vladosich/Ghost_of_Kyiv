using UnityEngine;

public class GunUpgrade : Upgrade
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);

        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject player = GameObject.Find("Player");
            GunController gunControllerScript = player.GetComponent<GunController>();

            gunControllerScript.SetCurrentNumberOfGuns();
        }
    }
}
