using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigsModel : MonoBehaviour
{
    public Resolution Resolution { get; set; }

    public LimitFPS LimitFPS { get; set; }

    public bool WindowMode { get; set; }

    public bool Quality { get; set; }

    public float GlobalVolume { get; set; }

    public float MusicVolume { get; set; }

    public float EffectsVolume { get; set; }


}

public enum Quality
{
    Low,
    Medium,
    High
}

public class Resolution
{
    public int width { get; set; }

    public int height { get; set; }
}

public class LimitFPS
{
    public bool Limitar { get; set; }

    public bool FPS { get; set; }
}