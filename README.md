Make a console application that takes a word and returns the Scrabble score for that word. Here are the values of letters in Scrabble:


A, E, I, O, U, L, N, R, S, T       1
D, G                               2
B, C, M, P                         3
F, H, V, W, Y                      4
K                                  5
J, X                               8
Q, Z                               10



1. instantiate char arrays that hold letter points
2. Split user input into a char array
3. Plug char array into foreach loop which will determine all points for word
4. Return total points/score


char[] charString = strInput.ToCharArray();

object userWord = Word;
object points = 0;

string userWord = scrabble

char array = [s, c, r, a, b, b, l, e]

foreach (char in chararray)
{
  foreach (char in 1point array)
  {
    if ( char[i} == A, E, I ...)
    points += 1;
  }
  foreach (char in 2point array)
    if (D,G ..)
    points += 2;

}
