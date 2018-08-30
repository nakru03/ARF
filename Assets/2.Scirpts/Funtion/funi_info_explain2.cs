using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class funi_info_explain2 : MonoBehaviour
{
    [SerializeField]
    public Text inform = null;

    void Update()
    {
        if (GameObject.Find("Target2").transform.Find("Cube").gameObject.activeInHierarchy == true)
        {

            inform.text = "";
        }

        if (GameObject.Find("Target2").transform.Find("table2_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "상판에는 일자형 다리를 쉽게 조립할 수 있도록 나사 구멍이 뚫려 있습니다. 다리받침의 높이를 조절할 수 있어서 고르지 않은 바닥에도 안정적으로 세울 수 있습니다.";
        }

        if (GameObject.Find("Target2").transform.Find("table2_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "강화유리 상판은 얼룩이 잘 생기지 않고 청소가 편합니다. 다리받침의 높이를 조절할 수 있어서 고르지 않은 바닥에도 안정적으로 세울 수 있습니다.";
        }

        if (GameObject.Find("Target2").transform.Find("table2_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "식탁으로도 사용할 수 있으며 방수처리가 되어 있어서 쉽게 잘 닦입니다. 뾰족한 모서리가 없고 부드러운 느낌을 주는 제품으로 아이 책상으로도 사용할 수 있습니다.";
        }

        if (GameObject.Find("Target2").transform.Find("bed2_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "침대 옆판은 매트리스의 두께에 따라 위치를 조절할 수 있습니다. 자작나무 접착목 17개가 체중에 따라 몸을 받쳐주고 매트리스와 탄성을 살려줍니다.";
        }

        if (GameObject.Find("Target2").transform.Find("bed2_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "무늬목 침대로 시간이 흐를수록 멋스러워집니다. 침대 옆판은 매트리스의 두께에 따라 위치를 조절할 수 있습니다. 자작나무 접착목 17개가 체중에 따라 몸을 받쳐주고 매트리스의 탄성을 살려줍니다.";
        }

        if (GameObject.Find("Target2").transform.Find("bed2_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "침대헤드가 푹신해서 편안하게 기대고 책을 읽거나 TV를 볼 수 있습니다. 커버를 물세탁할 수 있어서 위생적입니다. 참나무 무늬목에 브러시 작업을 하고 무광택 래커로 마무리하여 자연스러운 나뭇결과 질감을 강조했습니다.";
        }

        if (GameObject.Find("Target2").transform.Find("chair2_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "파우더코팅스틸과 플라스틱 소재를 사용하여 내구성이 뛰어나고 관리가 편합니다. 차곡차곡 쌓아둘 수 있어서 여러 개의 의자를 한 곳에 보관해둘 수 있습니다.";
        }

        if (GameObject.Find("Target2").transform.Find("chair2_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "세련된 디자인으로 어디에든 잘 어울립니다. 새로운 분위기를 연출하고 싶다면 커버를 바꿀 수 있습니다. 커버를 벗겨서 물세탁할 수 있습니다.";
        }

        if (GameObject.Find("Target2").transform.Find("chair2_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "의자다리는 원목소재를 사용하여 내구성이 뛰어납니다. 의자 커버는 물세탁이 가능하며 쉽게 벗기고 씌울 수 있습니다. 등받이가 높고 의자시트에 폴리에스테르 충전재를 넣어서 편안하게 앉을 수 있습니다.";
        }



    }
}
