﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_Decrypt
{   
    internal class Hill
    {
        static void getKeyMatrix(String key,
                         int[,] keyMatrix)
        {
            int k = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    keyMatrix[i, j] = (key[k]) % 65;
                    k++;
                }
            }
        }
        static void Encrypt(int[,] cipherMatrix,
                    int[,] keyMatrix,
                    int[,] messageVector)
        {
            int x, i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    cipherMatrix[i, j] = 0;

                    for (x = 0; x < 3; x++)
                    {
                        cipherMatrix[i, j] += keyMatrix[i, x] *
                                              messageVector[x, j];
                    }

                    cipherMatrix[i, j] = cipherMatrix[i, j] % 26;
                }
            }
        }

        public static string Encipher(String message, String key)
        {

            int[,] keyMatrix = new int[3, 3];
            getKeyMatrix(key, keyMatrix);

            int[,] messageVector = new int[3, 1];

       
            for (int i = 0; i < 3; i++)
                messageVector[i, 0] = (message[i]) % 65;

            int[,] cipherMatrix = new int[3, 1];

            Encrypt(cipherMatrix, keyMatrix, messageVector);

            String CipherText = "";
            for (int i = 0; i < 3; i++)
                CipherText += (char)(cipherMatrix[i, 0] + 65);
            return CipherText;
        }
    }
}
