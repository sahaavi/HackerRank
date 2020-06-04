#include <bits/stdc++.h>

using namespace std;



int birthdayCakeCandles(int array[],int size);

int main()
{

    int count,size,i;

   cin>>size;

   int array[size];

     for(i=0;i<size;i++)
   {
     cin>>array[i];
   }

  count= birthdayCakeCandles(array,size);



   cout<<count;


    return 0;

}

int birthdayCakeCandles(int array[],int size)
{   int i,max=0,count=0;

    max=array[0];


    for(i=0;i<size;i++)
   {
     if(array[i]>max)
     {
         max=array[i];
     }
   }

    for(i=0;i<size;i++)
   {
     if(array[i]==max)
     {
         count=count+1;
     }
   }

   return count;


}



