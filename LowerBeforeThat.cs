namespace LengthyWordsReversal;

public class LowerBeforeThat
{

    public static int GetLowerBeforeThat(int inputNumber)
    {
        var tempMass  = inputNumber.ToString().ToList();
        var tempInts = new int[tempMass.Count];
        for (int i = 0; i < tempMass.Count; i++)
        {
            tempInts[i] = int.Parse(tempMass[i].ToString());
        }
        
        for (int i = tempInts.Length-1; i >= 0; i--)
        {
            for (int j = i; j >= 0; j--)
            {
                if (tempInts[i] == 0) continue;
                
                if (tempInts[i] < tempInts[j])
                {
                    (tempInts[j], tempInts[i]) = (tempInts[i], tempInts[j]);
                    return tempInts
                        .Select((t, i) => t * Convert.ToInt32(Math.Pow(10, tempInts.Length - i - 1)))
                        .Sum();
                }
            }
        }
        
        return -1;
    }
}