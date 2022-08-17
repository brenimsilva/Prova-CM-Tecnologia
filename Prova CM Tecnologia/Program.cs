using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTecnologia
{
    class Program
    {
        static void Main(String[] args){
            /*
              
            - Atividade 1:
                1. Implemente um algoritmo que determine se uma string tenha
                todos os caracteres únicos;
                Exemplo:
                input: Thales output: true.

           - Obs pessoais:
                a) Assumi que não haveria distinção de letras maiúsculas nem minúsculas 
                por isso a escolha do uso do método ToLower()

                b) Também assumi que não haveria necessidade de tratar os espaços " " 
                e que iríamos usar apenas 1 palavra por vez

             */

            //Atividade 1:
            Console.WriteLine("Atividade 1: ");
            var msg = "Thales".ToLower();
            Console.WriteLine(msg);
            Console.WriteLine(wordIsUnique(msg)); // true, false

            /*
             
             - Atividade 2:
                2. Dado duas strings, escreva um método que determine se uma
                é a permutação da outra;
                Exemplos:
                input: ("god", "dog") output: true
                input: ("god", "dog ") output: false

            - Obs pessoais:
                a) Utilizei de alguns WriteLines para melhor visualização do resultado do código.
                
                b) Usar o array words[] para inserir as duas palavras

                c) Aqui também assumi que não faríamos distinção de maiúsculo para minúsculo

             */

            //Atividade 2:
            string[] words = new string[2];
            words[0] = "Dog".ToLower();
            words[1] = "God".ToLower();
            Console.WriteLine("==================");
            Console.WriteLine("Atividade 2: ");
            Console.WriteLine(words[0] +" / " + words[1]);
            Console.WriteLine(isPermutation(words[0], words[1]));

            //Os métodos utilizados foram criados abaixo com "// Atividade x" acima de cada um deles
            //Indicando para qual solução foram feitos.





            /* Questões de banco de dados
            Atividade 1:
                Considere um banco de dados com a seguinte estrutura:
                Cursos: CursoID*, NomeDoCurso, ProfessorID
                Teachers: ProfessorID*, NomeDoProfessor
                Students: EstudanteID*, NomeDoEstudante
                StudentCourses: CursoID*, EstudanteID*

                1. Implemente uma query que retorne uma lista com todos os
                estudantes e quais os cursos que cada estudante está
                matriculado;

                Resposta:
            ===========================================================================
                    SELECT NomeDoEstudante, NomeDoCurso FROM StudentCourses AS SC
                    INNER JOIN Students AS ST on ST.EstudanteID = SC.StudentsID
                    INNER JOIN Cursos AS CR on CR.CursoID  = SC.CursoID
                    ORDER BY ST.NomeDoEstudante 
            ===========================================================================

                 2. Implemente uma query que retorne uma lista de todos os
                 professores e quantos estudantes cada um ensina. Se um
                 professor ensina o mesmo aluno em classes diferentes, você
                 deve dobrar a contagem de estudantes. Ordene a lista numa
                 ordem decrescente pelo número de estudantes que cada um
                 ensina;

                 Resposta:
            ===========================================================================

            ===========================================================================


             */
        }


        //Atividade 1
        private static bool letterIsUnique(string word, int letterIndex)
        {
            for (var i = 0; i < word.Length; i++)
            {
                if (i <= letterIndex)
                {
                    continue;
                }
                if (word[letterIndex] == word[i])
                {
                    return false;
                }
            }
            return true;
        }

        //Atividade 1
        private static bool wordIsUnique(string msg)
        {
            for (var i = 0; i < msg.Length; i++)
            {
                if (!letterIsUnique(msg, i))
                {
                    return false;
                }
            }
            return true;
        }

        //Atividade 2
        private static bool hasLetter(char letter, string word)
        {
            for(var i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    return true;
                }
            }
            return false;

        }

        //Atividade 2
        private static bool isPermutation(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }

            for (var i = 0; i < word1.Length; i++)
            {
                if (!hasLetter(word1[i], word2))
                {
                    return false;
                }
            }
            return true;
        } 
    }
}