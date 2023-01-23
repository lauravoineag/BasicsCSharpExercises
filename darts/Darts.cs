using System;
using System.Collections.Generic;
using System.Reflection;

public static class Darts
{
    public static int[] Score(int[,] arrays)
    {
        
        List<int> listOfPoints = new List<int>();
        for (int i=0; i < arrays.GetLength(0); i++)
        {
            var units = ConvertToUnit(arrays [i,0], arrays[i,1]);
            var points = ConvertToPoints(units);
            listOfPoints.Add(points);
        }
        return listOfPoints.ToArray();
    }

    public  static double ConvertToUnit(int x, int y)
    {
        double tempX = (x - 0);
        double tempY = (y - 0);
        double tempXSqaured = Math.Pow(tempX, 2);
        double tempYSqaured = Math.Pow(tempY, 2);
        return Math.Sqrt(tempXSqaured + tempYSqaured);
    }

    public static int ConvertToPoints(double units)
    {
        if (units > 10) { return 0; }
        if (units is <= 10 and > 5) { return 1; }
        if (units is <= 5 and > 1) { return 5; }
        if (units <= 1) { return 10;}
        return -1;
    }
}
public static class Triangle
    
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        var scalene = side1 != side2 && side1 != side3 && side2 != side3;
        var condition1 = side1 + side2 >= side3;
        var condition2 = side2 + side3 >= side1;
        var  condition3 = side1 + side3 >= side2;  
        
        var triangleInequality = condition1==true && condition2==true && condition3==true;
        return scalene && triangleInequality;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        var isoscel = side1 == side2 || side2 == side3 || side3 == side1;
        var condition1= side1 + side2 >= side3;
        var condition2 = side2 + side3 >= side1;
        var  condition3 = side1 + side3 >= side2;  
        
        var triangleInequality = condition1==true && condition2==true && condition3==true;
        return isoscel && triangleInequality;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if ((side1 == side2) && (side2 == side3) && (side3 == side1) && side1 > 0 && side2 !=0 & side3 !=0) {return true;}
        return false;
    };