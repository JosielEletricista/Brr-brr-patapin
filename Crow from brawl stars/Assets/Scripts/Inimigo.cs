using UnityEngine;

public class Inimigo
{
    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (arma)
        {
            case "ESPADA":
                dano = Forca_Ataque() + 10;
                break;

            case "MACHADO"
                dano = Forca_Ataque() + 18
                break;

            case "ADAGA":
                dano = Forca_Ataque() + 5
                break;
        }   
    
        return dano;
    }
}
