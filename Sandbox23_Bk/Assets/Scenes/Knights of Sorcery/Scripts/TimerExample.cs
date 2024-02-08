using UnityEngine;
using UnityEngine.UI;

public class Timerexample : MonoBehaviour
{

    float val;
    bool srt;
    public Text disvar;

    void Start()
        {
            val=0;
            srt=false;
        }

    void Update() 

    { 

        if(srt)     

            {         
                val += Time.deltaTime;    
            } 

        double b = System.Math.Round (val, 2);     

    disvar.text = b.ToString ();    
    }
    public void stopbutton()
    {
        srt=false;
    }   
    public void resetbutton()
    {
        srt=false;
        val=0;
    }
    public void startbutton()
    {
    srt=true;
    }
}