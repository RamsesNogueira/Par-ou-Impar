using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Pa_Im_C : MonoBehaviour
{

    public InputField jogador_1;
    public InputField jogador1_numero;
    public InputField ParIm_jogador1;

    public Text numero_pc;

    public Text vitoria;

    public void jogo()
    {
        int pc_number = Random.Range(0, 6);
        numero_pc.text = pc_number.ToString();

        int jogador1_numero_con = int.Parse(jogador1_numero.text);
        int soma = jogador1_numero_con + pc_number;
        int resultado = soma % 2;
        
        if (resultado == 0 && ParIm_jogador1.text == "par")
        {
            vitoria.text = soma + "é par: " + jogador_1.text + " Venceu!!!";
        }
        else if (resultado == 1 && ParIm_jogador1.text == "impar")
        {
            vitoria.text = soma + "é impar: " + jogador_1.text + " Venceu!!!";
        }
        else if (resultado == 0 && ParIm_jogador1.text == "impar")
        {
            vitoria.text = soma + "é par: PC Venceu!!! ";
        }
        else if (resultado == 1 && ParIm_jogador1.text == "par")
        {
            vitoria.text = soma + "é impar: PC Venceu!!!";
        }
    }
}
