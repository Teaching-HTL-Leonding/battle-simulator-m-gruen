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

Console.WriteLine($"Enter {PIRATE} for Pirate, {STONECHEWER} for Stone Chewer, {GHOSTWARRIOR} for Ghost Warrior, {OUTWORLDER} for Outworlder, {MONSTERKNIGHT} for Monster Knight and {DARKGOBLIN} for Dark Goblin");
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

while (healthPlayer1 > 0 && healthPlayer2 > 0)
{
    double testspeedPlayer1 = speedPlayer1;
    double testspeedPlayer2 = speedPlayer2;
    while (testspeedPlayer1 > 0)
    {
        healthPlayer2 -= damagePlayer1 * damagemultiplayerPlayer1;
        damagemultiplayerPlayer1 = Random.Shared.Next(85, 116) / 100d;
        testspeedPlayer1--;
    }
    while (testspeedPlayer2 > 0)
    {
        healthPlayer1 -= damagePlayer2 * damagemultiplayerPlayer2;
        damagemultiplayerPlayer2 = Random.Shared.Next(85, 116) / 100d;
        testspeedPlayer2--;
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

int winsPirate = 0;
int winsStoneChewer = 0;
int winsGhostWarrior = 0;
int winsOutworlder = 0;
int winsMonsterKnight = 0;
int winsDarkGoblin = 0;
int draws = 0;

int count = 10_000;

double speed1 = 0;
double damage1 = 0;
double health1 = 0;
int amor1 = 0;

double speed2 = 0;
double damage2 = 0;
double health2 = 0;
int amor2 = 0;

Console.WriteLine("\nNow we will Calculate which character is the best!");

int randomOne = Random.Shared.Next(1, 7);
int randomTwo = Random.Shared.Next(1, 7);

double damagemultiplayer1 = 0;
double damagemultiplayer2 = 0;


while (count > 0)
{
    switch (randomOne)
    {
        case 1:
            speed1 = SPEEDPIRATE;
            damage1 = DAMAGEPIRATE;
            health1 = HEALTHPIRATE;
            amor1 = AMORPIRATE;
            break;
        case 2:
            speed1 = SPEEDSTONECHEWER;
            damage1 = DAMAGESTONECHEWER;
            health1 = HEALTHSTONECHEWER;
            amor1 = AMORSTONECHEWER;
            break;
        case 3:
            speed1 = SPEEDGHOSTWARRIOR;
            damage1 = DAMAGEGHOSTWARRIOR;
            health1 = HEALTHGHOSTWARRIOR;
            amor1 = AMORGHOSTWARRIOR;
            break;
        case 4:
            speed1 = SPEEDOUTWORLDER;
            damage1 = DAMAGEOUTWORLDER;
            health1 = HEALTHOUTWORLDER;
            amor1 = AMOROUTWORLDER;
            break;
        case 5:
            speed1 = SPEEDMONSTERKNIGHT;
            damage1 = DAMAGEMONSTERKNIGHT;
            health1 = HEALTHMONSTERKNIGHT;
            amor1 = AMORMONSTERKNIGHT;
            break;
        default:
            speed1 = SPEEDDARKGOBLIN;
            damage1 = DAMAGEDARKGOBLIN;
            health1 = HEALTHDARKGOBLIN;
            amor1 = AMORDARKGOBLIN;
            break;
    }

    switch (randomTwo)
    {
        case 1:
            speed2 = SPEEDPIRATE;
            damage2 = DAMAGEPIRATE;
            health2 = HEALTHPIRATE;
            amor2 = AMORPIRATE;
            break;
        case 2:
            speed2 = SPEEDSTONECHEWER;
            damage2 = DAMAGESTONECHEWER;
            health2 = HEALTHSTONECHEWER;
            amor2 = AMORSTONECHEWER;
            break;
        case 3:
            speed2 = SPEEDGHOSTWARRIOR;
            damage2 = DAMAGEGHOSTWARRIOR;
            health2 = HEALTHGHOSTWARRIOR;
            amor2 = AMORGHOSTWARRIOR;
            break;
        case 4:
            speed2 = SPEEDOUTWORLDER;
            damage2 = DAMAGEOUTWORLDER;
            health2 = HEALTHOUTWORLDER;
            amor2 = AMOROUTWORLDER;
            break;
        case 5:
            speed2 = SPEEDMONSTERKNIGHT;
            damage2 = DAMAGEMONSTERKNIGHT;
            health2 = HEALTHMONSTERKNIGHT;
            amor2 = AMORMONSTERKNIGHT;
            break;
        default:
            speed2 = SPEEDDARKGOBLIN;
            damage2 = DAMAGEDARKGOBLIN;
            health2 = HEALTHDARKGOBLIN;
            amor2 = AMORDARKGOBLIN;
            break;
    }
    health1 += amor1;
    health2 += amor2;

    damagemultiplayer1 = Random.Shared.Next(85, 116) / 100d;
    damagemultiplayer2 = Random.Shared.Next(85, 116) / 100d;

    while (health1 > 0 && health2 > 0)
    {
        double testspeed1 = speed1;
        double testspeed2 = speed2;
        while (testspeed1 > 0)
        {
            health2 -= damage1 * damagemultiplayer1;
            damagemultiplayer1 = Random.Shared.Next(85, 116) / 100d;
            testspeed1--;
        }
        while (testspeed2 > 0)
        {
            health1 -= damage2 * damagemultiplayer2;
            damagemultiplayer2 = Random.Shared.Next(85, 116) / 100d;
            testspeed2--;
        }
        testspeed1 = speed1;
        testspeed2 = speed2;
    }
    if (health1 <= 0 && health2 > 0)
    {
        switch(randomTwo)
        {
            case 1:
                winsPirate ++;
                break;
            case 2:
                winsStoneChewer ++;
                break;
            case 3:
                winsGhostWarrior ++;
                break;
            case 4:
                winsOutworlder ++;
                break;
            case 5:
                winsMonsterKnight ++;
                break;
            default:
                winsDarkGoblin ++;
                break;
        }
    }
    else if (health2 <= 0 && health1 > 0)
    {
        switch(randomOne)
        {
            case 1:
                winsPirate ++;
                break;
            case 2:
                winsStoneChewer ++;
                break;
            case 3:
                winsGhostWarrior ++;
                break;
            case 4:
                winsOutworlder ++;
                break;
            case 5:
                winsMonsterKnight ++;
                break;
            default:
                winsDarkGoblin ++;
                break;
        }
    }
    else
    {
        draws ++;
    }
    randomOne = Random.Shared.Next(1, 7);
    randomTwo = Random.Shared.Next(1, 7);
    count--;
}

Console.WriteLine($"Pirate won {winsPirate} battles");
Console.WriteLine($"Stone Chewer won {winsStoneChewer} battles");
Console.WriteLine($"Ghost Warrior won {winsGhostWarrior} battles");
Console.WriteLine($"Outworlder won {winsOutworlder} battles");
Console.WriteLine($"Monster Knight won {winsMonsterKnight} battles");
Console.WriteLine($"Dark Goblin won {winsDarkGoblin} battles");
Console.WriteLine($"There were {draws} draws");

