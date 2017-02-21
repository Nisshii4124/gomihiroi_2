using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelect : MonoBehaviour
{
    public Image STAGE1_Back;
    public Image STAGE2_Back;
    public Image STAGE3_Back;

    Image FadeImage;          // フェードに利用する画像保存用変数

    int SelectStage;

    bool isFade;        // フェードスイッチ
    bool isFadeIn;      // フェードインフラグ
    bool isFadeOut;     // フェードアウトフラグ

    float alpha;
    float alpha1;
    float alpha2;
    float alpha3;

    // Use this for initialization
    void Start ()
    {
        isFade = true;  // フェードON
        isFadeIn = true;  // フェードインON
        isFadeOut = false; // フェードアウトOFF

        SelectStage = 0;

        alpha1 = 0.0f;
        alpha2 = 0.0f;
        alpha3 = 0.0f;

        // 画像のアルファ値をセット
        //STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);
        //STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);
        //STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);
    }

    // Update is called once per frame
    void Update ()
    {
		switch(SelectStage)
        {
            case1:
                // 画像のアルファ値を変更
                FadeImage.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);
                FadeIn();
                break;
        }
    }

    // フェードイン（透明にしていく）
    void FadeIn()
    {
        // 計算用アルファ値を減算
        alpha -= 0.04f;

        // アルファ値がMIN値以下になったら
        if (FadeImage.color.a <= 0.0f)
        {
            isFade = false;                      // フェードスイッチOFF
            isFadeIn = false;                      // フェードインフラグOFF
        }
}
    // フェードアウト（不透明にしていく）
    void FadeOut()
    {
        alpha += 0.04f; // 計算用アルファ値を加算

        // 画像のアルファ値を変更
        FadeImage.color = new Color(FadeImage.color.r, FadeImage.color.g, FadeImage.color.b, alpha);

        // アルファ値がMAX値以上になったら
        if (FadeImage.color.a >= 1.0f)
        {
            isFade = false;                        // フェードスイッチOFF
            isFadeOut = false;                        // フェードアウトフラグOFF
        }
    }
}
