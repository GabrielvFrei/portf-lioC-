/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    int [,] quadrado = new int[2,3];
    quadrado[0,0] = 1; quadrado [0,1] = 2; quadrado[0,2] = 3;
    quadrado[1,0] = 4; quadrado [1,1] = 5; quadrado[1,2] = 6;
    
    for(int i = 0 ; i<2 ; i++){
        for(int j = 0 ; j < 3 ; j++){
            Console.WriteLine(quadrado[i,j]);
        }
    }
  }
}