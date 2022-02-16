using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KeyController : MonoBehaviour
{
    public LevelManager lvl_mngr;
    [SerializeField] private float _cycleLength = 2.0f;

    private List<Tweener> tweens;

    // Start is called before the first frame update
    void Start()
    {
        tweens = new List<Tweener>();
        Vector3 endPosition = transform.position + new Vector3(0, 0.5f, 0);
        tweens.Add(transform.DOLocalMove(endPosition, _cycleLength).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo));
        tweens.Add(transform.DORotate(new Vector3(0, 360, 0), _cycleLength * 1.5f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Delete()
    {
        // Clean up tweens
        foreach (Tweener tween in tweens)
        {
            tween.Kill();
        }
        // Remove gameobject
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            lvl_mngr.keyFound();
            Delete();
        }
    }
}
