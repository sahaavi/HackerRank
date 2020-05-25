using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int solve(int totalPagesInBook, int targetPageNumber){
        var minimumPagesToTurn = 0;

            if (targetPageNumber == 1 || targetPageNumber == totalPagesInBook)
                return minimumPagesToTurn;

            if (totalPagesInBook % 2 != 0 && targetPageNumber == totalPagesInBook - 1)
                return minimumPagesToTurn;


            if (totalPagesInBook % 2 == 0)
            {
                //even number of total pages e.g. 10
                if (targetPageNumber <= totalPagesInBook / 2)
                {
                    //start from front
                    minimumPagesToTurn = targetPageNumber / 2;
                }
                else
                {
                    //start from end
                    double d = ((double)(totalPagesInBook - targetPageNumber)) / 2;
                    minimumPagesToTurn = (int)Math.Ceiling(d);
                }
            }
            else
            {
                //total number of pages are odd

                //special handling for exactly middle number when total number of pages are like 3,7,11,15...and so on

                if (targetPageNumber == (totalPagesInBook/2)+1 && totalPagesInBook % 4 == 3)
                {
                    //this requires special handling as this median will be close to the end instead
                    minimumPagesToTurn = (totalPagesInBook - targetPageNumber) / 2;
                }
                else
                {
                    if (targetPageNumber <= ((totalPagesInBook / 2) + 1))
                    {
                        //start from front
                        minimumPagesToTurn = targetPageNumber / 2;
                    }
                    else
                    {
                        //start from end
                        minimumPagesToTurn = (totalPagesInBook - targetPageNumber) / 2;
                    }
                }

            }
            return minimumPagesToTurn;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int result = solve(n, p);
        Console.WriteLine(result);
    }
}
