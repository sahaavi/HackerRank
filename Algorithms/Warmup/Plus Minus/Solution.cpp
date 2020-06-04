#include <bits/stdc++.h>
#include <iostream>


using namespace std;


int main()
{
     float zero=0,pos=0,neg=0;
     int i,size;
     cin>>size;

     float array[size];

     for(i=0 ; i<size ; i++)
     {
         cin>>array[i];
     }

        for(i=0 ; i<size ; i++)
     {
           if(array[i]==0)
           {
               zero=zero+1;
           }
           else if(array[i]>0)
           {
                pos=pos+1;
           }
           else if(array[i]<0)
           {
                 neg=neg+1;
           }

     }

    float pos_ratio= pos/size;
    float neg_ratio= neg/size;
    float zero_ratio=zero/size;



    cout << std::fixed << std::setprecision(6) << pos_ratio << endl;
    cout << std::fixed << std::setprecision(6) << neg_ratio << endl;
    cout << std::fixed << std::setprecision(6) << zero_ratio << endl;

}

