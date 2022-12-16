using System;
using System.Collections.Generic;
using System.Text;

public static class TrascrizioneRNA
{
    public static string ToRna(string dna)
    {
        string rna = "";
        for (int i = 0; i < dna.Length; i++)
        {

            switch (dna[i])
            {
                case 'G':
                    rna = rna + 'C';
                    break;
            }
            switch (dna[i])
            {
                case 'C':
                    rna = rna + 'G';
                    break;
            }
            switch (dna[i])
            {
                case 'T':
                    rna = rna + 'A';
                    break;
            }
            switch (dna[i])
            {
                case 'A':
                    rna = rna + 'U';
                    break;
            }
        }
        return rna;
    }
}