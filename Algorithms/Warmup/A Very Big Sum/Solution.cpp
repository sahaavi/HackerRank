#include <bits/stdc++.h>

using namespace std;




int main()
{


    long long int ar_count,sum=0,i;


    cin >> ar_count;


    long array[ar_count];

    for(i=0;i<ar_count;i++)
    {

        cin>>array[i];

    }

    for(i=0 ; i<ar_count ; i++ )
    {
        sum=array[i]+sum;
    }


    cout<<sum;

    return 0;
}


