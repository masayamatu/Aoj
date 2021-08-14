using System.Xml.Schema;
using System.Reflection;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Text.RegularExpressions;
using System.Buffers;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Collections.Specialized;
using System.Security.Principal;
using System.IO;
using System.Net;
using System.Reflection.Emit;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using DataStructure;

class Solve
{
    public static void ITP1_1_A()
    {
        Console.WriteLine("Hello World!\n");
    }
    public static void ITP1_1_B()
    {
        int n = int.Parse(Console.ReadLine());
        int ans = (int)Math.Pow(n,3);
        Console.WriteLine(ans);

    }
    public static void ITP1_1_C()
    {
        String[] read = Console.ReadLine().Split();
        int a = int.Parse(read[0]);
        int b = int.Parse(read[1]);

        int area = a * b;
        int hen = a * 2 + b * 2;
        Console.WriteLine(area + " " + hen);

    }
    public static void ITP1_1_D()
    {
        int n = int.Parse(Console.ReadLine());
        int aminutes;
        int second;
        int hour = Math.DivRem(n, 3600, out aminutes);
        int minute = Math.DivRem(aminutes, 60,out second);
        Console.WriteLine($"{hour}:{minute}:{second}");

    }
    public static void ITP1_2_A()
    {
        String[] c = Console.ReadLine().Split();
        int a = int.Parse(c[0]);
        int b = int.Parse(c[1]);
        string ope;
        if(a > b) {
            ope = ">";
        } else if (a < b) {
            ope = "<";
        } else {
            ope = "==";
        }
        Console.WriteLine($"a {ope} b");
    }
    public static void ITP1_2_B()
    {
        String[] read = Console.ReadLine().Split();
        int a = int.Parse(read[0]);
        int b = int.Parse(read[1]);
        int c = int.Parse(read[2]);
        String ans;
        if(a < b && b < c) 
        {
            ans = "Yes";
        } else
        {
            ans = "No";
        }
        Console.WriteLine(ans);
    }
    public static void ITP1_2_C()
    {
        String[] read = Console.ReadLine().Split();
        Array.Sort(read);
        Console.WriteLine($"{read[0]} {read[1]} {read[2]}");
    }
    public static void ITP1_2_D()
    {
        String[] read = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(read, int.Parse);
        String ans;
        if((numbers[2]-numbers[4]) >= 0 && numbers[1]-(numbers[3] + numbers[4]) >= 0 && numbers[0] - (numbers[2] + numbers[4]) >= 0 && (numbers[3]-numbers[4]) >= 0)
        {
            ans = "Yes";
        } else 
        {
            ans = "No";
        }
        Console.WriteLine(ans);
    }
    public static void ITP1_3_A()
    {
        for(int i = 0; i < 1000; i++)
        {
            Console.WriteLine("Hello World");
        }
    }

    public static void ITP1_3_B()
    {
        List<int> numbers = new List<int>();
        while(true)
        {
            int num = int.Parse(Console.ReadLine());
            if(num == 0) {
                break;
            }
            numbers.Add(num);
        }
        for(int i = 0; i < numbers.Count(); i++)
        {
            Console.WriteLine($"Case {i+1}: {numbers[i]}");
        }
    }
    public static void ITP1_3_C()
    {
        while(true)
        {
            String[] read = Console.ReadLine().Split();
            int a = int.Parse(read[0]);
            int b = int.Parse(read[1]);
            if (a == 0 && b == 0)
            {
                break;
            }
            if(a > b) 
            {
                int temp = a;
                 a = b;
                 b = temp;
            }
            Console.WriteLine($"{a} {b}");
        }
    }

    public static void ITP1_3_D()
    {
        String[] read = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(read, int.Parse);
        int count = 0;
        for(int i = numbers[0]; i <= numbers[1]; i++ )
        {
            if(numbers[2] % i == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
    public static void ITP1_4_A()
    {
        int r;
        String[] read = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(read, int.Parse);
        int d = Math.DivRem(numbers[0], numbers[1], out r);
        String f = ((double)numbers[0] / (double)numbers[1]).ToString("F5");
        Console.WriteLine($"{d} {r} {f}");
    }
    public static void ITP1_4_B()
    {
        double r = double.Parse(Console.ReadLine());
        string area = (Math.PI * r * r).ToString("F6");
        string length = (2 * Math.PI * r).ToString("F6");
        Console.WriteLine($"{area} {length}");
    }
    public static void ITP1_4_C()
    {
        while(true)
        {
            String[] read = Console.ReadLine().Split();
            int a = int.Parse(read[0]);
            int b = int.Parse(read[2]);
            if(read[1] == "?") break;
            switch(read[1])
            {
                case "+":
                Console.WriteLine(a + b);
                break;
                case "-":
                Console.WriteLine(a - b);
                break;
                case "*":
                Console.WriteLine(a * b);
                break;
                case "/":
                Console.WriteLine(a / b);
                break;
            }
        }
    }
    public static void ITP1_4_D()
        {
            int n = int.Parse(Console.ReadLine());
            String[] read = Console.ReadLine().Split();
            int[] numbers = Array.ConvertAll(read, int.Parse);
            Array.Sort(numbers);
            long sum = 0;
            for(int i = 0; i < numbers.Length; i++) 
            {
                sum += numbers[i];
            }
            Console.WriteLine($"{numbers[0]} {numbers[n-1]} {sum}");
        }
    public static void ITP1_5_A()
    {
        while(true)
        {
            String[] read = Console.ReadLine().Split();
            if(read[0] == "0") break;
            int a = int.Parse(read[0]);
            int b = int.Parse(read[1]);
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
    public static void ITP1_5_B()
    {
        while(true)
        {
            String[] read = Console.ReadLine().Split();
            if(read[0] == "0") break;
            int a = int.Parse(read[0]);
            int b = int.Parse(read[1]);
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    if(i == 0 || i == a-1 || j == 0 || j == b - 1)
                    {
                        Console.Write("#");
                    } else {
                        Console.Write(".");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    public static void ITP1_5_C()
    {
        while(true)
        {
            String[] read = Console.ReadLine().Split();
            if(read[0] == "0") break;
            int a = int.Parse(read[0]);
            int b = int.Parse(read[1]);
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    if(i % 2 == 0)
                    {
                        if(j % 2 == 0)
                        {
                            Console.Write("#");
                        } else
                        {
                            Console.Write(".");
                        }
                    } else
                    {
                        if(j % 2 == 0) 
                        {
                            Console.Write(".");
                        } else 
                        {
                            Console.Write("#");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    public static  void ITP1_5_D()
    {
        int number = int.Parse(Console.ReadLine());
        for(int i = 1; i <= number; i++)
        {
            if(i % 3 == 0)
            {
                Console.Write($" {i}");
            } else if(i % 10 == 3)
            {
                Console.Write($" {i}");
            } else
            {
                int temp = i/10;
                while(temp != 0)
                {
                    if(temp % 10 == 3)
                    {
                        Console.Write($" {i}");
                        break;
                    }
                    temp /= 10;
                }
                
            }
        }
    }
    public static void ITP1_6_A()
    {
        int number = int.Parse(Console.ReadLine());
        String[] read = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(read, int.Parse);
        Array.Reverse(numbers);
        for(int i = 0; i < numbers.Length; i++)
        {
            if(i == numbers.Length - 1)
            {
                Console.Write(numbers[i]);
                Console.WriteLine();
            }
            else
            {    
                Console.Write(numbers[i] + " ");
            }
            
        }
    }
    public static void ITP1_6_B()
    {
        int numbers = int.Parse(Console.ReadLine());
        int[] S = new int[13];
        int[] H = new int[13];
        int[] C = new int[13];
        int[] D = new int[13];
        for(int i = 0; i < numbers; i++)
        {
            String[] read = Console.ReadLine().Split();
            int number = int.Parse(read[1]) - 1;
            switch(read[0])
            {
                case "S":
                    S[number] = 1;
                    break;
                case "H":
                    H[number] = 1;
                    break;
                case "C":
                    C[number] = 1;
                    break;
                case "D":
                    D[number] = 1;
                    break;
            }
        }
        for(int i = 0; i < S.Length; i++ )
        {
            if(S[i] == 0)
            {
                Console.WriteLine($"S {i + 1}");
            }
        }
        for(int i = 0; i < H.Length; i++ )
        {
            if(H[i] == 0)
            {
                Console.WriteLine($"H {i + 1}");
            }
        }
        for(int i = 0; i < C.Length; i++ )
        {
            if(C[i] == 0)
            {
                Console.WriteLine($"C {i + 1}");
            }
        }
        for(int i = 0; i < D.Length; i++ )
        {
            if(D[i] == 0)
            {
                Console.WriteLine($"D {i + 1}");
            }
        }
    }
    public static void ITP1_6_C()
    {
        int number = int.Parse(Console.ReadLine());
        var buildings = new int[4, 3, 10];
        for(int i = 0; i < number; i++)
        {
            String[] read = Console.ReadLine().Split();
            int[] query = Array.ConvertAll(read, int.Parse);
            buildings[query[0] - 1, query[1] - 1, query[2] - 1] += query[3];
        }
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                for(int k = 0; k < 10; k++)
                {
                    
                    Console.Write(" " + buildings[i, j, k]);
                    if(k == 9)
                    {
                        Console.WriteLine();
                    }
                }
            }
            if(i != 3)
            {
                 Console.WriteLine("####################");
            }
        }
    }
    public static void ITP1_6_D()
    {
        String[] nm = Console.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);
        String[][] matrix = new String[n][];
        int[][] numMatrix = new int[n][];
        int[] vector = new int[m];
        for(int i = 0; i < n; i++)
        {
            matrix[i] = Console.ReadLine().Split();
            numMatrix[i] = Array.ConvertAll(matrix[i],int.Parse);
        }
        for(int i = 0; i < m; i++)
        {
            int number = int.Parse(Console.ReadLine());
            vector[i] = number;
        }
        for(int i = 0; i < n; i++)
        {
            int product = 0;
            for(int j = 0; j < m; j++)
            {
                product += numMatrix[i][j] * vector[j];
            }
            Console.WriteLine(product);
        }
    }
    public static void ITP1_7_A()
    {
        var grades = new List<String>();
        while(true) 
        {
            var read = Console.ReadLine().Split();
            var score = Array.ConvertAll(read, int.Parse);
            if(score[0] == -1 && score[1] == -1 && score[2] == -1 ) break;
            int total = (score[0] + score[1]);
            if(score[0] == -1 || score[1] == -1)
            {
                grades.Add("F");
            }
            else if(total >= 80)
            {
                grades.Add("A");
            }
            else if(total >= 65)
            {
                grades.Add("B");
            }
            else if(total >= 50)
            {
                grades.Add("C");
            }
            else if(total >= 30 && score[2] >= 50)
            {
                grades.Add("C");
            }
            else if(total >= 30)
            {
                grades.Add("D");
            }
            else
            {
                grades.Add("F");
            }
        }
        grades.ForEach(delegate(String grade)
        {
            Console.WriteLine(grade);
        });
    }
    public static void ITP1_7_B()
    {
        var answers = new List<int>();
        while(true)
        {
            var read = Console.ReadLine().Split();
            var numbers = Array.ConvertAll(read, int.Parse);
            int count = 0;
            if(numbers[0] == 0 && numbers[1] == 0) break;
            for(int i = 1; i < numbers[0] - 1; i++)
            {
                for(int j = i + 1; j < numbers[0]; j++)
                {
                    int third = numbers[1] - i - j;
                    if(third > j && third <= numbers[0]) count++;
                }
            }
            answers.Add(count);
        }
        answers.ForEach(delegate(int ans)
        {
            Console.WriteLine(ans);
        });
    }
    public static void ItP1_7_C()
    {
        String[] read = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(read, int.Parse);
        String[][] table = new String[numbers[0]][];
        int[][] numtable = new int[numbers[0] + 1][];
        for(int i = 0; i < numbers[0]; i++)
        {
            table[i] = Console.ReadLine().Split();
            numtable[i] = Array.ConvertAll(table[i], int.Parse);
            int sum = 0;
            for(int j = 0; j < numtable[i].Count(); j++)
            {
                
                sum += numtable[i][j];
            }
            Array.Resize(ref numtable[i], numbers[1] + 1);
            numtable[i][numbers[1]] = sum;
        }
        int[] last = new int[numbers[1] + 1];
        for(int i = 0; i < numbers[0]; i++)
        {
            for(int j = 0; j < numbers[1] + 1; j++)
            {
                last[j] += numtable[i][j];
            }
            
        }
        for(int i = 0; i < numbers[0]; i++)
        {
            for(int j = 0; j < numbers[1] + 1; j++)
            {
                if(j != numbers[1])
                {
                    Console.Write($"{numtable[i][j]} ");
                }
                else
                {
                    Console.WriteLine(numtable[i][j]);
                }
            }
            if(i == numbers[0] - 1)
            {
                for(int k = 0; k < numbers[1] + 1; k++)
                {
                    if(k == numbers[1])
                    {
                        Console.WriteLine(last[k]);
                    }
                    else
                    {
                        Console.Write($"{last[k]} ");
                    }
                }
            }
        }
    }
    public static void ITP1_7_D()
    {
        String[] read = Console.ReadLine().Split();
        String[][] readA = new String[int.Parse(read[0])][];
        String[][] readB = new String[int.Parse(read[1])][];
        long[][] numA = new long[int.Parse(read[0])][];
        long[][] numB = new long[int.Parse(read[1])][];
        long[,] ans = new long[int.Parse(read[0]), int.Parse(read[2])];
        for(int i = 0; i < int.Parse(read[0]); i++)
        {
            readA[i] = Console.ReadLine().Split();
            numA[i] = Array.ConvertAll(readA[i], long.Parse);
        }
        for(int i = 0; i < int.Parse(read[1]); i++)
        {
            readB[i] = Console.ReadLine().Split();
            numB[i] = Array.ConvertAll(readB[i], long.Parse);
        }

        for(int k = 0; k < int.Parse(read[2]); k++)
        {
            for(int i = 0; i < int.Parse(read[0]); i++)
            {
                long temp = 0;
                for(int j = 0; j < int.Parse(read[1]); j++)
                {
                    temp += numA[i][j] * numB[j][k];
                }
                ans[i,k] = temp;
            }
        }
        for(int i = 0; i < ans.GetLength(0); i++)
        {
            for(int j = 0; j < ans.GetLength(1); j++)
            {
                if(j != ans.GetLength(1) - 1)
                {
                    Console.Write($"{ans[i, j]} ");
                }
                else
                {
                    Console.WriteLine(ans[i, j]);
                }
            }
        }
    }
    public static void ITP1_8_A()
    {
        String read = Console.ReadLine();
        char[] ans = read.ToCharArray();
        for(int i = 0; i < ans.Length; i++)
        {
            if(!char.IsLetter(ans[i]))
            {

            }
            else if(char.IsUpper(ans[i]))
            {
                ans[i] = char.ToLower(ans[i]);
            }
            else if(char.IsLower(ans[i]))
            {
                ans[i] = char.ToUpper(ans[i]);
            }
            if(i != ans.Length - 1)
            {
                Console.Write($"{ans[i] }");
            }
            else
            {
                Console.WriteLine(ans[i]);
            }
        }
    }
    public static void ITP1_8_B()
    {
        while(true)
        {
            char[] read = Console.ReadLine().ToCharArray();
            if(read[0] == '0')
            {
                break;
            }
            int temp = 0;
            for(int i = 0; i < read.Length; i++)
            {
                temp += int.Parse(read[i].ToString());
            }
            Console.WriteLine(temp);
        }
    }
    public static void ITP1_8_C()
    {
        
        var alphabet = new Dictionary<char, int>();
        alphabet.Add('a', 0);
        alphabet.Add('b', 0);
        alphabet.Add('c', 0);
        alphabet.Add('d', 0);
        alphabet.Add('e', 0);
        alphabet.Add('f', 0);
        alphabet.Add('g', 0);
        alphabet.Add('h', 0);
        alphabet.Add('i', 0);
        alphabet.Add('j', 0);
        alphabet.Add('k', 0);
        alphabet.Add('l', 0);
        alphabet.Add('m', 0);
        alphabet.Add('n', 0);
        alphabet.Add('o', 0);
        alphabet.Add('p', 0);
        alphabet.Add('q', 0);
        alphabet.Add('r', 0);
        alphabet.Add('s', 0);
        alphabet.Add('t', 0);
        alphabet.Add('u', 0);
        alphabet.Add('v', 0);
        alphabet.Add('w', 0);
        alphabet.Add('x', 0);
        alphabet.Add('y', 0);
        alphabet.Add('z', 0);
        String read;
        while((read = Console.ReadLine()) != null)
        {
            char[] chRead = read.ToCharArray();
            for(int i = 0; i < chRead.Length; i++)
            {
                if(alphabet.ContainsKey(char.ToLower(chRead[i])))
                {
                    alphabet[char.ToLower(chRead[i])] += 1;
                }
            }
        }
        foreach(var a in alphabet)
        {
            Console.WriteLine($"{a.Key} : {a.Value}");
        }
    }
    public static void  ITP1_8_D()
    {
        char[] read = Console.ReadLine().ToCharArray();
        char[] find = Console.ReadLine().ToCharArray();
        bool flag = false;
        for(int i = 0; i < read.Length; i++)
        {
            if(read[i] == find[0])
            {
                if(find.Length == 1)
                {
                    flag = true;
                }
                int j = 1;
                int k = 0;
                while(j < find.Length)
                {
                    
                    if((i + j) > read.Length-1)
                    {
                        k = i;
                        i -= read.Length;
                    }
                    if(read[i+j] != find[j])
                    {
                        flag = false;
                        break;
                    }
                    j++;
                    if(j == find.Length)
                    {
                        flag = true;
                        break;
                    }
                }
                if(k != 0)
                {
                    i = k;
                }
            }
            if(flag == true)
            {
                break;
            }
        }
        if(flag == true)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
    public static void ITP1_9_A()
    {
        String word = Console.ReadLine().ToUpper();
        int count = 0;
        while(true)
        {
            String[] text = Console.ReadLine().Split();
            if(text[0] == "END_OF_TEXT") break;
            String upperText;
            for(int i = 0; i < text.Length; i++)
            {
                upperText = text[i].ToUpper();
                if(upperText.Equals(word))
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
    public static void ITP1_9_B()
    {
        while(true)
        {
            String word = Console.ReadLine();
            char[] charWord = word.ToCharArray();
            int wordLength = charWord.Length;
            if(word == "-")
            {
                break;
            }
            String num = Console.ReadLine();
            int inum = int.Parse(num);
            String strShuffle;
            int intShuffle;
            for(int i = 0; i < inum; i++)
            {
                strShuffle = Console.ReadLine();
                intShuffle = int.Parse(strShuffle);
                char[] temp = new char[intShuffle];
                for(int j = 0; j < intShuffle; j++)
                {
                    temp[j] = charWord[j];
                }
                for(int j = intShuffle; j < word.Length; j++)
                {
                    int move = j - intShuffle;
                    charWord[move] = charWord[j];
                }
                for(int j = 0; j < temp.Length; j++)
                {
                    charWord[wordLength-intShuffle + j] = temp[j];
                }
            }
            for(int i = 0; i < wordLength; i++)
            {
                if(i == wordLength - 1)
                {
                    Console.WriteLine(charWord[i]);
                }
                else
                {
                    Console.Write(charWord[i]);    
                }
            }
        }
    }
    public static void ITP1_9_C()
    {
        String strNumber = Console.ReadLine();
        int number = int.Parse(strNumber);
        String[] tCards = new String[number];
        String[] hCards = new String[number];
        int tPoints = 0;
        int hPoints = 0;
        for(int i = 0; i < number; i++)
        {
            String[] read = Console.ReadLine().Split();
            tCards[i] = read[0];
            hCards[i] = read[1];
            if(tCards[i] == hCards[i])
            {
                tPoints += 1;
                hPoints += 1;
            }
            else if(string.Compare(tCards[i], hCards[i]) == 1)
            {
                tPoints += 3;
            } 
            else 
            {
                hPoints += 3;
            }
        }
        Console.WriteLine($"{tPoints} {hPoints}");
    }
    public static void ITP1_9_D()
    {
        String word = Console.ReadLine();
        String strNumber = Console.ReadLine();
        int number = int.Parse(strNumber);
        for(int i = 0; i < number; i++)
        {
            String[] command = Console.ReadLine().Split();
            int[] range = new int[]{int.Parse(command[1]), int.Parse(command[2])};
            int length = range[1] - (range[0]-1);
            if(command[0] == "print")
            {
                Console.WriteLine(word.Substring(range[0], length));
            }
            else if(command[0] == "replace")
            {
                char[] charWord = word.ToCharArray();
                char[] replaceWord = command[3].ToCharArray();
                for(int j = 0; j < length; j++)
                {
                    charWord[range[0] + j] = replaceWord[j];
                }
                word = new String(charWord);
            }
            else
            {
                char[] charWord = word.ToCharArray();
                char[] rCharWord = word.Substring(range[0], length).ToCharArray();
                Array.Reverse(rCharWord);
                for(int j = 0; j < length; j++)
                {
                    charWord[range[0] + j] = rCharWord[j];
                }
                word = new String(charWord);
            }
        }
    }
    public static void ITP1_10_A()
    {
        String[] strPoints = Console.ReadLine().Split();
        double[]  points = new double[]{double.Parse(strPoints[0]), double.Parse(strPoints[1]), double.Parse(strPoints[2]), double.Parse(strPoints[3])};
        double dx = (points[0] - points[2]);
        double dy = (points[1] - points[3]);
        String distance = Math.Sqrt(dx * dx + dy * dy).ToString("F8");
        Console.WriteLine(distance);
    }
    public static void ITP1_10_B()
    {
        String[] strTriangle = Console.ReadLine().Split();
        double[] triangle = new double[]{double.Parse(strTriangle[0]), double.Parse(strTriangle[1]), double.Parse(strTriangle[2])};
        double S = 0.5 * triangle[0] * triangle[1] * Math.Sin(triangle[2] * (Math.PI/180));
        double c = Math.Sqrt(Math.Pow(triangle[0],2) + Math.Pow(triangle[1],2) - 2 * triangle[0] * triangle[1] * Math.Cos(triangle[2]*(Math.PI/180)));
        double h = 2 * S / triangle[0];
        Console.WriteLine(S);
        Console.WriteLine(triangle[0] + triangle[1] + c);
        Console.WriteLine(h);
    }
    public static void ITP1_10_C()
    {
        while(true)
        {
            String number = Console.ReadLine();
            if(number == "0")
            {
                break;
            }
            String[] numbers = Console.ReadLine().Split();
            double[] doubleNums = new double[numbers.Length];
            double sum = 0;
            double ave = 0;
            double a2 = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                doubleNums[i] = double.Parse(numbers[i]);
                sum += doubleNums[i];
            }
            ave = sum / doubleNums.Length;
            for(int i = 0; i < doubleNums.Length; i++)
            {   
                a2 += Math.Pow((doubleNums[i] - ave), 2);
            }
            Console.WriteLine(Math.Sqrt(a2/(double)doubleNums.Length));
        }
    }
    public static void ITP1_10_D()
    {
        int number = int.Parse(Console.ReadLine());
        String[] strY = Console.ReadLine().Split();
        String[] strX = Console.ReadLine().Split();
        double[] doubleY = new double[number];
        double[] doubleX = new double[number];
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        double max = 0;
        for(int i = 0; i < number; i++)
        {
            doubleY[i] = double.Parse(strY[i]);
            doubleX[i] = double.Parse(strX[i]);
            max = Math.Max(max, Math.Abs(doubleY[i] - doubleX[i]));
            p1 += Math.Abs(doubleX[i] - doubleY[i]);
            p2 += Math.Pow(doubleX[i] - doubleY[i], 2);
            p3 += Math.Pow(Math.Abs(doubleX[i] - doubleY[i]), 3);
        } 
        Console.WriteLine(Math.Pow(p1, 1));
        Console.WriteLine(Math.Pow(p2, 1.0/2.0));
        Console.WriteLine(Math.Pow(p3, 1.0/3.0));
        Console.WriteLine(max);
    }
    public static void ALDS1_11_B()
    {
        int N = int.Parse(Console.ReadLine());
        List<int>[] graph = new List<int>[N];
        for(int i = 0; i < N; i++)
        {
            graph[i] = new List<int>();
        }
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split();
            for(int j = 0; j < int.Parse(read[1]); j++)
            {
                graph[int.Parse(read[0]) - 1].Add(int.Parse(read[2 + j]) - 1);
            }
        }
        int[] d = new int[N];
        int[] f = new int[N];
        int[] visited = new int[N];
        Stack<int> s = new Stack<int>();
        int time = 0;
        for(int i = 0; i < N; i++)
        {
            if(visited[i] == 0)
            {
                s.Push(i);
                dfs(s, d, f, graph,ref time, visited);
            }
        }
        for(int i = 0; i < N; i++)
        {
            Console.WriteLine($"{i + 1} {d[i]} {f[i]}");
        }
    }
    public static void dfs(Stack<int> s, int[] d, int[] f, List<int>[] graph,ref int time, int[] visited)
    {
        int now = s.Peek();
        visited[now] = 1;
        d[now] = ++time;  
        while(!(s.Count() == 0))
        {
            now = s.Peek();
            int next = -1;
            if(graph[now].Count() != 0)
            {
                while(!(visited[graph[now][0]] == 0))
                {
                    graph[now].RemoveAt(0);
                    if(graph[now].Count() == 0)
                    {
                        break;
                    }
                }
                if(graph[now].Count() != 0)
                {
                    next = graph[now][0];
                    graph[now].RemoveAt(0);
                }
            }
            if(next != -1 && visited[next] == 0)
            {
                visited[next] = 1;
                d[next] = ++time;
                s.Push(next);
            }
            else
            {
                s.Pop();
                visited[now] = 2;
                f[now] = ++time;
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
        }
    }
    public static void ALDS1_11_C()
    {
        int N = int.Parse(Console.ReadLine());
        var graph = new List<int>[N];
        var min = new int[N];
        for(int i = 0; i < N; i++)
        {
            graph[i] = new List<int>();
            min[i] = 101;
        }
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split();
            for(int j = 0; j < int.Parse(read[1]); j++)
            {
                graph[int.Parse(read[0]) - 1].Add(int.Parse(read[2 + j])- 1);
            }
        }
        var q = new Queue<int>();
        q.Enqueue(0);
        bfs(q, graph, min);
        for(int i = 0; i < N; i++)
        {
            min[i] = (min[i] == 101) ? -1 : min[i];
            Console.WriteLine($"{i + 1} {min[i]}");
        }  
    }
    public static void bfs(Queue<int> q, List<int>[] graph, int[] min)
    {
        int now = q.Peek();
        min[now] = 0;
        while(q.Count() != 0)
        {
            now = q.Dequeue();
            while(graph[now].Count() != 0)
            {
                if(min[graph[now][0]] == 101)
                {
                    q.Enqueue(graph[now][0]);
                    min[graph[now][0]] = min[now] + 1;
                    graph[now].RemoveAt(0);
                }
                else
                {
                    graph[now].RemoveAt(0);
                }
                    
            }
        }
    }
    public static void ALDS1_11_D()
    {
        var read = Console.ReadLine().Split();
        int N = int.Parse(read[0]);
        int M = int.Parse(read[1]);
        var graph = new List<int>[N];
        var connect = new int[N];
        int id = 0;
        for(int i = 0; i < N; i++)
        {
            graph[i] = new List<int>();
            connect[i] = -1;
        }
        for(int i = 0; i < M; i++)
        {
            var read2 = Console.ReadLine().Split();
            graph[int.Parse(read2[0])].Add(int.Parse(read2[1]));
            graph[int.Parse(read2[1])].Add(int.Parse(read2[0]));
        }
        for(int i = 0; i < N; i++)
        {
            if(connect[i] == -1)
            {
                dfs2(graph, connect, i , id);
                id++;
            }
        }
        var read3 = int.Parse(Console.ReadLine());
        for(int i = 0; i < read3; i++)
        {
            var read4 = Console.ReadLine().Split();
            if(connect[int.Parse(read4[0])] == connect[int.Parse(read4[1])])
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }

    }
    public static void dfs2(List<int>[] graph,int[] c, int n , int m)
    {
        var s = new Stack<int>();
        s.Push(n);
        int now = n;
        c[now] = m;
        while(s.Count() != 0)
        {
            now = s.Pop();
            for(int i = 0; i < graph[now].Count(); i++)
            {
                if(c[graph[now][i]] == -1)
                {
                    c[graph[now][i]] = m;
                    s.Push(graph[now][i]);
                }   
            }
        }
    }
    public static void ALDS1_12_A()
    {
        int N = int.Parse(Console.ReadLine());
        var graph = new int[N][];
        int[] min = new int[N];
        int[] parent = new int[N];
        int[] visited = new int[N];
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().TrimStart().Split();
            graph[i] = new int[N];
            min[i] = 2001;
            visited[i] = -1;
            parent[i] = -1;
            for(int j = 0; j < read.Length; j++)
            {
                graph[i][j] = int.Parse(read[j]);
            }
        }
        int ans = prim(min, parent, visited, graph);
        Console.WriteLine(ans);
    }
    public static int prim(int[] min, int[] parent, int[] visited, int[][] graph)
    {
        min[0] = 0;
        while(true)
        {
            int minTemp = 2001;
            int u = -1;
            for(int i = 0; i < min.Length; i++)
            {
                if(min[i] < minTemp && visited[i] != 2)
                {
                    u = i;
                    minTemp = min[i];
                }
            }
            if(u == -1) break;
            visited[u] = 2;
            for(int i = 0; i < min.Length; i++)
            {
                if(visited[i] != 2 && graph[u][i] != -1)
                {
                    if(graph[u][i] < min[i])
                    {
                        min[i] = graph[u][i];
                        parent[i] = u;
                        visited[i] = 1;
                    }
                }
            }
        }
        int sum = 0;
        for(int i = 0; i < min.Length; i++)
        {
            if(parent[i] != -1) sum += graph[i][parent[i]];
        }
        return sum;
    }
    public static void ALDS1_12_B()
    {
        int N = int.Parse(Console.ReadLine());
        var graph = new int[N][];
        var parent = new int[N];
        var min = new int[N];
        var visited = new int[N];
        for(int i = 0; i < N; i++)
        {
            graph[i] = new int[N];
            parent[i] = -1;
            min[i] = int.MaxValue;
            visited[i] = -1;
            var read = Console.ReadLine().Split();
            int  v = int.Parse(read[1]);
            for(int j = 0; j < 2 * v; j += 2)
            {
                graph[i][int.Parse(read[j + 2])] = int.Parse(read[j + 3]);
            }
        }
        dijkstra(graph, parent, min, visited);
        for(int i = 0; i < min.Length; i++)
        {
            min[i] = min[i] == int.MaxValue ? -1 : min[i];
            Console.WriteLine($"{i} {min[i]}");
        }
    }
    public static void dijkstra(int[][] graph, int[] parent, int[] min, int[] visited)
    {
        int now = 0;
        min[now] = 0;
        while(true)
        {
            int minTemp = int.MaxValue;
            for(int i = 0; i < min.Length; i++)
            {
                if(visited[i] != 2 && min[i] < minTemp)
                {
                    minTemp = min[i];
                    now = i;
                }
            }
            if(minTemp == int.MaxValue) break;
            visited[now] = 2;
            for(int i = 0; i < min.Length; i++)
            {
                if(visited[i] != 2 && graph[now][i] != 0)
                {
                    if(min[now] + graph[now][i] < min[i])
                    {
                        min[i] = min[now] + graph[now][i];
                        parent[i] = now;
                        visited[i] = 1;
                    }
                }
            }
        }
    }
    public static void ALDS1_12_C()
    {
        int N = int.Parse(Console.ReadLine());
        var dijkstra = new Dijkstra(N);
        for(int i = 0; i < N; i++)
        {
            var read = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int j = 0; j < read[1] * 2; j += 2)
            {
                dijkstra.Add(i, read[j + 2], read[j + 3]);
            }
        }
        var mincost = dijkstra.GetMinCost(0);
        for(int i = 0; i < N; i++)
        {
            Console.WriteLine($"{i} {mincost[i]}");
        }
    }
}


