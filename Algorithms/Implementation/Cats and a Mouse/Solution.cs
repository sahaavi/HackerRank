using System;

class Solution {

    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z) {
        int xdis=0;
        int ydis=0;
        string a= "Cat A";
        string b= "Cat B";
        string c= "Mouse C";
        if(x<z){
            xdis=z-x;
        }
        else if(x>z){
            xdis=x-z;
        }
        if(y<z){
            ydis=z-y;
        }
        else if(y>z){
            ydis=y-z;
        }
        if(xdis<ydis){
            return a;
        }
        else if(xdis>ydis){
            return b;
        }
        else {
            return c;
        }

    }

    static void Main(string[] args) {

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string[] xyz = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xyz[0]);

            int y = Convert.ToInt32(xyz[1]);

            int z = Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);

            Console.WriteLine(result);
        }
    }
}
