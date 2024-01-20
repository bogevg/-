string s;
int n = 0;
Console.WriteLine("Введите слова");
s = Console.ReadLine();
string[] ar_word = s.Split(' ');
for (int i = 0; i < ar_word.Length; i++)
{
   if (ar_word[i].Length <= 3) {
        n++;
    } 
}
string[] ar_new = new string[n];
int l = n;
for (int i = 0; i < ar_word.Length; i++)
{
    if (ar_word[i].Length < 4)
    {
        ar_new[l - n] = ar_word[i];
        n--;
    }
}
