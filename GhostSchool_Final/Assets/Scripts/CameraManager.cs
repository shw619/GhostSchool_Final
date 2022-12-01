using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    static public CameraManager instance;
    public GameObject target;   //카메라가 따라갈 대상
    public float moveSpeed; //카메라의 속도
    private Vector3 targetPosition; //대상의 현재 위치

    public BoxCollider2D bound;

    //박스 컬라이더 영역의 최대 최소값
    private Vector3 minBound;
    private Vector3 maxBound;

    //카메라의 반너비, 반높이
    private float halfWidth;
    private float halfHeight;

    //카메라의 반높이 값을 구하기 위한 속성 이용
    private Camera theCamera;

    //start보다 더 먼저 실행되는 함수
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //맵을 이동해도 카메라를 파괴시키지 않는다.
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        theCamera = GetComponent<Camera>();
        minBound = bound.bounds.min;
        maxBound = bound.bounds.max;
        halfHeight = theCamera.orthographicSize;
        halfWidth = halfHeight * Screen.width / Screen.height;

    }

    // 카메라는 매 프레임마다 업데이트 되어야하기 때문에 여기서
    void Update()
    {
        if (target.gameObject != null)
        {
            //this는 생략이 가능하고 카메라를 의미한다. 카메라의 z값은 타겟보다 멀리있어야 타겟이 화면에 나올 수 있다.
            targetPosition.Set(target.transform.position.x, target.transform.position.y+3, this.transform.position.z);
            //Time.deltaTime은 1초에 실행되는 프레임의 역수이며 1초에 moveSpeed만큼 이동하게 해준다. 
            //카메라의 위치를 변화시킨다. 
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);

            //clamp란 (x,0,100)이 있을 때 x가 0보다 작으면 0이고, 100보다 크면 100을 리턴한다. 
            float clampedX = Mathf.Clamp(this.transform.position.x, minBound.x + halfWidth, maxBound.x - halfWidth);
            float clampedY = Mathf.Clamp(this.transform.position.y, minBound.y + halfHeight, maxBound.y - halfHeight);

            this.transform.position = new Vector3(clampedX, clampedY, this.transform.position.z);
        }

    }

    public void SetBound(BoxCollider2D newBound)
    {
        bound = newBound;
        minBound = bound.bounds.min;
        maxBound = bound.bounds.max;
    }

}

