//<<<<<<< HEAD

//=======
////<<<<<<< HEAD
//>>>>>>> c1fe867f9610846be86e773fdbcb61b18d60e5ad
﻿using UnityEngine;
using System.Collections;
using TMPro;

public class EnvMapAnimator : MonoBehaviour {

    //private Vector3 TranslationSpeeds;
    public Vector3 RotationSpeeds;
    private TMP_Text m_textMeshPro;
    private Material m_material;
    

    void Awake()
    {
        //Debug.Log("Awake() on Script called.");
        m_textMeshPro = GetComponent<TMP_Text>();
        m_material = m_textMeshPro.fontSharedMaterial;
    }

    // Use this for initialization
	IEnumerator Start ()
    {
        Matrix4x4 matrix = new Matrix4x4(); 
        
        while (true)
        {
            //matrix.SetTRS(new Vector3 (Time.time * TranslationSpeeds.x, Time.time * TranslationSpeeds.y, Time.time * TranslationSpeeds.z), Quaternion.Euler(Time.time * RotationSpeeds.x, Time.time * RotationSpeeds.y , Time.time * RotationSpeeds.z), Vector3.one);
             matrix.SetTRS(Vector3.zero, Quaternion.Euler(Time.time * RotationSpeeds.x, Time.time * RotationSpeeds.y , Time.time * RotationSpeeds.z), Vector3.one);

            m_material.SetMatrix("_EnvMatrix", matrix);

            yield return null;
        }
	}
//<<<<<<< HEAD
//}
//=======
}
//=======
//﻿using UnityEngine;
//using System.Collections;
//using TMPro;

//public class EnvMapAnimator : MonoBehaviour {

//    //private Vector3 TranslationSpeeds;
//    public Vector3 RotationSpeeds;
//    private TMP_Text m_textMeshPro;
//    private Material m_material;
    

//    void Awake()
//    {
//        //Debug.Log("Awake() on Script called.");
//        m_textMeshPro = GetComponent<TMP_Text>();
//        m_material = m_textMeshPro.fontSharedMaterial;
//    }

//    // Use this for initialization
//	IEnumerator Start ()
//    {
//        Matrix4x4 matrix = new Matrix4x4(); 
        
//        while (true)
//        {
//            //matrix.SetTRS(new Vector3 (Time.time * TranslationSpeeds.x, Time.time * TranslationSpeeds.y, Time.time * TranslationSpeeds.z), Quaternion.Euler(Time.time * RotationSpeeds.x, Time.time * RotationSpeeds.y , Time.time * RotationSpeeds.z), Vector3.one);
//             matrix.SetTRS(Vector3.zero, Quaternion.Euler(Time.time * RotationSpeeds.x, Time.time * RotationSpeeds.y , Time.time * RotationSpeeds.z), Vector3.one);

//            m_material.SetMatrix("_EnvMatrix", matrix);

//            yield return null;
//        }
//	}
//}
//>>>>>>> d7e128fa408f79ab857ef651a63541b0fe69bd15
//>>>>>>> c1fe867f9610846be86e773fdbcb61b18d60e5ad
