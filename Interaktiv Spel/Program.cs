using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Välkommen till spelet. Skriv 'starta' för att spela och 'avsluta'.");

string starta = Console.ReadLine();

if  (starta == "starta"){
    Console.WriteLine("Du är påväg ut ur huset när du hör ett konstigt ljud bakom huset. vill du gå och titta var ljudet kom från?");
}
else if (starta == "avsluta"){
    return;
}

string ljudet = Console.ReadLine();

if (ljudet == "ja"){
    Console.WriteLine("När du kommer in i skogen bakom huset så ser du fisk, vill du gå tillbaka eller ringa polisen");
   
    string polisen = Console.ReadLine();

    if (polisen == "ringa polisen"){
    Console.WriteLine("Du berättar för polisen att du har hittat en fisk i skogen, men dom blir arga att du slösar deras tid och blir inlåst.  Game over");
    Console.ReadLine();


    return;
}

else if (polisen == "tillbaka"){
    Console.WriteLine("Du fortsätter gå. Efter ett tag set du en hemlös man, han frågar om pengar. Vill du ge honom?");  
    string curry = Console.ReadLine();

    if (curry == "ja"){
     Console.WriteLine("Han blir glad å du får curry å så lite RIZZ");
    }
    else if (curry == "nej"){
        Console.WriteLine("Han blir arg och slår dig med en sengångare tills du dör, Game Over");
        Console.ReadLine();
        return;
    }
else{Console.WriteLine("Jag fattar inte vad du menar skriv igen");
Console.ReadLine();
}
}
}
else if (ljudet == "nej"){
    Console.WriteLine("Du fortsätter gå. Efter ett tag set du en hemlös man, han frågar om pengar. Vill du ge honom?");
}

else {Console.WriteLine("Jag fattar inte vad du menar skriv igen");
Console.ReadLine();
}
string curry1 = Console.ReadLine();

if  (curry1 == "ja"){
    Console.WriteLine("Han blir glad å du får curry å så lite RIZZ");
}
else if (curry1 == "nej"){
    Console.WriteLine("Han blir arg och slår dig med en sengångare tills du dör, Game Over");
    Console.ReadLine();
    return;
}
else{Console.WriteLine("Jag fattar inte vad du menar skriv igen");
Console.ReadLine();
}

/*string polisen = Console.ReadLine();

if (polisen == "ringa polisen"){
    Console.WriteLine("Du berättar för polisen att du har hittat en fisk i skogen, men dom blir arga att du slösar deras tid och blir inlåst.  Game over");
    Console.ReadLine();
    return;
}

else if (polisen == "tillbaka"){
    Console.WriteLine("Du fortsätter gå. Efter ett tag set du en hemlös man, han frågar om pengar. Vill du ge honom?");
    Console.ReadLine();
}

/*else {Console.WriteLine("Jag fattar inte vad du menar skriv igen");
Console.ReadLine();
}*/

/*string curry = Console.ReadLine();

if (curry == "ja"){
    Console.WriteLine("Han blir glad å du får curry å så lite RIZZ");
}
else if (curry == "nej"){
    Console.WriteLine("Han blir arg och slår dig med en sengångare tills du dör, Game Over");
    Console.ReadLine();
    return;
}
else{Console.WriteLine("Jag fattar inte vad du menar skriv igen");
Console.ReadLine();
}*/

Console.ReadLine();