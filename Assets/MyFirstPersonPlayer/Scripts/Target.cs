/*
 * Jaden Pleasants
 * Assignment 5B
 * Manages target health
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    public float health = 50f;

    public void TakeDamage(float damage) {
        health -= damage;
        if (health <= 0f) {
            Die();
        }
    }

    private void Die() {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}
