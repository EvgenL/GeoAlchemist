using System.Collections.Generic;
using Mapbox.Unity.MeshGeneration.Interfaces;
using UnityEngine;

public class AlchemistPoiTest : MonoBehaviour, IFeaturePropertySettable
{
    Dictionary<string, object> _props;
    public GameObject ParticleOnClick;

    public void Set(Dictionary<string, object> props)
    {
        _props = props;
    }

    void OnMouseUpAsButton()
    {
        GameManager.Instance.AddScore();

        foreach (var prop in _props)
        {
            Debug.Log(prop.Key + ":" + prop.Value);
        }


        Destroy(Instantiate(ParticleOnClick, transform.position, Quaternion.identity), 5f);
        Destroy(gameObject);
    }
}