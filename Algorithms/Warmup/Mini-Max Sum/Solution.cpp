#include <bits/stdc++.h>

using namespace std;



int main()
{
  long int array[5],max,min,max_index=0,min_index=0,max_sum=0,min_sum=0,i;

  for(i=0;i<5;i++)
  {
      cin>>array[i];
  }


  max=array[0];


  for(i=0;i<5;i++)
  {
      if(array[i]>max)
      {
         max=array[i];
         max_index=i;
      }
  }

  min=array[0];

  for(i=0;i<5;i++)
  {
      if(array[i]<min)
      {
         min=array[i];
         min_index=i;
      }
  }



    for(i=0;i<5;i++)
  {
      if(i!=max_index)
      {
            max_sum=max_sum+array[i];
      }


  }


    for(i=0;i<5;i++)
  {
      if(i!=min_index)
      {
          min_sum=min_sum+array[i];
      }


  }


  cout<<max_sum<<" "<<min_sum;


}
