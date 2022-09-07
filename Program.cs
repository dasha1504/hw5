/* Console.WriteLine("Input array size");
int size = int.Parse(Console.ReadLine());
int [] array = new int[size];
for(int i =0; i<size; i++)
{
    array[i] = new Random().Next(1, 999);
}
int count =0;
for(int i=0; i<size; i++)
{
 if(array[i]%2 == 0)
 {
 count += 1;
 }  
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine(count); */
/* int [] array = new int[10];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
}
Console.WriteLine(string.Join(",", array));
int sum = 0;
int j = 1;
while(j<array.Length)
{
    sum = sum + array[j];
    j=j+2;

}
Console.WriteLine(sum);
 */
///
//
//
/* Console.WriteLine("Input array size");
int size = int.Parse(Console.ReadLine());
int [] array = new int[size];
for(int i =0; i<size; i++)
{
    array[i] = new Random().Next(1, 999);
}
int mx = array[0];
int mn = array[0];
for(int i = 0; i<array.Length; i++)
{
if(array[i]>mx)
{
mx = array[i];
i++;
}
if(mn>array[i])
{
    mn = array[i];
    i++;
}
}
int result = (mx) - (mn);
Console.WriteLine(string.Join(",", array));
Console.WriteLine(result); */
 






