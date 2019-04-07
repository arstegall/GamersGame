using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMouseMove : MonoBehaviour
{
    Vector2 mouseLook;      //lijevo-desno/gore-dole
    Vector2 smoothV;    //kontrola prijelaza, vizualno ljepse

    public float sensitivity = 3f;      //osjetljivost pokreta
    public float smoothing = 2f;        //glatkost

    GameObject lik;     //uzimamo naseg lika za kretnje

    void Start()
    {
        lik = this.transform.parent.gameObject;     //uzimamo roditelja od kamera kao nas objekt -> roditelj je lik
    }

    void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));     //registriraju se direkcije misa i spremaju u varijablu

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));  //uzimamo u obzir sensitivity i smoothing faktor
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);        //za linerane kretnje izmedu dve tocke
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);        //linearne kretnje izmedu dve tocke za drugu koodrinatu
        mouseLook += smoothV;       //dodamo smoothing(glatkocu) pokretu

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);        //primjena kretnje
        lik.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, lik.transform.up);  //primjena kretnje
    }
}
