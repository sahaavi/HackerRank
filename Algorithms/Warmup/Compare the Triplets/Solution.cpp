#include <bits/stdc++.h>

using namespace std;


int main()
{

  int i,a[3],b[3],ans[2],alice=0,bob=0;

  for(i=0 ; i<3 ; i++)
  {

    cin>>a[i];

  }

   for(i=0 ; i<3 ; i++)
  {

    cin>>b[i];

  }

     for(i=0;i<3;i++)
    {
        if(a[i]>b[i])
        {
            alice++;
        }
        else if(a[i]<b[i])
        {
             bob++;
        }
        else if(a[i] == b[i])
        {
            alice=alice+0;
            bob=bob+0;
        }
   }
   ans[0]=alice;
   ans[1]=bob;

   cout<<ans[0]<<" ";
   cout<<ans[1];

}


