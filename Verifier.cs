namespace knightmoves;
public class Verifier
{
    // Add your code here
    public string OldEnough(int age){
        if (age > 17){
            return "old enough";
        }
            return "";
    }
    
    public string UnderAge(int age){
        if (age < 18){
            return "under age";
        }
            return "";
    }
    
    public string LegalSpeed(int speed){
        if (speed <= 50){
            return "legal speed";
        }
            return "";
    }
    
    public string GoldenYears(int age){
        if (age >= 65){
            return "golden years";
        }
            return "";
    }
}
