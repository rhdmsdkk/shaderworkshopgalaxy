using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class GrandStarManager : MonoBehaviour
{
    void Start() {
        transform.DORotate(new Vector3(0f, 0f, 360f), 1.5f, RotateMode.LocalAxisAdd).SetEase(Ease.OutCubic);
        transform.DOScale(Vector3.one * 0.1f, 0f);
        transform.DOScale(Vector3.one, 1.5f);
    }
}
