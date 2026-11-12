string s;
string inputCarattere;
Console.Write("Inserisci una stringa: ");
s = Console.ReadLine();

Console.Write("Inserisci il carattere da cercare: ");
inputCarattere = Console.ReadLine();

    char c = inputCarattere[0]; 

    
    int posizione = -1;
    int i = 0;

    
    while (i < s.Length && posizione == -1)
    {
      
        if (s[i] == c)
        {
            posizione = i; 
        }

        i++; 
    }

    if (posizione != -1)
    {
        Console.WriteLine("Il carattere '" + c + "' si trova in posizione: " + posizione);
    }
    else Console.WriteLine("Carattere non trovato. Risultato: " + posizione);



