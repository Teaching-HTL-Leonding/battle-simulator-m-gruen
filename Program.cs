// Practice for an Battle game 

const char PIRATE = 'P';
const char STONECHEWER = 'S';
const char GHOSTWARRIOR = 'G';
const char OUTWORLDER = 'O';
const char MONSTERKNIGHT = 'M';
const char DARKGOBLIN = 'D';

const int SPEEDPIRATE = 3;
const int DAMAGEPIRATE = 3;
const int HEALTHPIRATE = 20;
const int AMORPIRATE = 3;
const int SPEEDSTONECHEWER = 1;
const int DAMAGESTONECHEWER = 8;
const int HEALTHSTONECHEWER = 50;
const int AMORSTONECHEWER = 10;
const int SPEEDGHOSTWARRIOR = 5;
const int DAMAGEGHOSTWARRIOR = 2;
const int HEALTHGHOSTWARRIOR = 20;
const int AMORGHOSTWARRIOR = 2;
const int SPEEDOUTWORLDER = 10;
const int DAMAGEOUTWORLDER = 1;
const int HEALTHOUTWORLDER = 15;
const int AMOROUTWORLDER = 2;
const int SPEEDMONSTERKNIGHT = 3;
const int DAMAGEMONSTERKNIGHT = 4;
const int HEALTHMONSTERKNIGHT = 15;
const int AMORMONSTERKNIGHT = 3;
const int SPEEDDARKGOBLIN = 3;
const int DAMAGEDARKGOBLIN = 1;
const int HEALTHDARKGOBLIN = 10;
const int AMORDARKGOBLIN = 8;

double speedPlayer1 = 0;
double damagePlayer1 = 0;
double healthPlayer1 = 0;
int amorPlayer1 = 0;

double speedPlayer2 = 0;
double damagePlayer2 = 0;
double healthPlayer2 = 0;
int amorPlayer2 = 0;


Console.Clear();

Console.WriteLine($"Enter {PIRATE} for Pirate, {STONECHEWER} for Stone Chewer, {GHOSTWARRIOR} for Ghost Warrior, {OUTWORLDER} for Outworlder, {MONSTERKNIGHT} for Monster Knight and {MONSTERKNIGHT} for Dark Goblin");
Console.Write("Player one, choose what character you want to play: ");
char decisionPlayer1 = char.Parse(Console.ReadLine()!);
//char decisionPlayer1 = 'O';
Console.Write("Player two, choose what character you want to play: ");
char decisionPlayer2 = char.Parse(Console.ReadLine()!);
//char decisionPlayer2 = 'O';

switch (decisionPlayer1)
{
    case PIRATE:
        speedPlayer1 = SPEEDPIRATE;
        damagePlayer1 = DAMAGEPIRATE;
        healthPlayer1 = HEALTHPIRATE;
        amorPlayer1 = AMORPIRATE;
        break;
    case STONECHEWER:
        speedPlayer1 = SPEEDSTONECHEWER;
        damagePlayer1 = DAMAGESTONECHEWER;
        healthPlayer1 = HEALTHSTONECHEWER;
        amorPlayer1 = AMORSTONECHEWER;
        break;
    case GHOSTWARRIOR:
        speedPlayer1 = SPEEDGHOSTWARRIOR;
        damagePlayer1 = DAMAGEGHOSTWARRIOR;
        healthPlayer1 = HEALTHGHOSTWARRIOR;
        amorPlayer1 = AMORGHOSTWARRIOR;
        break;
    case OUTWORLDER:
        speedPlayer1 = SPEEDOUTWORLDER;
        damagePlayer1 = DAMAGEOUTWORLDER;
        healthPlayer1 = HEALTHOUTWORLDER;
        amorPlayer1 = AMOROUTWORLDER;
        break;
    case MONSTERKNIGHT:
        speedPlayer1 = SPEEDMONSTERKNIGHT;
        damagePlayer1 = DAMAGEMONSTERKNIGHT;
        healthPlayer1 = HEALTHMONSTERKNIGHT;
        amorPlayer1 = AMORMONSTERKNIGHT;
        break;
    case DARKGOBLIN:
        speedPlayer1 = SPEEDDARKGOBLIN;
        damagePlayer1 = DAMAGEDARKGOBLIN;
        healthPlayer1 = HEALTHDARKGOBLIN;
        amorPlayer1 = AMORDARKGOBLIN;
        break;
    default:
        Console.WriteLine("Invalid input from player one!");
        return;
}
switch (decisionPlayer2)
{
    case PIRATE:
        speedPlayer2 = SPEEDPIRATE;
        damagePlayer2 = DAMAGEPIRATE;
        healthPlayer2 = HEALTHPIRATE;
        amorPlayer2 = AMORPIRATE;
        break;
    case STONECHEWER:
        speedPlayer2 = SPEEDSTONECHEWER;
        damagePlayer2 = DAMAGESTONECHEWER;
        healthPlayer2 = HEALTHSTONECHEWER;
        amorPlayer2 = AMORSTONECHEWER;
        break;
    case GHOSTWARRIOR:
        speedPlayer2 = SPEEDGHOSTWARRIOR;
        damagePlayer2 = DAMAGEGHOSTWARRIOR;
        healthPlayer2 = HEALTHGHOSTWARRIOR;
        amorPlayer2 = AMORGHOSTWARRIOR;
        break;
    case OUTWORLDER:
        speedPlayer2 = SPEEDOUTWORLDER;
        damagePlayer2 = DAMAGEOUTWORLDER;
        healthPlayer2 = HEALTHOUTWORLDER;
        amorPlayer2 = AMOROUTWORLDER;
        break;
    case MONSTERKNIGHT:
        speedPlayer2 = SPEEDMONSTERKNIGHT;
        damagePlayer2 = DAMAGEMONSTERKNIGHT;
        healthPlayer2 = HEALTHMONSTERKNIGHT;
        amorPlayer2 = AMORMONSTERKNIGHT;
        break;
    case DARKGOBLIN:
        speedPlayer2 = SPEEDDARKGOBLIN;
        damagePlayer2 = DAMAGEDARKGOBLIN;
        healthPlayer2 = HEALTHDARKGOBLIN;
        amorPlayer2 = AMORDARKGOBLIN;
        break;
    default:
        Console.WriteLine("Invalid input from player two!");
        return;
}

healthPlayer1 += amorPlayer1;
healthPlayer2 += amorPlayer2;

double damagemultiplayerPlayer1 = Random.Shared.Next(85, 116) / 100d;
double damagemultiplayerPlayer2 = Random.Shared.Next(85, 116) / 100d;

//Console.Write(damagemultiplayerPlayer1 + "\n");
//Console.Write(damagemultiplayerPlayer2);

while (healthPlayer1 > 0 && healthPlayer2 > 0)
{
    double testspeedPlayer1 = speedPlayer1;
    double testspeedPlayer2 = speedPlayer2;
    while (testspeedPlayer1 > 0)
    {
        healthPlayer2 -= damagePlayer1 * damagemultiplayerPlayer1;
        damagemultiplayerPlayer1 = Random.Shared.Next(85, 116) / 100d;
        testspeedPlayer1 --;
    }
    while(testspeedPlayer2 > 0)
    {
        healthPlayer1 -= damagePlayer2 * damagemultiplayerPlayer2;
        damagemultiplayerPlayer2 = Random.Shared.Next(85, 116) / 100d;
        testspeedPlayer2 --;
    }
    testspeedPlayer1 = speedPlayer1;
    testspeedPlayer2 = speedPlayer2;
}
if (healthPlayer1 <= 0 && healthPlayer2 > 0)
{
    Console.WriteLine("Player two won!");
}
else if (healthPlayer2 <= 0 && healthPlayer1 > 0)
{
    Console.WriteLine("Player one won!");
}
else
{
    Console.WriteLine("It is a draw!");
}
