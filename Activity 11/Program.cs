Dice dice1 = new Dice();
Dice dice2 = new Dice();

//repeat until both die roll 1
do
{
    dice1.rollDie();
    dice2.rollDie();
    Console.WriteLine(dice1.getValue() + " " + dice2.getValue());
} while(dice1.getValue() != 1 || dice2.getValue() != 1);
Console.WriteLine("Snake eyes!");

internal class Dice
{
    private int sides;
    private int value;
    private Random rand;

    //constructor standard 6-sided die
    public Dice()
    {
        sides = 6;
        rand = new Random();
    }

    //construct custom size die
    public Dice(int sides)
    {
        this.sides = sides;
        rand = new Random();
    }
    public int rollDie()
    {
        //returns a value between 1 and the number of sides
        value = rand.Next(sides)+ 1;
        return value;
    }
    public int getValue()
    {
        return value;
    }
}