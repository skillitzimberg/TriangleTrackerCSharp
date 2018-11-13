using System;

namespace WhatKindOfTriangle {

    class Triangle
    {
        private int SideA;
        private int SideB;
        private int SideC;

        public Triangle(int sideA, int sideB, int sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public bool IsTriangle()
        {
            if (SideA + SideB < SideC || SideA + SideC < SideB || SideB + SideC < SideA)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string WhatKindOfTriangle()
        {
            if (SideA == SideB && SideB == SideC)
            {
                return ("equilateral");
            }
            else if ((SideA == SideB && SideB != SideC)|| (SideB == SideC && SideC != SideA) || (SideA == SideC && SideC != SideB))
            {
                return ("Isosceles");
            }
            else
            {
                return ("Scalene");
            }
        }
    }
}
