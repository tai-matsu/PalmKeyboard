using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Input;
using TMPro;

public class HandTracking : MonoBehaviour
{
    TMP_InputField inputField;
    float finger_dis = 0.015f;
    float time_thre = 0.5f;

    bool flag_a = true, flag_i = true, flag_u = true, flag_e = true, flag_o = true;
    bool flag_ka = true, flag_ki = true, flag_ku = true, flag_ke = true, flag_ko = true;
    bool flag_sa = true, flag_si = true, flag_su = true, flag_se = true, flag_so = true;
    bool flag_ta = true, flag_ti = true, flag_tu = true, flag_te = true, flag_to = true;
    bool flag_na = true, flag_ni = true, flag_nu = true, flag_ne = true, flag_no = true;
    bool flag_ha = true, flag_hi = true, flag_hu = true, flag_he = true, flag_ho = true;
    bool flag_ma = true, flag_mi = true, flag_mu = true, flag_me = true, flag_mo = true;
    bool flag_ya = true, flag_yi = true, flag_yu = true, flag_ye = true, flag_yo = true;
    bool flag_ra = true, flag_ri = true, flag_ru = true, flag_re = true, flag_ro = true;
    bool flag_wa = true, flag_wo = true, flag_nn = true;

    float time_a = 0.0f, time_i = 0.0f, time_u = 0.0f, time_e = 0.0f, time_o = 0.0f;
    float time_ka = 0.0f, time_ki = 0.0f, time_ku = 0.0f, time_ke = 0.0f, time_ko = 0.0f;
    float time_sa = 0.0f, time_si = 0.0f, time_su = 0.0f, time_se = 0.0f, time_so = 0.0f;
    float time_ta = 0.0f, time_ti = 0.0f, time_tu = 0.0f, time_te = 0.0f, time_to = 0.0f;
    float time_na = 0.0f, time_ni = 0.0f, time_nu = 0.0f, time_ne = 0.0f, time_no = 0.0f;
    float time_ha = 0.0f, time_hi = 0.0f, time_hu = 0.0f, time_he = 0.0f, time_ho = 0.0f;
    float time_ma = 0.0f, time_mi = 0.0f, time_mu = 0.0f, time_me = 0.0f, time_mo = 0.0f;
    float time_ya = 0.0f, time_yi = 0.0f, time_yu = 0.0f, time_ye = 0.0f, time_yo = 0.0f;
    float time_ra = 0.0f, time_ri = 0.0f, time_ru = 0.0f, time_re = 0.0f, time_ro = 0.0f;
    float time_wa = 0.0f, time_wo = 0.0f, time_nn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        inputField = this.GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        //全削除
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.Palm, Handedness.Left, out MixedRealityPose leftPalm) && HandJointUtils.TryGetJointPose(TrackedHandJoint.Palm, Handedness.Right, out MixedRealityPose rightPalm))
        {
            if(Vector3.Distance(leftPalm.Position, rightPalm.Position) <= 0.02f)
            {
                inputField.text = "";
            }
        }


        //あ行
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Left, out MixedRealityPose leftPose_A))
        {
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out MixedRealityPose rightPose_a))
            {
                if(Vector3.Distance(leftPose_A.Position, rightPose_a.Position) <= finger_dis && flag_a == true)
                {
                    inputField.text += "あ";
                    flag_a = false;
                }

                if (!flag_a)
                {
                    time_a += Time.deltaTime;
                }

                if(time_a >= time_thre)
                {
                    flag_a = true;
                    time_a = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose rightPose_i))
            {
                if (Vector3.Distance(leftPose_A.Position, rightPose_i.Position) <= finger_dis && flag_i == true)
                {
                    inputField.text += "い";
                    flag_i = false;
                }

                if (!flag_i)
                {
                    time_i += Time.deltaTime;
                }

                if (time_i >= time_thre)
                {
                    flag_i = true;
                    time_i = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out MixedRealityPose rightPose_u))
            {
                if (Vector3.Distance(leftPose_A.Position, rightPose_u.Position) <= finger_dis && flag_u == true)
                {
                    inputField.text += "う";
                    flag_u = false;
                }

                if (!flag_u)
                {
                    time_u += Time.deltaTime;
                }

                if (time_u >= time_thre)
                {
                    flag_u = true;
                    time_u = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out MixedRealityPose rightPose_e))
            {
                if (Vector3.Distance(leftPose_A.Position, rightPose_e.Position) <= finger_dis && flag_e == true)
                {
                    inputField.text += "え";
                    flag_e = false;
                }

                if (!flag_e)
                {
                    time_e += Time.deltaTime;
                }

                if (time_e >= time_thre)
                {
                    flag_e = true;
                    time_e = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out MixedRealityPose rightPose_o))
            {
                if (Vector3.Distance(leftPose_A.Position, rightPose_o.Position) <= finger_dis && flag_o == true)
                {
                    inputField.text += "お";
                    flag_o = false;
                }

                if (!flag_o)
                {
                    time_o += Time.deltaTime;
                }

                if (time_o >= time_thre)
                {
                    flag_o = true;
                    time_o = 0.0f;
                }
            }
        }

        //か行
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Left, out MixedRealityPose leftPose_K))
        {
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out MixedRealityPose rightPose_a))
            {
                if (Vector3.Distance(leftPose_K.Position, rightPose_a.Position) <= finger_dis && flag_ka == true)
                {
                    inputField.text += "か";
                    flag_ka = false;
                }

                if (!flag_ka)
                {
                    time_ka += Time.deltaTime;
                }

                if (time_ka >= time_thre)
                {
                    flag_ka = true;
                    time_ka = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose rightPose_i))
            {
                if (Vector3.Distance(leftPose_K.Position, rightPose_i.Position) <= finger_dis && flag_ki == true)
                {
                    inputField.text += "き";
                    flag_ki = false;
                }

                if (!flag_ki)
                {
                    time_ki += Time.deltaTime;
                }

                if (time_ki >= time_thre)
                {
                    flag_ki = true;
                    time_ki = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out MixedRealityPose rightPose_u))
            {
                if (Vector3.Distance(leftPose_K.Position, rightPose_u.Position) <= finger_dis && flag_ku == true)
                {
                    inputField.text += "く";
                    flag_ku = false;
                }

                if (!flag_ku)
                {
                    time_ku += Time.deltaTime;
                }

                if (time_ku >= time_thre)
                {
                    flag_ku = true;
                    time_ku = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out MixedRealityPose rightPose_e))
            {
                if (Vector3.Distance(leftPose_K.Position, rightPose_e.Position) <= finger_dis && flag_ke == true)
                {
                    inputField.text += "け";
                    flag_ke = false;
                }

                if (!flag_ke)
                {
                    time_ke += Time.deltaTime;
                }

                if (time_ke >= time_thre)
                {
                    flag_ke = true;
                    time_ke = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out MixedRealityPose rightPose_o))
            {
                if (Vector3.Distance(leftPose_K.Position, rightPose_o.Position) <= finger_dis && flag_ko == true)
                {
                    inputField.text += "こ";
                    flag_ko = false;
                }

                if (!flag_ko)
                {
                    time_ko += Time.deltaTime;
                }

                if (time_ko >= time_thre)
                {
                    flag_ko = true;
                    time_ko = 0.0f;
                }
            }
        }

        //さ行
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Left, out MixedRealityPose leftPose_S))
        {
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out MixedRealityPose rightPose_a))
            {
                if (Vector3.Distance(leftPose_S.Position, rightPose_a.Position) <= finger_dis && flag_sa == true)
                {
                    inputField.text += "さ";
                    flag_sa = false;
                }

                if (!flag_sa)
                {
                    time_sa += Time.deltaTime;
                }

                if (time_sa >= time_thre)
                {
                    flag_sa = true;
                    time_sa = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose rightPose_i))
            {
                if (Vector3.Distance(leftPose_S.Position, rightPose_i.Position) <= finger_dis && flag_si == true)
                {
                    inputField.text += "し";
                    flag_si = false;
                }

                if (!flag_si)
                {
                    time_si += Time.deltaTime;
                }

                if (time_si >= time_thre)
                {
                    flag_si = true;
                    time_si = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out MixedRealityPose rightPose_u))
            {
                if (Vector3.Distance(leftPose_S.Position, rightPose_u.Position) <= finger_dis && flag_su == true)
                {
                    inputField.text += "す";
                    flag_su = false;
                }

                if (!flag_su)
                {
                    time_su += Time.deltaTime;
                }

                if (time_su >= time_thre)
                {
                    flag_su = true;
                    time_su = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out MixedRealityPose rightPose_e))
            {
                if (Vector3.Distance(leftPose_S.Position, rightPose_e.Position) <= finger_dis && flag_se == true)
                {
                    inputField.text += "せ";
                    flag_se = false;
                }

                if (!flag_se)
                {
                    time_se += Time.deltaTime;
                }

                if (time_se >= time_thre)
                {
                    flag_se = true;
                    time_se = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out MixedRealityPose rightPose_o))
            {
                if (Vector3.Distance(leftPose_S.Position, rightPose_o.Position) <= finger_dis && flag_so == true)
                {
                    inputField.text += "そ";
                    flag_so = false;
                }

                if (!flag_so)
                {
                    time_so += Time.deltaTime;
                }

                if (time_so >= time_thre)
                {
                    flag_so = true;
                    time_so = 0.0f;
                }
            }
        }

        //た行
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Left, out MixedRealityPose leftPose_T))
        {
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out MixedRealityPose rightPose_a))
            {
                if (Vector3.Distance(leftPose_T.Position, rightPose_a.Position) <= finger_dis && flag_ta == true)
                {
                    inputField.text += "た";
                    flag_ta = false;
                }

                if (!flag_ta)
                {
                    time_ta += Time.deltaTime;
                }

                if (time_ta >= time_thre)
                {
                    flag_ta = true;
                    time_ta = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose rightPose_i))
            {
                if (Vector3.Distance(leftPose_T.Position, rightPose_i.Position) <= finger_dis && flag_ti == true)
                {
                    inputField.text += "ち";
                    flag_ti = false;
                }

                if (!flag_ti)
                {
                    time_ti += Time.deltaTime;
                }

                if (time_ti >= time_thre)
                {
                    flag_ti = true;
                    time_ti = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out MixedRealityPose rightPose_u))
            {
                if (Vector3.Distance(leftPose_T.Position, rightPose_u.Position) <= finger_dis && flag_tu == true)
                {
                    inputField.text += "つ";
                    flag_tu = false;
                }

                if (!flag_tu)
                {
                    time_tu += Time.deltaTime;
                }

                if (time_tu >= time_thre)
                {
                    flag_tu = true;
                    time_tu = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out MixedRealityPose rightPose_e))
            {
                if (Vector3.Distance(leftPose_T.Position, rightPose_e.Position) <= finger_dis && flag_te == true)
                {
                    inputField.text += "て";
                    flag_te = false;
                }

                if (!flag_te)
                {
                    time_te += Time.deltaTime;
                }

                if (time_te >= time_thre)
                {
                    flag_te = true;
                    time_te = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out MixedRealityPose rightPose_o))
            {
                if (Vector3.Distance(leftPose_T.Position, rightPose_o.Position) <= finger_dis && flag_to == true)
                {
                    inputField.text += "と";
                    flag_to = false;
                }

                if (!flag_to)
                {
                    time_to += Time.deltaTime;
                }

                if (time_to >= time_thre)
                {
                    flag_to = true;
                    time_to = 0.0f;
                }
            }
        }

        //な行
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Left, out MixedRealityPose leftPose_N))
        {
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out MixedRealityPose rightPose_a))
            {
                if (Vector3.Distance(leftPose_N.Position, rightPose_a.Position) <= finger_dis && flag_na == true)
                {
                    inputField.text += "な";
                    flag_na = false;
                }

                if (!flag_na)
                {
                    time_na += Time.deltaTime;
                }

                if (time_na >= time_thre)
                {
                    flag_na = true;
                    time_na = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose rightPose_i))
            {
                if (Vector3.Distance(leftPose_N.Position, rightPose_i.Position) <= finger_dis && flag_ni == true)
                {
                    inputField.text += "に";
                    flag_ni = false;
                }

                if (!flag_ni)
                {
                    time_ni += Time.deltaTime;
                }

                if (time_ni >= time_thre)
                {
                    flag_ni = true;
                    time_ni = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out MixedRealityPose rightPose_u))
            {
                if (Vector3.Distance(leftPose_N.Position, rightPose_u.Position) <= finger_dis && flag_nu == true)
                {
                    inputField.text += "ぬ";
                    flag_nu = false;
                }

                if (!flag_nu)
                {
                    time_nu += Time.deltaTime;
                }

                if (time_nu >= time_thre)
                {
                    flag_nu = true;
                    time_nu = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out MixedRealityPose rightPose_e))
            {
                if (Vector3.Distance(leftPose_N.Position, rightPose_e.Position) <= finger_dis && flag_ne == true)
                {
                    inputField.text += "ね";
                    flag_ne = false;
                }

                if (!flag_ne)
                {
                    time_ne += Time.deltaTime;
                }

                if (time_ne >= time_thre)
                {
                    flag_ne = true;
                    time_ne = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out MixedRealityPose rightPose_o))
            {
                if (Vector3.Distance(leftPose_N.Position, rightPose_o.Position) <= finger_dis && flag_no == true)
                {
                    inputField.text += "の";
                    flag_no = false;
                }

                if (!flag_no)
                {
                    time_no += Time.deltaTime;
                }

                if (time_no >= time_thre)
                {
                    flag_no = true;
                    time_no = 0.0f;
                }
            }
        }

        //は行
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbProximalJoint, Handedness.Left, out MixedRealityPose leftPose_H))
        {
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out MixedRealityPose rightPose_a))
            {
                if (Vector3.Distance(leftPose_H.Position, rightPose_a.Position) <= finger_dis && flag_ha == true)
                {
                    inputField.text += "は";
                    flag_ha = false;
                }

                if (!flag_ha)
                {
                    time_ha += Time.deltaTime;
                }

                if (time_ha >= time_thre)
                {
                    flag_ha = true;
                    time_ha = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose rightPose_i))
            {
                if (Vector3.Distance(leftPose_H.Position, rightPose_i.Position) <= finger_dis && flag_hi == true)
                {
                    inputField.text += "ひ";
                    flag_hi = false;
                }

                if (!flag_hi)
                {
                    time_hi += Time.deltaTime;
                }

                if (time_hi >= time_thre)
                {
                    flag_hi = true;
                    time_hi = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out MixedRealityPose rightPose_u))
            {
                if (Vector3.Distance(leftPose_H.Position, rightPose_u.Position) <= finger_dis && flag_hu == true)
                {
                    inputField.text += "ふ";
                    flag_hu = false;
                }

                if (!flag_hu)
                {
                    time_hu += Time.deltaTime;
                }

                if (time_hu >= time_thre)
                {
                    flag_hu = true;
                    time_hu = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out MixedRealityPose rightPose_e))
            {
                if (Vector3.Distance(leftPose_H.Position, rightPose_e.Position) <= finger_dis && flag_he == true)
                {
                    inputField.text += "へ";
                    flag_he = false;
                }

                if (!flag_he)
                {
                    time_he += Time.deltaTime;
                }

                if (time_he >= time_thre)
                {
                    flag_he = true;
                    time_he = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out MixedRealityPose rightPose_o))
            {
                if (Vector3.Distance(leftPose_H.Position, rightPose_o.Position) <= finger_dis && flag_ho == true)
                {
                    inputField.text += "ほ";
                    flag_ho = false;
                }

                if (!flag_ho)
                {
                    time_ho += Time.deltaTime;
                }

                if (time_ho >= time_thre)
                {
                    flag_ho = true;
                    time_ho = 0.0f;
                }
            }
        }

        //ま行
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexKnuckle, Handedness.Left, out MixedRealityPose leftPose_M))
        {
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out MixedRealityPose rightPose_a))
            {
                if (Vector3.Distance(leftPose_M.Position, rightPose_a.Position) <= finger_dis && flag_ma == true)
                {
                    inputField.text += "ま";
                    flag_ma = false;
                }

                if (!flag_ma)
                {
                    time_ma += Time.deltaTime;
                }

                if (time_ma >= time_thre)
                {
                    flag_ma = true;
                    time_ma = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose rightPose_i))
            {
                if (Vector3.Distance(leftPose_M.Position, rightPose_i.Position) <= finger_dis && flag_mi == true)
                {
                    inputField.text += "み";
                    flag_mi = false;
                }

                if (!flag_mi)
                {
                    time_mi += Time.deltaTime;
                }

                if (time_mi >= time_thre)
                {
                    flag_mi = true;
                    time_mi = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out MixedRealityPose rightPose_u))
            {
                if (Vector3.Distance(leftPose_M.Position, rightPose_u.Position) <= finger_dis && flag_mu == true)
                {
                    inputField.text += "む";
                    flag_mu = false;
                }

                if (!flag_mu)
                {
                    time_mu += Time.deltaTime;
                }

                if (time_mu >= time_thre)
                {
                    flag_mu = true;
                    time_mu = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out MixedRealityPose rightPose_e))
            {
                if (Vector3.Distance(leftPose_M.Position, rightPose_e.Position) <= finger_dis && flag_me == true)
                {
                    inputField.text += "め";
                    flag_me = false;
                }

                if (!flag_me)
                {
                    time_me += Time.deltaTime;
                }

                if (time_me >= time_thre)
                {
                    flag_me = true;
                    time_me = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out MixedRealityPose rightPose_o))
            {
                if (Vector3.Distance(leftPose_M.Position, rightPose_o.Position) <= finger_dis && flag_mo == true)
                {
                    inputField.text += "も";
                    flag_mo = false;
                }

                if (!flag_mo)
                {
                    time_mo += Time.deltaTime;
                }

                if (time_mo >= time_thre)
                {
                    flag_mo = true;
                    time_mo = 0.0f;
                }
            }
        }

        //や行
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleKnuckle, Handedness.Left, out MixedRealityPose leftPose_Y))
        {
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out MixedRealityPose rightPose_a))
            {
                if (Vector3.Distance(leftPose_Y.Position, rightPose_a.Position) <= finger_dis && flag_ya == true)
                {
                    inputField.text += "や";
                    flag_ya = false;
                }

                if (!flag_ya)
                {
                    time_ya += Time.deltaTime;
                }

                if (time_ya >= time_thre)
                {
                    flag_ya = true;
                    time_ya = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose rightPose_i))
            {
                if (Vector3.Distance(leftPose_Y.Position, rightPose_i.Position) <= finger_dis && flag_yi == true)
                {
                    inputField.text += "い";
                    flag_yi = false;
                }

                if (!flag_yi)
                {
                    time_yi += Time.deltaTime;
                }

                if (time_yi >= time_thre)
                {
                    flag_yi = true;
                    time_yi = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out MixedRealityPose rightPose_u))
            {
                if (Vector3.Distance(leftPose_Y.Position, rightPose_u.Position) <= finger_dis && flag_yu == true)
                {
                    inputField.text += "ゆ";
                    flag_yu = false;
                }

                if (!flag_yu)
                {
                    time_yu += Time.deltaTime;
                }

                if (time_yu >= time_thre)
                {
                    flag_yu = true;
                    time_yu = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out MixedRealityPose rightPose_e))
            {
                if (Vector3.Distance(leftPose_Y.Position, rightPose_e.Position) <= finger_dis && flag_ye == true)
                {
                    inputField.text += "いぇ";
                    flag_ye = false;
                }

                if (!flag_ye)
                {
                    time_ye += Time.deltaTime;
                }

                if (time_ye >= time_thre)
                {
                    flag_ye = true;
                    time_ye = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out MixedRealityPose rightPose_o))
            {
                if (Vector3.Distance(leftPose_Y.Position, rightPose_o.Position) <= finger_dis && flag_yo == true)
                {
                    inputField.text += "よ";
                    flag_yo = false;
                }

                if (!flag_yo)
                {
                    time_yo += Time.deltaTime;
                }

                if (time_yo >= time_thre)
                {
                    flag_yo = true;
                    time_yo = 0.0f;
                }
            }
        }

        //ら行
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingKnuckle, Handedness.Left, out MixedRealityPose leftPose_R))
        {
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out MixedRealityPose rightPose_a))
            {
                if (Vector3.Distance(leftPose_R.Position, rightPose_a.Position) <= finger_dis && flag_ra == true)
                {
                    inputField.text += "ら";
                    flag_ra = false;
                }

                if (!flag_ra)
                {
                    time_ra += Time.deltaTime;
                }

                if (time_ra >= time_thre)
                {
                    flag_ra = true;
                    time_ra = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose rightPose_i))
            {
                if (Vector3.Distance(leftPose_R.Position, rightPose_i.Position) <= finger_dis && flag_ri == true)
                {
                    inputField.text += "り";
                    flag_ri = false;
                }

                if (!flag_ri)
                {
                    time_ri += Time.deltaTime;
                }

                if (time_ri >= time_thre)
                {
                    flag_ri = true;
                    time_ri = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out MixedRealityPose rightPose_u))
            {
                if (Vector3.Distance(leftPose_R.Position, rightPose_u.Position) <= finger_dis && flag_ru == true)
                {
                    inputField.text += "る";
                    flag_ru = false;
                }

                if (!flag_ru)
                {
                    time_ru += Time.deltaTime;
                }

                if (time_ru >= time_thre)
                {
                    flag_ru = true;
                    time_ru = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out MixedRealityPose rightPose_e))
            {
                if (Vector3.Distance(leftPose_R.Position, rightPose_e.Position) <= finger_dis && flag_re == true)
                {
                    inputField.text += "れ";
                    flag_re = false;
                }

                if (!flag_re)
                {
                    time_re += Time.deltaTime;
                }

                if (time_re >= time_thre)
                {
                    flag_re = true;
                    time_re = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out MixedRealityPose rightPose_o))
            {
                if (Vector3.Distance(leftPose_R.Position, rightPose_o.Position) <= finger_dis && flag_ro == true)
                {
                    inputField.text += "ろ";
                    flag_ro = false;
                }

                if (!flag_ro)
                {
                    time_ro += Time.deltaTime;
                }

                if (time_ro >= time_thre)
                {
                    flag_ro = true;
                    time_ro = 0.0f;
                }
            }
        }

        //わ行
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyKnuckle, Handedness.Left, out MixedRealityPose leftPose_W))
        {
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out MixedRealityPose rightPose_a))
            {
                if (Vector3.Distance(leftPose_W.Position, rightPose_a.Position) <= finger_dis && flag_wa == true)
                {
                    inputField.text += "わ";
                    flag_wa = false;
                }

                if (!flag_wa)
                {
                    time_wa += Time.deltaTime;
                }

                if (time_wa >= time_thre)
                {
                    flag_wa = true;
                    time_wa = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose rightPose_i))
            {
                if (Vector3.Distance(leftPose_W.Position, rightPose_i.Position) <= finger_dis && flag_wo == true)
                {
                    inputField.text += "を";
                    flag_wo = false;
                }

                if (!flag_wo)
                {
                    time_wo += Time.deltaTime;
                }

                if (time_wo >= time_thre)
                {
                    flag_wo = true;
                    time_wo = 0.0f;
                }
            }

            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out MixedRealityPose rightPose_u))
            {
                if (Vector3.Distance(leftPose_W.Position, rightPose_u.Position) <= finger_dis && flag_nn == true)
                {
                    inputField.text += "ん";
                    flag_nn = false;
                }

                if (!flag_nn)
                {
                    time_nn += Time.deltaTime;
                }

                if (time_nn >= time_thre)
                {
                    flag_nn = true;
                    time_nn = 0.0f;
                }
            }
        }
    }
}
