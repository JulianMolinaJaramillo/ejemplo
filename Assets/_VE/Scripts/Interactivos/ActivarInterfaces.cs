using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Clase que gestiona la activaci�n y desactivaci�n de interfaces y animaciones.
/// </summary>
public class ActivarInterfaces : MonoBehaviour
{
    /// <summary>
    /// Arreglo de interfaces (GameObjects) que se activar�n o desactivar�n.
    /// </summary>
    public GameObject[] interfaces;

    /// <summary>
    /// Referencia al objeto de texto que muestra el turno.
    /// </summary>
    //public Text Turno;

    /// <summary>
    /// Sistema de part�culas que se reproduce al abrir.
    /// </summary>
    public ParticleSystem particulaAbrir;

    /// <summary>
    /// Sistema de part�culas que se reproduce al cambiar de turno.
    /// </summary>
    public ParticleSystem particulaTurno;

    /// <summary>
    /// Referencia al componente Animator para controlar animaciones.
    /// </summary>
    public Animator animator;

    /// <summary>
    /// Variable booleana que indica si el objeto est� activado.
    /// </summary>
    private bool activado = false;

    /// <summary>
    /// Nombre de la animaci�n que se controlar�.
    /// </summary>
    public string NombreAnim;

    // Start is called before the first frame update
    void Start()
    {
        // Obtener la referencia al componente Animator en el objeto actual.
        animator = this.GetComponent<Animator>();

        // Verificar si el objeto tiene Animator.
        if (animator == null)
        {
            Debug.LogError("El objeto no tiene Animator.");
        }
    }

    /// <summary>
    /// M�todo llamado cuando se interact�a con el objeto.
    /// </summary>
    public void Interactuo()
    {
        // L�gica de interacci�n (a implementar seg�n necesidades).
    }

    /// <summary>
    /// M�todo llamado para encender alguna funcionalidad (a implementar seg�n necesidades).
    /// </summary>
    public void Encender()
    {
        // L�gica de encendido (a implementar seg�n necesidades).
    }

    /// <summary>
    /// M�todo llamado cuando otro collider entra en el trigger del objeto.
    /// </summary>
    /// <param name="other">Collider que entr� en el trigger.</param>
    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el collider que entr� tiene la etiqueta "Player".
        if (other.CompareTag("Player"))
        {
            // Activar la animaci�n con el nombre especificado.
            activado = true;
            animator.SetBool(NombreAnim, activado);
        }
    }

    /// <summary>
    /// M�todo llamado cuando otro collider sale del trigger del objeto.
    /// </summary>
    /// <param name="other">Collider que sali� del trigger.</param>
    private void OnTriggerExit(Collider other)
    {
        // Verificar si el collider que sali� tiene la etiqueta "Player".
        if (other.CompareTag("Player"))
        {
            // Desactivar la animaci�n con el nombre especificado.
            activado = false;
            animator.SetBool(NombreAnim, activado);
        }
    }
}