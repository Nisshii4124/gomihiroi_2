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

    public static float SelectStage;

    bool isFadeIn;      // フェードインフラグ
    bool isFadeOut;     // フェードアウトフラグ

    float alpha;
    float alpha1;
    float alpha2;
    float alpha3;

    // Use this for initialization
    void Start()
    {
        isFadeIn = true;  // フェードインON
        isFadeOut = false; // フェードアウトOFF

        SelectStage = 1;

        alpha1 = 0.0f;
        alpha2 = 0.0f;
        alpha3 = 0.0f;

        // 画像のアルファ値をセット
        STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);
        STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);
        STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SelectStage++;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SelectStage--;
        }
        if (SelectStage == 1)
        {
            alpha2 = 0.0f;
            // 画像のアルファ値を変更
            STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);

            alpha3 = 0.0f;
            // 画像のアルファ値を変更
            STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);

            if (isFadeIn == true)
            {
                // 計算用アルファ値を減算
                alpha1 -= 0.02f;

                // 画像のアルファ値を変更
                STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);

                // アルファ値がMIN値以下になったら
                if (STAGE1_Back.color.a <= 0.0f)
                {
                    isFadeIn = false;                      // フェードスイッチOFF
                    isFadeOut = true;                      // フェードインフラグOFF
                }
            }
            if (isFadeOut == true)
            {
                alpha1 += 0.02f; // 計算用アルファ値を加算

                // 画像のアルファ値を変更
                STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);

                // アルファ値がMAX値以上になったら
                if (STAGE1_Back.color.a >= 1.0f)
                {
                    isFadeIn = true;                        // フェードスイッチOFF
                    isFadeOut = false;                        // フェードアウトフラグOFF
                }
            }
        }
        if (SelectStage == 2)
        {
            alpha1 = 0.0f;
            // 画像のアルファ値を変更
            STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);

            alpha3 = 0.0f;
            // 画像のアルファ値を変更
            STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);

            if (isFadeIn == true)
            {
                // 計算用アルファ値を減算
                alpha2 -= 0.02f;

                // 画像のアルファ値を変更
                STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);

                // アルファ値がMIN値以下になったら
                if (STAGE2_Back.color.a <= 0.0f)
                {
                    isFadeIn = false;                      // フェードスイッチOFF
                    isFadeOut = true;                      // フェードインフラグOFF
                }
            }
            if (isFadeOut == true)
            {
                alpha2 += 0.02f; // 計算用アルファ値を加算

                // 画像のアルファ値を変更
                STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);

                // アルファ値がMAX値以上になったら
                if (STAGE2_Back.color.a >= 1.0f)
                {
                    isFadeIn = true;                        // フェードスイッチOFF
                    isFadeOut = false;                        // フェードアウトフラグOFF
                }
            }
        }
        if (SelectStage == 3)
        {
            alpha1 = 0.0f;
            // 画像のアルファ値を変更
            STAGE1_Back.color = new Color(STAGE1_Back.color.r, STAGE1_Back.color.g, STAGE1_Back.color.b, alpha1);

            alpha2 = 0.0f;
            // 画像のアルファ値を変更
            STAGE2_Back.color = new Color(STAGE2_Back.color.r, STAGE2_Back.color.g, STAGE2_Back.color.b, alpha2);

            if (isFadeIn == true)
            {
                // 計算用アルファ値を減算
                alpha3 -= 0.02f;

                // 画像のアルファ値を変更
                STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);

                // アルファ値がMIN値以下になったら
                if (STAGE3_Back.color.a <= 0.0f)
                {
                    isFadeIn = false;                      // フェードスイッチOFF
                    isFadeOut = true;                      // フェードインフラグOFF
                }
            }
            if (isFadeOut == true)
            {
                alpha3 += 0.02f; // 計算用アルファ値を加算

                // 画像のアルファ値を変更
                STAGE3_Back.color = new Color(STAGE3_Back.color.r, STAGE3_Back.color.g, STAGE3_Back.color.b, alpha3);

                // アルファ値がMAX値以上になったら
                if (STAGE3_Back.color.a >= 1.0f)
                {
                    isFadeIn = true;                        // フェードスイッチOFF
                    isFadeOut = false;                        // フェードアウトフラグOFF
                }
            }
        }
        if (SelectStage <= 0) SelectStage = 1f;
        if (SelectStage >= 4) SelectStage = 3f;
    }

    // フェードイン（透明にしていく）
    void FadeIn()
    {
        if (isFadeIn == true)
        {
            // 計算用アルファ値を減算
            alpha -= 0.02f;

            // 画像のアルファ値を変更
            FadeImage.color = new Color(FadeImage.color.r, FadeImage.color.g, FadeImage.color.b, alpha);

            // アルファ値がMIN値以下になったら
            if (FadeImage.color.a <= 0.0f)
            {
                isFadeIn = false;                      // フェードスイッチOFF
                isFadeOut = true;                      // フェードインフラグOFF
            }
        }
    }
<<<<<<< HEAD
=======




>>>>>>> d74349df691959d67bda188e9c2b8dd91a32180c
    // フェードアウト（不透明にしていく）
    void FadeOut()
    {
        if (isFadeOut == true)
        {
            alpha += 0.02f; // 計算用アルファ値を加算

            // 画像のアルファ値を変更
            FadeImage.color = new Color(FadeImage.color.r, FadeImage.color.g, FadeImage.color.b, alpha);

            // アルファ値がMAX値以上になったら
            if (FadeImage.color.a >= 1.0f)
            {
                isFadeIn = true;                        // フェードスイッチOFF
                isFadeOut = false;                        // フェードアウトフラグOFF
            }
        }
    }
}

