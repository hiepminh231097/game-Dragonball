
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonKiller : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //khong cho rong bay cao hon man hinh. cham man hinh se die
        if (transform.position.y > 6)
            SceneManager.LoadScene(0);
        if (transform.position.y < -6)
            SceneManager.LoadScene(0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }
}
