using System;

public class Bmi()
{
	public static void bmi()
	{
        Console.Write("키(cm) 입력 : ");
        string cmStr = Console.ReadLine();

        Console.Write("몸무게(kg) 입력 : ");
        string kgStr = Console.ReadLine();

        float bmi = (float.Parse(kgStr) / (float.Parse(cmStr) * float.Parse(cmStr))) * 10000;
        Console.WriteLine($"BMI : {bmi.ToString("N1")}");
    }

}
