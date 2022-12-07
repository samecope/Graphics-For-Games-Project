using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Text;
using UnityEngine.Profiling;

[RequireComponent(typeof(FPSCounter))]
public class FPSText : MonoBehaviour
{
    public TextMeshProUGUI highestFPSLabel, averageFPSLabel, lowestFPSLabel, memoryUsage;
    FPSCounter fpsCounter;

    private void Awake()
    {
        fpsCounter = GetComponent<FPSCounter>();
    }

    private void Update()
    {
        var sb = new StringBuilder(500);
        highestFPSLabel.text = ("Highest FPS: " + fpsCounter.HighestFPS.ToString());
        averageFPSLabel.text = ("Average FPS: " + fpsCounter.AverageFPS.ToString());
        lowestFPSLabel.text = ("Lowest FPS: " + fpsCounter.LowestFPS.ToString());
        memoryUsage.text = ("Total Used Memory: " + (Profiler.GetTotalAllocatedMemoryLong() / 1048576) + "MB");
    }
}
