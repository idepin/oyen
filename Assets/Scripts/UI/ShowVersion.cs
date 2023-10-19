using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowVersion : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txtVersion;
    // Start is called before the first frame update
    void Start()
    {
        txtVersion.SetText("v." + Application.version);
    }
}
