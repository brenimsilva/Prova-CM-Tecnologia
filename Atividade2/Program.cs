using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTecnologia
{
    class Program
    {
        static void Main(String[] args)
        {
            /*
             
             - Atividade 2:
                2. Dado duas strings, escreva um método que determine se uma
                é a permutação da outra;
                Exemplos:
                input: ("god", "dog") output: true
                input: ("god", "dog ") output: false
            */

            //Atividade 2:
            Console.WriteLine("==================");

            Debug.Assert(checkPermutation("god", "dog", false), "deveria ser true ");
            Debug.Assert(!checkPermutation("God", "dog"), "deveria ser true ");
            Debug.Assert(!checkPermutation("goo", "dog", false), "deveria ser true");
            Debug.Assert(!checkPermutation("", "dog", false), "deveria ser true");
            Debug.Assert(checkPermutation("", "", false), "deveria ser true");
            Debug.Assert(checkPermutation("Goo", "ooG", true), "deveria ser true");
        }

        //Atividade 2


        private static Boolean checkPermutation(string word1, string word2, bool caseSensitive = true)
        {

            if (word1.Length != word2.Length)
            {
                return false;
            }

            if (!caseSensitive)
            {
                word1 = word1.ToLower();
                word2 = word2.ToLower();
            }

            List<string> word2List = new List<string>();
            word2List.AddRange(word2.Select(c => c.ToString()));


            for (var i = 0; i < word1.Length; i++)
            {
                int index = word2List.IndexOf(word1[i] + "");
                if (index == -1)
                {
                    return false;
                }
                else
                {
                    word2List.RemoveAt(index);
                }
            }

            return word2List.Count == 0;

        }
    }
}