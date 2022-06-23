
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.SceneManagement;

public class Inspector_Timer : MonoBehaviour
{
    [Header("Main Settings")]
    public float DataTimer;
    public TMP_Text TextTimer;
    public string[] pertumbuhan;
    public int index;

    [Header("Condition")]
    public UnityEvent TimerFinihEvent;
    public GameObject[] tanaman;


    public UnityEvent panen;
    bool isExecuted = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("StartTimer", 1, 1);
    }

    void StartTimer()
    {
        if (DataTimer > 0)
        {
            DataTimer--;
            AudioClip.Instance.clip();
            TextTimer.text = $"{pertumbuhan[index]} : {DataTimer}";
        }
        if (DataTimer == 0)
        {
            index = index + 1;

            TimerFinihEvent.Invoke();
            pertumbuhans(index);
            DataTimer = 6;
        }



    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pertumbuhans(int indexs)
    {

        if (index == indexs)
        {
            tanaman[indexs].SetActive(true);
        }


    }

    public void akhir()
    {
        if (index > pertumbuhan.Length - 1)
        {

            tanaman[3].SetActive(true);
            if (DataTimer == 0)
            {
                loadScane();
            }

        }
    }

    public void loadScane()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void keluar()
    {
        Application.Quit();
    }
}
