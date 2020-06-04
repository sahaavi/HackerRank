#include <bits/stdc++.h>

using namespace std;


int main()
{
    int size,i,j,left_right=0,right_left=0,result=0;

    cin>>size;

    int array[size][size];

    for(i=0; i<size; i++)
    {
        for(j=0;j<size;j++)
        {
            cin>>array[i][j];
        }

    }





    for(i=0 ; i<size ;i++)
    {
        for(j=0 ; j<size ; j++)
        {
            left_right=array[i][j]+left_right;
            i++;
        }

    }


        for(i=0 ; i<size ;i++)
    {
        for(j=size-1 ; j>=0 ; j--)
        {
            right_left=array[i][j]+right_left;
            i++;
        }

    }

    result=abs(right_left-left_right);

    cout<<result;

}
