using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    static public CameraManager instance;
    public GameObject target;   //ī�޶� ���� ���
    public float moveSpeed; //ī�޶��� �ӵ�
    private Vector3 targetPosition; //����� ���� ��ġ

    public BoxCollider2D bound;

    //�ڽ� �ö��̴� ������ �ִ� �ּҰ�
    private Vector3 minBound;
    private Vector3 maxBound;

    //ī�޶��� �ݳʺ�, �ݳ���
    private float halfWidth;
    private float halfHeight;

    //ī�޶��� �ݳ��� ���� ���ϱ� ���� �Ӽ� �̿�
    private Camera theCamera;

    //start���� �� ���� ����Ǵ� �Լ�
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //���� �̵��ص� ī�޶� �ı���Ű�� �ʴ´�.
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

    // ī�޶�� �� �����Ӹ��� ������Ʈ �Ǿ���ϱ� ������ ���⼭
    void Update()
    {
        if (target.gameObject != null)
        {
            //this�� ������ �����ϰ� ī�޶� �ǹ��Ѵ�. ī�޶��� z���� Ÿ�ٺ��� �ָ��־�� Ÿ���� ȭ�鿡 ���� �� �ִ�.
            targetPosition.Set(target.transform.position.x, target.transform.position.y+3, this.transform.position.z);
            //Time.deltaTime�� 1�ʿ� ����Ǵ� �������� �����̸� 1�ʿ� moveSpeed��ŭ �̵��ϰ� ���ش�. 
            //ī�޶��� ��ġ�� ��ȭ��Ų��. 
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);

            //clamp�� (x,0,100)�� ���� �� x�� 0���� ������ 0�̰�, 100���� ũ�� 100�� �����Ѵ�. 
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

