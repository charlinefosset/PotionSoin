namespace Potion_soin;

/*
    CONSIGNES
    Votre personnage possède des points de vie (HP). Il peut utiliser une potion pour récupérer de la santé.
    
    Créez une méthode UsePotion() qui reçoit deux paramètres :
    - healthPoints : les points de vie actuels du personnage.
    - healingAmount : le nombre de points de vie que la potion permet de récupérer.
    
    La méthode doit afficher un message sous la forme : "Le héros possède maintenant 80 PV."

    Dans Main(), testez les situations suivantes :
    1. Le héros possède 50 PV et récupère 30 PV.
    2. Le héros possède 20 PV et récupère 50 PV.
    Pour cet exercice, il n'est pas nécessaire de limiter les PV à 100.
 */
class Program
{
    static void Main()
    {
        UsePotions(50,30);
        UsePotions(20,50);
    }

    static void UsePotions(int healthPoints, int healingAmount)
    {
        Console.WriteLine("Le héros possède " + healthPoints + " PV et récupère" + healingAmount + " PV");
        Console.WriteLine("Le héros possède maintenant " + (healthPoints + healingAmount) + " PV");
    }
    
}

    