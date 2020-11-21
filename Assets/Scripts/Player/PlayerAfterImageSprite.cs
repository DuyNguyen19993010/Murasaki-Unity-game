﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//--------------------------------------Used for spawing ghost image of player when dashing
public class PlayerAfterImageSprite : MonoBehaviour
{
    [SerializeField]
    private float activeTime = 0.1f;
    private float timeActivated;
    private float alpha;
    [SerializeField]
    private float alphaSet = 0.8f;
    private float alphaMultiplier = 0.85f;


    private Transform player;
    private SpriteRenderer SR;
    private SpriteRenderer playerSR;
    private Color color;


    private void OnEnable()
    {
        SR = GetComponent<SpriteRenderer>();
        player = GameObject.Find("Player").transform;
        playerSR = player.GetComponent<SpriteRenderer>();

        alpha = alphaSet;
        SR.sprite = playerSR.sprite;
        transform.position = player.position;
        transform.rotation = player.transform.rotation;
        timeActivated = Time.time;
    }
    void Update()
    {
        alpha *= alphaMultiplier;
        color = new Color(1f, 1f, 1f, alpha);
        SR.color = color;
        if (Time.time >= (timeActivated + activeTime))
        {
            //Add back to pool
            PlayerAfterImagePool.Instance.AddToPool(gameObject);

        }
    }
}
